using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projet_Fin_classe_HOPITAL.Admin_Forms
{
   
    public partial class Admin_Dashbord : Form
    {
        Form activeForm;
        public Admin_Dashbord()
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
            this.container.Controls.Add(childForm);
            this.container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Admin_Dashbord_Load(object sender, EventArgs e)
        {
          
            
            movpaneld.Visible = false;
            movepanelp.Visible = false;
            movpanela.Visible = false;
            //chexkedlabel.Text = "";
            //contpanel.Visible = false;
        }

        private void btdocteur_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Admin_Forms.Docteur(), sender);

           /// Docteur doc = new Docteur();
          //  doc.Show();
            movpaneld.Visible = true;
            movepanelp.Visible = false;
            movpanela.Visible = false;
            //chexkedlabel.Text = "Gestion docteur";
            contpanel.Visible = true;
        }

        private void btagent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_Forms.Agent(), sender); 
            movpaneld.Visible = false;
            movepanelp.Visible = false;
            movpanela.Visible = true;
            //chexkedlabel.Text = "Gestion agent";
            contpanel.Visible = true;
        }


        private void btpatient_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Admin_Forms.Patient(), sender);

            movpaneld.Visible = false;
            movepanelp.Visible = true;
            movpanela.Visible = false;
            //chexkedlabel.Text = "Gestion patient";
            contpanel.Visible = true;
        }

     

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
