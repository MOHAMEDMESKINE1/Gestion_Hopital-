using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.IO;
using Excl = Microsoft.Office.Interop.Excel;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;
using Image = System.Drawing.Image;

namespace Projet_Fin_classe_HOPITAL.Admin_Forms
{
    public partial class Agent : Form
    {
        Image image;
        public Agent()
        {
            InitializeComponent();
        }

        BackEnd.Gestion_HopitalEntities16 entities = new BackEnd.Gestion_HopitalEntities16();

        //check fields
        public bool VerifieChamps()
        {
            if (txt_nom.Text == string.Empty || txt_prenom.Text == string.Empty || txt_date.Value.ToString() == string.Empty ||  txt_pass.Text == string.Empty || txt_tele.Text == string.Empty || txt_adres.Text == string.Empty || picture.Image == null)
                return false;
            return true;


        }
        //Vider les champs
        public void ViderChamps()
        {
            try
            {


                txt_nom.Text = "";
                txt_prenom.Text = "";
                txt_pass.Text = "";
                txt_date.Text = DateTime.Now.ToShortDateString().ToString();
                txt_adres.Text = "";
                txt_tele.Text = "";
                picture.Image = null;
            }

            catch (Exception ex)
            {

                MessageBox.Show($" Exception :  {ex}");

            }
        }
        public void RefreshData()
        {
            dg_admin_age.DataSource = entities.Agent.Select(a => new
            {
                ID = a.Id_ag,
                Nom = a.Nom_ag,
                Prénom = a.Prenom_ag,
                Date_Naissance = a.DateNaissance_ag,
                Phone = a.Phone_ag,
                Adresse = a.Adresse_ag,
                Password =a.Password_ag,
                Image =a.Image_ag


            }).ToList();

            lb_total.Text = "Total agent : " + entities.Agent.Count().ToString();
        }
        private void Agent_Load(object sender, EventArgs e)
        {
            //****************************************load
            container_admin_age.Visible = false;
            bt_modifier_all.Visible = false;
            dg_admin_age.ReadOnly = true;
            //datagridview 
            RefreshData();
            dg_admin_age.Columns["ID"].Visible = false;
            dg_admin_age.Columns["Image"].Visible = false;
            ViderChamps();
            bt_print.Visible = false;
        }

    

        private void bt_pop_up_admin_patient_Click(object sender, EventArgs e)
        {
            //*****************************************************************************visible the pop up
            container_admin_age.Visible = true;
            bt_pop_up_admin_age.Enabled = false;
            txt_recherche_admin_age.ReadOnly = true;
            dg_admin_age.ReadOnly = true;
            //*************************************************************disabled the buttons of update,delete,update_all
            bt_mo_age.Enabled = false;
            bt_su_age.Enabled = false;
            bt_modifier_all.Enabled = false;
            ViderChamps();
            bt_print.Visible = false;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //**************************************************************************cancel the pop up modal
            container_admin_age.Visible = false;
            bt_pop_up_admin_age.Enabled = true;
            txt_recherche_admin_age.ReadOnly = false;
            //**************************************************************************enabled all buttons
            dg_admin_age.ReadOnly = false;
            bt_modifier_all.Enabled = true;
            bt_aj_age.Enabled = true;
            bt_su_age.Enabled = true;
            bt_mo_age.Enabled = true;
            bt_pop_up_admin_age.Enabled = true;
            //**************************************************************************hide update-all button
            bt_modifier_all.Visible = false;
            ViderChamps();
        }

        private void bt_modifier_all_Click(object sender, EventArgs e)
        {
            //**********************************************************************on click button upadata all
            container_admin_age.Visible = true;
            bt_pop_up_admin_age.Enabled = false;
            txt_recherche_admin_age.ReadOnly = true;
            //********************************************************************disabled and enabled the button
            dg_admin_age.ReadOnly = true;
            bt_aj_age.Enabled = false;
            bt_modifier_all.Enabled = false;
            bt_print.Visible = false;
        }

        int id_agent;
        private void dg_admin_age_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //************************************************************************show button update all on click on cell
                bt_modifier_all.Visible = true;

                id_agent = int.Parse(dg_admin_age.Rows[e.RowIndex].Cells[0].Value.ToString());

                txt_nom.Text = dg_admin_age.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_prenom.Text = dg_admin_age.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_date.Text = dg_admin_age.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_adres.Text = dg_admin_age.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_tele.Text = dg_admin_age.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_pass.Text = dg_admin_age.Rows[e.RowIndex].Cells[6].Value.ToString();
                //get image from database 
                MemoryStream ms = new MemoryStream((byte[])dg_admin_age.Rows[e.RowIndex].Cells[7].Value);
                picture.Image = Image.FromStream(ms);

            }
            catch
            {

               
            }
            bt_print.Visible = true;

        }
        private void bt_aj_img_Click(object sender, EventArgs e)
        {
            try
            {
                //Image insertion
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picture.Image = Image.FromFile(ofd.FileName);
                    image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($" Exception :  {ex}");

            }

        }
        private void txt_recherche_admin_age_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_recherche_admin_age.Text != "")
                {
                    dg_admin_age.DataSource = entities.Agent.Where(a => a.Nom_ag == txt_recherche_admin_age.Text).Select(a => new
                    {
                        ID = a.Id_ag,
                        Nom = a.Nom_ag,
                        Prénom = a.Prenom_ag,
                        Date_Naissance = a.DateNaissance_ag,
                        Phone = a.Phone_ag,
                        Adresse = a.Adresse_ag,
                        Password = a.Password_ag,
                        Image = a.Image_ag

                    }).ToList();

                }
                else
                {
                    RefreshData();
                }


            }
            catch
            {

            }
            bt_print.Visible = false;
        }
        private void bt_aj_age_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {
                    string nom = txt_nom.Text.ToString();
                    string prenom = txt_prenom.Text.ToString();
                    DateTime date = Convert.ToDateTime(txt_date.Value.Date);
                    string adresse = txt_adres.Text.ToString();
                    string telephone = txt_tele.Text;
                    string password = txt_pass.Text.ToString();
                   
                    //image 
                    ImageConverter converter = new ImageConverter();
                    byte[] imagebyte = (byte[])converter.ConvertTo(image, typeof(byte[]));


                    //check if  a record already exist in database
                    if (!entities.Agent.Any(c => c.Nom_ag == txt_nom.Text && c.Prenom_ag == txt_prenom.Text))
                    {
                        entities.Ajouter_Agent( nom, prenom, telephone,date, adresse, password, imagebyte);
                       
                        //clear and refresh data
                        ViderChamps();
                        RefreshData();
                        MessageBox.Show("Agent bien ajouté!");
                    }
                    else
                    {
                        MessageBox.Show("Cet agent existe déja  !");
                    }



                }
                else
                {
                    MessageBox.Show("Remplir les champs!");

                }

            }
            catch (SqlException sqlex)
            {
                MessageBox.Show($"SQL Exception :  {sqlex}");
            }
            catch (Exception ex)
            {

                MessageBox.Show($" Exception :  {ex}");

            }
        }

        private void bt_mo_age_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {
                    string nom = txt_nom.Text.ToString();
                    string prenom = txt_prenom.Text.ToString();
                    DateTime date = Convert.ToDateTime(txt_date.Value.Date);
                    string adresse = txt_adres.Text.ToString();
                    string telephone = txt_tele.Text;
                    string password = txt_pass.Text.ToString();
                    //image 
                    ImageConverter converter = new ImageConverter();
                    byte[] imagebyte = (byte[])converter.ConvertTo(image, typeof(byte[]));


                    if (MessageBox.Show(" Voulez vous vraiment modifier cet agent?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        entities.Modifier_Agent(id_agent, nom, prenom, telephone,date, adresse, password, imagebyte);

                        //clear and refresh data
                        ViderChamps();
                        RefreshData();
                        MessageBox.Show("Bien modifié!");
                    }
                    else
                    {
                        MessageBox.Show(" modification annulé!");
                        ViderChamps();
                    }
                }
                else
                {
                    MessageBox.Show(" Remplir les champs!");
                }



            }
            catch (SqlException sqlex)
            {
                MessageBox.Show($"SQL Exception :  {sqlex}");
            }
            catch (Exception ex)
            {

                MessageBox.Show($" Exception :  {ex}");

            }

        }

        private void bt_su_age_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Voulez vous vraiment supprimer cet agent?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    entities.Supprimer_Agent(id_agent);

                    //Clear and refresh data
                    ViderChamps();
                    RefreshData();
                    MessageBox.Show("Bien supprimé");

                }

                else
                {
                    ViderChamps();
                    MessageBox.Show("Suppression annulé !");

                }

            }
            catch (SqlException sqlex)
            {
                MessageBox.Show($"SQL Exception :  {sqlex}");
            }
            catch (Exception ex)
            {

                MessageBox.Show($" Exception :  {ex}");

            }

        }

        private void bt_an_age_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            if (dg_admin_age.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dg_admin_age.Columns.Count; i++)
                {
                    excel.Cells[1, i] = dg_admin_age.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dg_admin_age.Rows.Count; i++)
                {
                    for (int j = 0; j < dg_admin_age.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dg_admin_age.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }
            bt_print.Visible = false;
        }

        private void bt_pdf_Click(object sender, EventArgs e)
        {
            if (dg_admin_age.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dg_admin_age.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            // pdfTable.HorizontalAlignment = XElement.;

                            foreach (DataGridViewColumn column in dg_admin_age.Columns)
                            {
                                PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dg_admin_age.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
            bt_print.Visible = false;

        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            Reporting.Details_Agent report = new Reporting.Details_Agent();
            report.Parameters["ID_AGENT"].Value = id_agent;
            report.Parameters["ID_AGENT"].Visible = false;
            report.CreateDocument();
            report.ShowPreview();
        }
    }
}
