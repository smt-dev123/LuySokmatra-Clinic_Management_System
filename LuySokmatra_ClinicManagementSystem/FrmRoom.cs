using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuySokmatra_ClinicManagementSystem
{
    public partial class FrmRoom : Form
    {
        SqlConnection cnn=new SqlConnection(Properties.Settings.Default.ConStr);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int pk_id = 0;
        bool isUpdate  = false;
        public FrmRoom()
        {
            InitializeComponent();
        }
        //Form DataGridView Cells
        private void FormatGridCell(DataGridView dgvName)
        {
            // Set font for data grid view cells
            dgvName.DefaultCellStyle.Font = new Font("Khmer OS Siemreap", 12);
            // Set font for column headers
            dgvName.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS Siemreap", 12, FontStyle.Bold);

            dgv_Lists.RowTemplate.Height = 30;
            dgv_Lists.Columns[1].Width = 250;
            dgv_Lists.Columns[2].Width = 130;
            dgv_Lists.Columns[4].Width = 230;
            dgv_Lists.Columns[4].DefaultCellStyle.Format = @"dd\/MM\/yyyy";
            dgv_Lists.MultiSelect = false;
            dgv_Lists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Lists.AllowUserToAddRows = false;
            dgv_Lists.AllowUserToDeleteRows = false;

            foreach (DataGridViewRow row in dgv_Lists.Rows)
            {
                row.Height = 45; // Set the desired row height
                row.Resizable = DataGridViewTriState.False; // Disable manual resizing
            }

        }
        private void FrmRoom_Load(object sender, EventArgs e)
        {
            string SQL = "";
            SQL = "select room_id as [ល.រ],room_type as [ប្រភេទបន្ទប់]," +
            "total_room as [បន្ទប់សរុប],rate_day as [តម្លៃ/ថ្ងៃ]," +
           "entry_date [ថ្ងៃបញ្ជូល] from tbl_rooms";
            DisplayData(dgv_Lists, SQL);

            btnDelete.Enabled = false;
        }
        private void DisplayData(DataGridView dgvName, string query)
                {
                    try
                    {
                        if (cnn.State == ConnectionState.Closed)
                        {
                            cnn.Open();
                        }

                        DataTable dt = new DataTable();
                        adapt = new SqlDataAdapter(query, cnn);
                        adapt.Fill(dt);
                        dgvName.DataSource = dt;

                        FormatGridCell(dgvName); // Apply the formatting

                        cnn.Close();
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

                pk_id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                // Display or use the data as needed
                txtRoomType.Text = selectedRow.Cells[1].Value.ToString();
                txtTotalRoom.Text = selectedRow.Cells[2].Value.ToString();
                txtRateDay.Text = selectedRow.Cells[3].Value.ToString();

                //បើក Control
                btnDelete.Enabled = true;
                btnSave.Text = "ធ្វើបច្ចុប្បន្នភាព";
                isUpdate = true;
            }
            else
            {
                MessageBox.Show("No row selected");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Clear the text boxes
            txtRoomType.Text = "";
            txtTotalRoom.Text = "";
            txtRateDay.Text = "";

            // Reset the primary key and update flag
            pk_id = 0;
            isUpdate = false;

            // Disable the delete button
            btnDelete.Enabled = false;

            // Change the save button text back to "Save"
            btnSave.Text = "រក្សាទុក";

            // Set focus to the first input field
            txtRoomType.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                    }
                    string query = "";
                    if (isUpdate == false)
                    {
                        query = "INSERT INTO tbl_rooms  VALUES (@room_type, @total_room,@rate_day,@entry_date)";
                    }
                    else
                    {
                        query = "Update tbl_rooms SET room_type=@room_type,total_room=@total_room,rate_day=@rate_day WHERE room_id=@room_id";
                    }

                    using (SqlCommand command = new SqlCommand(query, cnn))
                    {
                        command.Parameters.AddWithValue("@room_type", txtRoomType.Text);
                        command.Parameters.AddWithValue("@total_room", txtTotalRoom.Text);
                        command.Parameters.AddWithValue("@rate_day", txtRateDay.Text);
                        command.Parameters.AddWithValue("@entry_date", DateTime.Now);
                        if (isUpdate)
                        {
                            command.Parameters.AddWithValue("@room_id", pk_id);
                        }

                        int result = command.ExecuteNonQuery();

                        MessageBox.Show("Record inserted success!", "Save Data!");

                        FrmRoom_Load(sender, e);
                        btnAdd_Click(sender, e);

                        cnn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConStr))
                    {
                        connection.Open();

                        string query = "DELETE FROM tbl_rooms WHERE room_id = @room_id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@room_id", pk_id);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No record deleted. Record with specified ID not found.", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                    btnAdd_Click(sender, e); // Clear form fields
                    FrmRoom_Load(sender, e); // Reload data in DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Lists_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetSelectedRowData(dgv_Lists);
        }
    }
}
