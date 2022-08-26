using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Fin_classe_HOPITAL.Agent_Form
{
    public partial class Agent_Dashbord : Form
    {
        Form activeForm;
        public Agent_Dashbord()
        {
            InitializeComponent();
            
        }
        //

        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();

            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.contaneur_a.Controls.Add(childForm);
            this.contaneur_a.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Agent_Dashbord_Load(object sender, EventArgs e)
        {
            //contpanel.Visible = false;
            //chexkedlabel1.Text = "";
            movpanelp2.Visible = false;
            movpanelr.Visible = false;
            movepanelr2.Visible = false;
        }
        private void btrondevous_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Agent_Form.Rendez_vous(), sender);

            movpanelr.Visible = true;
            contpanel.Visible = true;
            movpanelp2.Visible = false;
            movepanelr2.Visible = false;
            //chexkedlabel1.Text = "Gestion Rendez-vous";
        }

        private void btpatient2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Agent_Form.Patient(), sender);

            movpanelp2.Visible = true;
            contpanel.Visible = true;
            movpanelr.Visible = false;
            movepanelr2.Visible = false;
            //chexkedlabel1.Text = "Gestion Patient";
        }

        private void log_out_icon2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Agent_Form.Rendez_vous_web(), sender);

            movpanelp2.Visible = false;
            contpanel.Visible = true;
            movpanelr.Visible = false;
            movepanelr2.Visible = true;
            
        }
    }
}
