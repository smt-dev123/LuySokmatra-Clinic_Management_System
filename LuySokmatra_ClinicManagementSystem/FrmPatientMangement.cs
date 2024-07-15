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
    public partial class FrmPatientMangement : UserControl
    {
        public FrmPatientMangement()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmPatientMangementAdd frmPatientMangementAdd = new FrmPatientMangementAdd();
            frmPatientMangementAdd.ShowDialog();
        }

        private void btnExaminePatients_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInsertinfo_Click(object sender, EventArgs e)
        {
            FrmEnterPatientInfo frmEnterPatientInfo = new FrmEnterPatientInfo();
            frmEnterPatientInfo.ShowDialog();
        }
    }
}
