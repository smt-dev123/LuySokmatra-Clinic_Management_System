using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace LuySokmatra_ClinicManagementSystem.Classes
{
    public class ClsDBHelper
    {
        public int PK_ID = 0;
        public bool isUpdate = false;

        private void SetComboBoxDataSource(ComboBox comboBox, DataTable dataTable, string primaryKey, string displayName)
        {
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = displayName;   // The column name to display
            if (!string.IsNullOrEmpty(primaryKey))
            {
                comboBox.ValueMember = primaryKey;  // The column name for the value
            }
        }
        public void LoadDataIntoComboBox(string sql, ComboBox comboBox, string primaryKey, string displayName)
        {
            try
            {
                // Create a new DataTable to hold the data
                DataTable dataTable = new DataTable();

                // Create a new SqlConnection
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConStr))
                {
                    // Create a new SqlCommand
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Create a new SqlDataAdapter
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Fill the DataTable with data from the database
                            adapter.Fill(dataTable);
                        }
                    }
                }

                // Ensure the ComboBox is updated on the UI thread
                if (comboBox.InvokeRequired)
                {
                    comboBox.Invoke(new Action(() => SetComboBoxDataSource(comboBox, dataTable, primaryKey, displayName)));
                }
                else
                {
                    SetComboBoxDataSource(comboBox, dataTable, primaryKey, displayName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public void LoadDataIntoComboBox2(string sql, ComboBox cboName, string primaryKey, string displayName)
        {
            try
            {
                // Create a new DataTable to hold the data
                DataTable dataTable = new DataTable();

                // Create a new SqlConnection
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConStr))
                {
                    // Create a new SqlCommand
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Create a new SqlDataAdapter
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Fill the DataTable with data from the database
                            adapter.Fill(dataTable);
                        }
                    }
                }

                // Set the DataSource, DisplayMember, and ValueMember of the ComboBox
                cboName.DataSource = dataTable;
                cboName.DisplayMember = displayName;   // The column name to display
                if (!string.IsNullOrEmpty(primaryKey))
                {
                    cboName.ValueMember = primaryKey;  // The column name for the value
                }
            }
            catch (Exception ex)
            {
                //.Show("An error occurred: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        public void SaveDataToDatabase(string connectionString, string sqlCommandText, List<SqlParameter> parameters)
        {
            // Create a new SqlConnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand
                using (SqlCommand command = new SqlCommand(sqlCommandText, connection))
                {
                    // Add the parameters to the SqlCommand
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters.ToArray());
                    }
                    // Open the connection
                    connection.Open();

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DisplayDataGridView(string sql = null, string connectionString = null, DataGridView dgvList = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (sql != null)
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(sql, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dgvList.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FormatDataGrid(DataGridView dgv, Font font, int rowTemplateHeight, int rowHeight, Dictionary<int, int> columnWidths, int imageColumnIndex = -1)
        {
            // Set default font and row template height
            dgv.DefaultCellStyle.Font = font;
            dgv.ColumnHeadersDefaultCellStyle.Font = font;
            dgv.RowTemplate.Height = rowTemplateHeight;

            // Loop through rows and apply formatting
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                row.Height = rowHeight;

                // Set column widths
                foreach (var colWidth in columnWidths)
                {
                    if (colWidth.Key < dgv.Columns.Count)
                    {
                        dgv.Columns[colWidth.Key].Width = colWidth.Value;
                    }
                }

                // Check for image column and apply image layout
                if (imageColumnIndex != -1 && imageColumnIndex < dgv.Columns.Count)
                {
                    if (dgv.Rows[i].Cells[imageColumnIndex].ValueType == typeof(byte[]))
                    {
                        ((DataGridViewImageCell)dgv.Rows[i].Cells[imageColumnIndex]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                }
            }

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
        }
        public void FormatDataGrid(
        DataGridView dgv,
        Font font,
        int rowTemplateHeight,
        int rowHeight,
        Dictionary<int, int> columnWidths,
        int imageColumnIndex = -1,
        Color? headerBackColor = null,
        Color? headerForeColor = null)
        {
            // Set default font and row template height
            dgv.DefaultCellStyle.Font = font;
            dgv.RowTemplate.Height = rowTemplateHeight;

            // Set header colors if provided
            if (headerBackColor.HasValue)
            {
                dgv.ColumnHeadersDefaultCellStyle.BackColor = headerBackColor.Value;
                dgv.EnableHeadersVisualStyles = false; // This line ensures that the custom colors are applied
            }

            if (headerForeColor.HasValue)
            {
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor.Value;
            }

            // Loop through rows and apply formatting
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                row.Height = rowHeight;

                // Set column widths
                foreach (var colWidth in columnWidths)
                {
                    if (colWidth.Key < dgv.Columns.Count)
                    {
                        dgv.Columns[colWidth.Key].Width = colWidth.Value;
                    }
                }

                // Check for image column and apply image layout
                if (imageColumnIndex != -1 && imageColumnIndex < dgv.Columns.Count)
                {
                    if (dgv.Rows[i].Cells[imageColumnIndex].ValueType == typeof(byte[]))
                    {
                        ((DataGridViewImageCell)dgv.Rows[i].Cells[imageColumnIndex]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                }
            }

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;

        }

        public void DeleteRecord(string tableName, string columnName, int id, EventHandler onSuccess, string connectionString = null)
        {
            try
            {
                DialogResult opt = MessageBox.Show("Do you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
                if (opt == DialogResult.Yes)
                {
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        string sql = $"DELETE FROM {tableName} WHERE {columnName} = @Id";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Record Deleted Successfully!", "Delete record!");
                        onSuccess?.Invoke(null, EventArgs.Empty);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
