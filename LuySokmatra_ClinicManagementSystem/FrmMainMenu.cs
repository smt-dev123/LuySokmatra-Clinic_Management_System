using FontAwesome.Sharp;
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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void SetVisibility(Control visibleControl)
        {
            // List all forms in an array or another collection
            Control[] forms = {
            frmHome1, frmDoctorManagement1, frmPatientMangement1,
            frmMedicineType1, frmMedicineMangement1, frmReport1, frmSetting1
            };

            // Set all forms to invisible except the one that needs to be visible
            foreach (Control form in forms)
            {
                form.Visible = form == visibleControl;
            }
        }

        //Fields
        private IconButton currentBtn;

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(48, 5, 130);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(48, 5, 130);
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.IconColor = Color.WhiteSmoke;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(48, 5, 173);
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.IconColor = Color.WhiteSmoke;
            }
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            dateTime.Start();
            txt_dateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy    hh:mm:ss tt");
        }
        private void dateTime_Tick(object sender, EventArgs e)
        {
            txt_dateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy    hh:mm:ss tt");
            dateTime.Start();
            
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 47 ) {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }else
            {
                sidebar.Width += 5;
                if(sidebar.Width >= 178) {
                    sidebarExpand=true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            //sidebarTransition.Start ();
            if (sidebarExpand)
            {
                sidebar.Width = 57;
                if (sidebar.Width <= 57)
                {
                    sidebarExpand = false;
                }
            }
            else
            {
                sidebar.Width = 267;
                if (sidebar.Width >= 267)
                {
                    sidebarExpand = true;
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetVisibility(frmHome1);
            txtList.Text = btnHome.Text;
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnDoctorMangement_Click(object sender, EventArgs e)
        {
            SetVisibility(frmDoctorManagement1);
            txtList.Text = btnDoctorMangement.Text;
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnPatientMangement_Click(object sender, EventArgs e)
        {
            SetVisibility(frmPatientMangement1);
            txtList.Text = btnPatientMangement.Text;
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnMedicineType_Click(object sender, EventArgs e)
        {
            SetVisibility(frmMedicineType1);
            txtList.Text = btnMedicineType.Text;
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnMedicineMangement_Click(object sender, EventArgs e)
        {
            SetVisibility(frmMedicineMangement1);
            txtList.Text = btnMedicineMangement.Text;
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SetVisibility(frmReport1);
            txtList.Text = btnReport.Text;
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SetVisibility(frmSetting1);
            txtList.Text = btnSetting.Text;
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

       
    }
}
