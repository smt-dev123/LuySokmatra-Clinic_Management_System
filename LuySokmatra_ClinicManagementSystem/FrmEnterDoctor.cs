using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuySokmatra_ClinicManagementSystem
{
    public partial class FrmEnterDoctor : Form
    {
        SqlConnection cnn = new SqlConnection(Properties.Settings.Default.ConStr);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int pk_id = 0;
        bool isUpdate = false;
        public FrmEnterDoctor()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            txtName.Text = "";
            txtPhone.Clear();
            txtAddress.Text = "";
            cboGender.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            cboSpecialist.SelectedIndex = 0;
            try
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "medical_doctor.png");
                picProfile.BackgroundImage = Image.FromFile(imagePath);
                picProfile.BackgroundImageLayout = ImageLayout.Stretch; // Adjust the layout as needed
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile image: {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnSave.Enabled = true;
            btnSave.Text = "រក្សាទុក";
            btnDelete.Enabled = false;
            pk_id = 0;
            isUpdate = false;
            txtName.Focus();

        }

        private void formatDataGrid()
        {
            dgv_Lists.DefaultCellStyle.Font = new Font("Khmer OS Siemreap", 12);
            dgv_Lists.RowTemplate.Height = 45;
            dgv_Lists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Lists.AllowUserToAddRows = false;
            dgv_Lists.AllowUserToDeleteRows = false;

            for (int i = 0; i < dgv_Lists.Rows.Count; i++)
            {
                DataGridViewRow r = dgv_Lists.Rows[i];
                r.Height = 50;
                dgv_Lists.Columns[0].Width = 70;
                dgv_Lists.Columns[1].Width = 80;
                dgv_Lists.Columns[2].Width = 235;
                dgv_Lists.Columns[3].Width = 80;
                dgv_Lists.Columns[4].Width = 150;
                dgv_Lists.Columns[5].Width =180;
                dgv_Lists.Columns[6].Width = 306;
                dgv_Lists.Columns[7].Width = 180;

                if (dgv_Lists.Rows[i].Cells[1].ValueType == typeof(byte[]))
                {
                    ((DataGridViewImageCell)dgv_Lists.Rows[i].Cells[1]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }
        private void DisplayData(string sql = null)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                else
                {
                    cnn.Close();
                }
                if (sql == null)
                {
                    sql = "SELECT doctor_id as [ល.រ],profile [រូបភាព],doctor_name as [ឈ្មោះគ្រូពេទ្យ]," +
                        "gender as [ភេទ],phone [ទូរស័ព្ទ]," +
                        "specialist [ឯកទេស],address [អាស័យដ្ឋាន]," +
                        "status [ស្ថានភាព] FROM tbl_doctors";
                }

                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Lists.DataSource = dt;


                formatDataGrid();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmEnterDoctor_Load(object sender, EventArgs e)
        {
            ClearData();
            DisplayData();
            btnAddNew_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Doctor Name", "Doctor Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }

                if (txtPhone.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Phone Number", " Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return;
                }

                if (txtName.Text != "" && txtPhone.Text != "" && cboGender.Text != "")
                {
                    if (isUpdate == true)
                    {
                        cmd = new SqlCommand("UPDATE  tbl_doctors SET doctor_name=@doctor_name,gender=@gender,phone=@phone,specialist=@specialist,address=@address,profile=@profile,status=@status WHERE doctor_id=@doctor_id", cnn);
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into tbl_doctors(doctor_name,gender,phone,specialist,address,profile,status) values(@doctor_name,@gender,@phone,@specialist,@address,@profile,@status)", cnn);

                    }
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@doctor_name", txtName.Text);
                    cmd.Parameters.AddWithValue("@gender", cboGender.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@specialist", cboSpecialist.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@status", cboStatus.Text);
                    if (isUpdate == true)
                    {
                        cmd.Parameters.AddWithValue("@doctor_id", pk_id);
                    }

                    MemoryStream ms = new MemoryStream();
                    picProfile.Image.Save(ms, picProfile.Image.RawFormat);
                    byte[] data = ms.GetBuffer();
                    SqlParameter p = new SqlParameter("@profile", SqlDbType.Image);
                    p.Value = data;
                    cmd.Parameters.Add(p);

                    cmd.ExecuteNonQuery();

                    cnn.Close();
                    MessageBox.Show("Record Inserted Successfully", "Save Record!");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please Provide Details!", "Save Record!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Your Error:" + ex.Message);
                cnn.Close();
            }
        }

        private void btnBrow_Click(object sender, EventArgs e)
        {
            try
            {
                //isImageCaptuerd = false;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "All(*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                ofd.Title = "Please Upload Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picProfile.Image = Image.FromFile(ofd.FileName);
                    picProfile.SizeMode = PictureBoxSizeMode.Zoom;
                    txtName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetSelectedRowData(DataGridView dgvName)
        {
            if (dgvName.SelectedRows.Count > 0) // Check if any row is selected
            {
                DataGridViewRow selectedRow = dgvName.SelectedRows[0]; // Get the first selected row

                cnn.Open();

                pk_id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                cmd = new SqlCommand("SELECT profile FROM tbl_doctors WHERE doctor_id=" + pk_id, cnn);
                byte[] imageData = (byte[])cmd.ExecuteScalar();
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                    {
                        ms.Write(imageData, 0, imageData.Length);
                        picProfile.BackgroundImage = Image.FromStream(ms, true);
                    }
                }
                // Display or use the data as needed
                txtName.Text = selectedRow.Cells[2].Value.ToString();
                cboGender.Text = selectedRow.Cells[3].Value.ToString();
                txtPhone.Text = selectedRow.Cells[4].Value.ToString();
                cboSpecialist.Text = selectedRow.Cells[5].Value.ToString();
                txtAddress.Text = selectedRow.Cells[6].Value.ToString();

                //បើក Control
                btnDelete.Enabled = true;
                btnSave.Text = "កែប្រែ";
                isUpdate = true;

                cnn.Close();

            }
            else
            {
                MessageBox.Show("No row selected");
            }
        }

        private void dgv_Lists_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetSelectedRowData(dgv_Lists);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opt = MessageBox.Show("Do you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
                if (opt == DialogResult.Yes)
                {
                    cnn.Open();
                    SqlDataReader dr = null;
                    string sql;

                    sql = "DELETE FROM tbl_doctors WHERE doctor_id=" + pk_id;

                    cmd = new SqlCommand(sql, cnn);
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Record Deleted Successfully!", "Delete record!");
                    dr.Close();
                    cnn.Close();

                    btnAddNew_Click(sender, e);
                    FrmEnterDoctor_Load(sender, e);
                }
                else
                {
                    cnn.Close();
                }
            }
            catch (SqlException ex)
            {
                //cnn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearData();
            formatDataGrid();
        }
    }
}
