using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Fin_classe_HOPITAL.Doctor_Forms
{
   
    public partial class Doctor_Dashbord : Form
    {
        Form activeForm;
        public Doctor_Dashbord()
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
            this.contaneur_d.Controls.Add(childForm);
            this.contaneur_d.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Doctor_Dashbord_Load(object sender, EventArgs e)
        {
            //OpenChildForm(new Medicament(), sender);

            movepanelom4.Visible = false;
            movepanelp3.Visible = false;
            movpanelr3.Visible = false;
            movpanelt3.Visible = false;
        }

        private void btrendezvous2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Rendez_vous(), sender);

            movepanelom4.Visible = false;
            movepanelp3.Visible = false;
            movpanelr3.Visible = true;
            movpanelt3.Visible = false;
        }

        private void bttest_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Test(), sender);

            movepanelom4.Visible = false;
            movepanelp3.Visible = false;
            movpanelr3.Visible = false;
            movpanelt3.Visible = true;
        }

      

        private void btpatient3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Patient(), sender);

            movepanelom4.Visible = false;
            movepanelp3.Visible = true;
            movpanelr3.Visible = false;
            movpanelt3.Visible = false;
        }

        private void bt_ordonnance_medic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Doctor_Forms.Ordonnance_medicament(), sender);

            movepanelom4.Visible = true;
            movepanelp3.Visible = false;
            movpanelr3.Visible = false;
            movpanelt3.Visible = false;
        }
        private void log_out_icon3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

    }
}
