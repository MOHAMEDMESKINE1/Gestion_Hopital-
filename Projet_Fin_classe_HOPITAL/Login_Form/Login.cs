using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Projet_Fin_classe_HOPITAL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // SqlConnection cnx = new SqlConnection(@"Data Source=PC-MED\SQLEXPRESS;Initial Catalog=Gestion_Hopital;Integrated Security=True");

        BackEnd.Gestion_HopitalEntities16 entities = new BackEnd.Gestion_HopitalEntities16();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public bool LoginDocteur()
        {
            if (entities.Doctor.Any(d => d.Nom_Doc == txt_nom_uti.Text && d.Doc_pass == txt_mot_pass.Text))
                return true;
            return false;
        }
        public bool LoginAgent()
        {
            entities.Agent.Where(a => a.Nom_ag == txt_nom_uti.Text && a.Password_ag == txt_mot_pass.Text).FirstOrDefault();
            return true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            if (txt_mot_pass.Text != "" && txt_nom_uti.Text != "")
            {

                if (rd_docteur.Checked)
                {
                    var login_docteur = entities.Doctor.Where(d => d.Nom_Doc.Equals(txt_nom_uti.Text) && d.Doc_pass.Equals(txt_mot_pass.Text)).FirstOrDefault();

                    if (login_docteur != null)
                    {


                        Doctor_Forms.Doctor_Dashbord doctor = new Doctor_Forms.Doctor_Dashbord();
                        doctor.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Password or username incorrect");
                    }

                }
                else if (rd_agent.Checked)
                {
                    var login_agent = entities.Agent.Where(a => a.Nom_ag.Equals(txt_nom_uti.Text) && a.Password_ag.Equals(txt_mot_pass.Text)).FirstOrDefault();

                    if (login_agent != null)
                    {


                        Agent_Form.Agent_Dashbord agent = new Agent_Form.Agent_Dashbord();
            agent.Show();
            this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Password or username incorrect");
                    }


                }
                else if (rd_admin.Checked)
                {
                    var login_admin = entities.Admin.Where(ad => ad.nom_admin.Equals(txt_nom_uti.Text) && ad.password_admin.Equals(txt_mot_pass.Text)).FirstOrDefault();

                    if (login_admin != null)
                    {
                        Admin_Forms.Admin_Dashbord admin = new Admin_Forms.Admin_Dashbord();
            admin.Show();
            this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password or username incorrect");

                    }

                }


            }
            else
            {
                MessageBox.Show("Verifies les champs !");
            }


        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_mot_pass_IconRightClick(object sender, EventArgs e)
        {
            if(txt_mot_pass.Text != string.Empty)
            {
                if (txt_mot_pass.UseSystemPasswordChar)
                {
                    txt_mot_pass.UseSystemPasswordChar = false;
                }
                else
                {
                    txt_mot_pass.UseSystemPasswordChar = true;
                }
            }
        }

        private void txt_mot_pass_TextChanged(object sender, EventArgs e)
        {

            //Type type = this.GetType();
            //System.Resources.ResourceManager resources =
            //new System.Resources.ResourceManager(type.Namespace + ".Properties.Resources", this.GetType().Assembly);

            //// here it comes, call GetObject just with the resource name, no namespace and no extension
            //this.Icon = (System.Drawing.Icon)resources.GetObject("visibility");
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
