using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuySokmatra_ClinicManagementSystem
{
    public partial class FrmMedicineType : UserControl
    {
        public FrmMedicineType()
        {
            InitializeComponent();
        }

        private void btnTreatmentRoom_Click(object sender, EventArgs e)
        {
            FrmRoom room = new FrmRoom();
            room.ShowDialog();
        }
    }
}
