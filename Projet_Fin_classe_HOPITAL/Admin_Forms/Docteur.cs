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
    public partial class Docteur : Form
    {
        Image image;
        public Docteur()
        {
            InitializeComponent();
        }
        BackEnd.Gestion_HopitalEntities16 entities = new BackEnd.Gestion_HopitalEntities16();

        //clear data
        //Vider les champs
        public void ViderChamps()
        {
            try
            {


                txt_adress.Text = "";
                txt_nom.Text = "";
                txt_prenom.Text = "";
                txt_recherche_admin_Doc.Text = "";
                txt_tele.Text = "";
                txt_pass.Text = "";
                txt_date.Value = DateTime.Now;
                txt_specialite.Text = "";
                picture.Image = null;
                txt_experience.Value = 0;
            }

            catch (Exception ex)
            {

                MessageBox.Show($" Exception :  {ex}");

            }
        }

        //RefreshData
        public void RefreshData()
        {
            //dg_agent_pat.DataSource = entities.Afficher_Patient();
            dg_admin_doc.DataSource = entities.Doctor.Select(d => new
            {   
                ID=d.Id_Doc,
                Nom = d.Nom_Doc,
                Prenom = d.Prenom_Doc,
                Date_Naissance = d.DateNaissance_Doc,
                Specialité=d.Doc_specialite,
                Expérience = d.Doc_experience,
                Adresse=d.Doc_addr,
                Téléphone=d.Doc_phone,
                Password = d.Doc_pass,
                Image = d.Doc_Image

              
            }).ToList();
            //refresh total record
            lb_total.Text = " Total Docteur : " + entities.Doctor.Count().ToString();

        }

        //check fields
        public bool VerifieChamps()
        {
            if (txt_nom.Text == string.Empty || txt_prenom.Text == string.Empty || txt_date.Value.ToString() == string.Empty || txt_experience.Value == 0 || txt_pass.Text == string.Empty || txt_tele.Text == string.Empty || txt_specialite.Text==string.Empty || picture.Image == null)
                return false;
            return true;


        }
        private void Docteur_Load(object sender, EventArgs e)
        {
          
            //****************************************load
            container_admin_doc.Visible = false;
            bt_modifier_all.Visible = false;
            dg_admin_doc.ReadOnly = true;
            //refresh data
            RefreshData();
            dg_admin_doc.Columns["ID"].Visible = false;
            dg_admin_doc.Columns["Image"].Visible = false;

            ViderChamps();
            bt_print.Visible = false;

        }

        private void bt_pop_up_admin_doc_Click(object sender, EventArgs e)
        {
            //*****************************************************************************visible the pop up
            container_admin_doc.Visible = true;
            bt_pop_up_admin_doc.Enabled = false;
            txt_recherche_admin_Doc.ReadOnly = true;
            dg_admin_doc.ReadOnly = true;
            //*************************************************************disabled the buttons of update,delete,update_all
            bt_mo_doc.Enabled = false;
            bt_su_doc.Enabled = false;
            bt_modifier_all.Enabled = false;
            ViderChamps();
            bt_print.Visible = false;
        }

        private void bt_modifier_all_Click(object sender, EventArgs e)
        {
            //**********************************************************************on click button upadata all
            container_admin_doc.Visible = true;
            bt_pop_up_admin_doc.Enabled = false;
            txt_recherche_admin_Doc.ReadOnly = true;
            //********************************************************************disabled and enabled the button
            dg_admin_doc.ReadOnly = true;
            bt_aj_doc.Enabled = false;
            bt_modifier_all.Enabled = false;
            bt_print.Visible = false;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //**************************************************************************cancel the pop up modal
            container_admin_doc.Visible = false;
            bt_pop_up_admin_doc.Enabled = true;
            txt_recherche_admin_Doc.ReadOnly = false;
            //**************************************************************************enabled all buttons
            dg_admin_doc.ReadOnly = false;
            bt_aj_doc.Enabled = true;
            bt_mo_doc.Enabled = true;
            bt_su_doc.Enabled = true;
            bt_modifier_all.Enabled = true;
            bt_pop_up_admin_doc.Enabled = true;
            //**************************************************************************hide update-all button
            bt_modifier_all.Visible = false;
            ViderChamps();
        }
        int id_doct;
        private void dg_admin_doc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //************************************************************************show button update all on click on cell
                bt_modifier_all.Visible = true;

                id_doct = int.Parse(dg_admin_doc.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_nom.Text = dg_admin_doc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_prenom.Text = dg_admin_doc.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_date.Text = dg_admin_doc.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_specialite.Text = dg_admin_doc.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_experience.Value = Decimal.Parse(dg_admin_doc.Rows[e.RowIndex].Cells[5].Value.ToString());
                txt_adress.Text = dg_admin_doc.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_tele.Text = dg_admin_doc.Rows[e.RowIndex].Cells[7].Value.ToString();
                txt_pass.Text = dg_admin_doc.Rows[e.RowIndex].Cells[8].Value.ToString();
                //get image from database 
                MemoryStream ms = new MemoryStream((byte[])dg_admin_doc.Rows[e.RowIndex].Cells[9].Value);
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


        private void bt_aj_doc_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {
                    string nom = txt_nom.Text.ToString();
                    string prenom = txt_prenom.Text.ToString();
                    DateTime date = Convert.ToDateTime(txt_date.Value.Date);
                    string telephone = txt_tele.Text;
                    int experience = int.Parse(txt_experience.Text);
                    string specialite = txt_specialite.Text.ToString();
                    string password = txt_pass.Text.ToString();
                    string adresse = txt_adress.Text.ToString();
                    //image 
                    ImageConverter converter = new ImageConverter();
                    byte[] imagebyte = (byte[])converter.ConvertTo(image, typeof(byte[]));

                   
                    //check if record already exist in database
                    if (!entities.Doctor.Any(c => c.Nom_Doc == txt_nom.Text && c.Prenom_Doc==txt_prenom.Text))
                    {
                        entities.Ajouter_Docteur( nom, prenom, date, specialite, experience ,telephone,adresse ,password ,imagebyte);

                        //clear and refresh data
                        ViderChamps();
                        RefreshData();
                        MessageBox.Show("Docteur bien ajouté!");
                    }
                    else
                    {
                        MessageBox.Show("Cet Docteur existe déja  !");
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

        private void bt_mo_doc_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {
                    string nom = txt_nom.Text.ToString();
                    string prenom = txt_prenom.Text.ToString();
                    DateTime date = Convert.ToDateTime(txt_date.Value.Date);
                    string telephone = txt_tele.Text;
                    int experience = int.Parse(txt_experience.Text);
                    string specialite = txt_specialite.Text.ToString();
                    string password = txt_pass.Text.ToString();
                    string adresse = txt_adress.Text.ToString();
                    //image 
                    ImageConverter converter = new ImageConverter();
                    byte[] imagebyte = (byte[])converter.ConvertTo(image, typeof(byte[]));


                    if (MessageBox.Show(" Voulez vous vraiment modifier cet agent?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        entities.Modifier_Docteur(id_doct,nom, prenom, date, specialite, experience, telephone, adresse, password, imagebyte);

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

        private void bt_su_doc_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Voulez vous vraiment supprimer cet agent?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    
                       

                        entities.Supprimer_Docteur(id_doct);

                        //Clear and refresh data
                        ViderChamps();
                        RefreshData();
                        //refresh total record
                        lb_total.Text = " Total Docteur : " + entities.Doctor.Count().ToString();
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

        private void bt_an_doc_Click(object sender, EventArgs e)
        {
            ViderChamps();

        }

        private void txt_recherche_admin_Doc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_recherche_admin_Doc.Text != "")
                {
                    dg_admin_doc.DataSource = entities.Doctor.Where(d => d.Nom_Doc == txt_recherche_admin_Doc.Text).Select(d => new
                    {
                        ID = d.Id_Doc,
                        Nom = d.Nom_Doc,
                        Prenom = d.Prenom_Doc,
                        Date_Naissance = d.DateNaissance_Doc,
                        Specialité = d.Doc_specialite,
                        Expérience = d.Doc_experience,
                        Adresse = d.Doc_addr,
                        Téléphone = d.Doc_phone,
                        Password = d.Doc_pass,
                        Image = d.Doc_Image

                    }).ToList();

                }
                else
                {
                    RefreshData();
                }

                lb_total.Text = "Total Docteur " + entities.Doctor.Count();

            }
            catch
            {

            }
            bt_print.Visible = false;
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            if (dg_admin_doc.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dg_admin_doc.Columns.Count; i++)
                {
                    excel.Cells[1, i] = dg_admin_doc.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dg_admin_doc.Rows.Count; i++)
                {
                    for (int j = 0; j < dg_admin_doc.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dg_admin_doc.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;

                
            }
            bt_print.Visible = false;
        }

        private void bt_pdf_Click(object sender, EventArgs e)
        {
            if (dg_admin_doc.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(dg_admin_doc.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            // pdfTable.HorizontalAlignment = XElement.;

                            foreach (DataGridViewColumn column in dg_admin_doc.Columns)
                            {
                                PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dg_admin_doc.Rows)
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
            Reporting.Details_Docteur report = new Reporting.Details_Docteur();
            report.Parameters["ID_DOC"].Value = id_doct;
            report.Parameters["ID_DOC"].Visible = false;
            report.CreateDocument();
            report.ShowPreview();
        }
    }
}
