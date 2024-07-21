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
    public partial class FrmTest : Form
    {
        Classes.ClsDBHelper dBHelper = new Classes.ClsDBHelper();
        string connectionString = Properties.Settings.Default.ConStr;
        public FrmTest()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            txtNote.Clear();
            txtType.Clear();
            txtMedicineType.Clear();
            txtMedicineType.Focus();
            btnDelete.Enabled = false;
            btnSave.Text = "រក្សាទុក";
            dBHelper.isUpdate = false;
            dBHelper.PK_ID = 0;
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.ConStr;
            string sqlCommandText = "SELECT MedicineTypeID [ល.រ],MedicineName [ឈ្មោះប្រភេទថ្នាំ],Lots [កន្លែងទុកដាក់]" +
                ",Description [អធិប្បាយពន្យល់],CreatedDate [ថ្ងៃបង្កើត],IsActive [ស្ថានភាព] FROM tbl_MedicineTypes";
            dBHelper.DisplayDataGridView(sqlCommandText, connectionString, dgv_Lists);

            // Create a font for the DataGridView
            Font khmerFont = new Font("Khmer OS Siemreap", 12);
            // Define column widths
            Dictionary<int, int> columnWidths = new Dictionary<int, int>
            {
                {1, 290},{2, 195},{3, 295},{4, 180},{5,100},{6, 50}
            };
            // Call the general formatting function            
            dBHelper.FormatDataGrid(dgv_Lists, khmerFont, 45, 50, columnWidths, -1);

            //btnAdd_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtType.Text == "")
                {
                    txtType.Focus();
                }
                if (txtMedicineType.Text == "")
                {
                    txtMedicineType.Focus();
                }
                if (txtNote.Text == "")
                {
                    txtNote.Focus();
                }
                else
                {

                    string sqlCommandText = "";

                    if (dBHelper.isUpdate == false)
                    {
                        sqlCommandText = "INSERT INTO Tbl_MedicineTypes (MedicineName, Lots,Description,IsActive) " +
                        "VALUES (@MedicineName, @Lots,@Description,@IsActive)";
                    }
                    else
                    {
                        sqlCommandText = "UPDATE Tbl_MedicineTypes SET MedicineName=@MedicineName, " +
                            "Lots=@Lots,Description=@Description,IsActive=@IsActive WHERE MedicineTypeID=@MedicineTypeID";
                    }

                    bool optCheck = false;
                    optCheck = optIsActive.Checked ? true : false;

                    List<SqlParameter> parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@MedicineName",txtType.Text),
                        new SqlParameter("@Lots", txtMedicineType.Text),
                        new SqlParameter("@Description", txtNote.Text),
                        new SqlParameter("@IsActive", optCheck)
                    };
                    if (dBHelper.isUpdate == true)
                    {
                        parameters.Add(new SqlParameter("@MedicineTypeID", dBHelper.PK_ID));
                    }

                    dBHelper.SaveDataToDatabase(connectionString, sqlCommandText, parameters);
                    string DataStatus = dBHelper.isUpdate ? "is updated!" : "is saved!";
                    MessageBox.Show($"Your Data {DataStatus}!", "Save Record!");
                    FrmTest_Load(sender, e);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Saving Data Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dBHelper.DeleteRecord("Tbl_MedicineTypes", "MedicineTypeID", dBHelper.PK_ID, (s, args) =>
                {
                    // Refresh the form or any other necessary actions after a successful delete
                    btnAdd_Click(sender, e);
                    FrmTest_Load(sender, e);
                }, connectionString);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_Lists_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Lists.SelectedRows.Count > 0) // Check if any row is selected
            {
                DataGridViewRow selectedRow = dgv_Lists.SelectedRows[0]; // Get the first selected row
                dBHelper.PK_ID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                txtType.Text = selectedRow.Cells[1].Value.ToString();
                txtNote.Text = selectedRow.Cells[2].Value.ToString();
                txtMedicineType.Text = selectedRow.Cells[3].Value.ToString();

                _ = selectedRow.Cells[5].Value.ToString() == "True" ? optIsActive.Checked = true : optIsActive.Checked = false;

                btnDelete.Enabled = true;
                btnSave.Text = "កែប្រែ";
                dBHelper.isUpdate = true;
            }
        }
    }
}
