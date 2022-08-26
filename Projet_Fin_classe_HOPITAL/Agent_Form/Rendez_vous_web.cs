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
using Excl = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Image = System.Drawing.Image;

namespace Projet_Fin_classe_HOPITAL.Agent_Form
{
    public partial class Rendez_vous_web : Form
    {
        public Rendez_vous_web()
        {
            InitializeComponent();
        }

        Image image;
        BackEnd.Gestion_HopitalEntities16 entities = new BackEnd.Gestion_HopitalEntities16();

        //remplir combobox
        public void maladi_combobox()
        {
            cb_maladie.DataSource = entities.Ordonnance.ToList();
            cb_maladie.ValueMember = "Ord_Num";
            cb_maladie.DisplayMember = "Maladie";
        }

        //private object dg_agent_rv;
        public void RefreshData()
        {
            dg_agent_rend2.DataSource = entities.Patient_web.Select(p => new
            {
                CIN = p.cin,
                Nom = p.Nom,
                Prenom = p.prenom,
                Telephone = p.tele,
                Date = p.date_re
               

            }).ToList();
            lb_total.Text = " Total Patient : " + entities.Patient_web.Count().ToString();
        }
        private void Rendez_vous_web_Load(object sender, EventArgs e)
        {
            container_agent_rend2.Visible = false;
            RefreshData();
            txt_cin.ReadOnly = true;
            txt_nom.ReadOnly = true;
            txt_prenom.ReadOnly = true;
            txt_tele.ReadOnly = true;
            
            maladi_combobox();
        }
        //*************************************************************************
        public bool VerifieChamps()
        {
            if (txt_cin.Text == string.Empty|| txt_date.Value.ToString() == string.Empty || txt_nom.Text == string.Empty || txt_prenom.Text == string.Empty || txt_tele.Text == string.Empty )
                return false;
            return true;




        }
        public void ViderChamps()
        {
            try
            {

                txt_adress.Text = "";
                txt_nom.Text = "";
                txt_prenom.Text = "";
                txt_recherche_agent_rend2.Text = "";
                txt_tele.Text = "";
                txt_cin.Text = "";

                txt_date.Value = DateTime.Now;
                rd_female.Checked = false;
                rd_male.Checked = false;
                picture.Image = null;
                cb_maladie.SelectedIndex = -1;
            }



            catch (Exception ex)
            {



                MessageBox.Show($" Exception : {ex}");



            }
        }

        private void dg_agent_rend2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                container_agent_rend2.Visible = true;
                
                txt_cin.Text = dg_agent_rend2.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_nom.Text = dg_agent_rend2.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_prenom.Text = dg_agent_rend2.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_tele.Text = dg_agent_rend2.Rows[e.RowIndex].Cells[3].Value.ToString();
                //txt_date.Text = dg_agent_rend2.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            container_agent_rend2.Visible = false;
            ViderChamps();
        }




        

        ///*****************************************************************

        ///*****************************************************************


        private void bt_pdf_Click(object sender, EventArgs e)
        {
            if (dg_agent_rend2.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(dg_agent_rend2.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            // pdfTable.HorizontalAlignment = XElement.;

                            foreach (DataGridViewColumn column in dg_agent_rend2.Columns)
                            {
                                PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dg_agent_rend2.Rows)
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

        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            if (dg_agent_rend2.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

            for (int i = 1; i < dg_agent_rend2.Columns.Count; i++)
            {
                excel.Cells[1, i] = dg_agent_rend2.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dg_agent_rend2.Rows.Count; i++)
            {
                for (int j = 0; j < dg_agent_rend2.Columns.Count; j++)
                {
                    excel.Cells[i + 2, j + 1] = dg_agent_rend2.Rows[i].Cells[j].Value.ToString();
                }

            }
            excel.Columns.AutoFit();
            excel.Visible = true;


        }
    }

        private void txt_recherche_agent_rend2_TextChanged(object sender, EventArgs e)
        {
            if (txt_recherche_agent_rend2.Text != "")
            {
                dg_agent_rend2.DataSource = entities.Patient_web.Where(p => p.cin == txt_recherche_agent_rend2.Text).Select(p => new
                {
                    CIN = p.cin,
                    Nom = p.Nom,
                    Prenom = p.prenom,
                    Date = p.date_re,
                    Telephone = p.tele



                }).ToList();




            }
            else
            {
                dg_agent_rend2.DataSource = entities.Patient_web.Select(p => new
                {
                    CIN = p.cin,
                    Nom = p.Nom,
                    Prenom = p.prenom,
                    Date = p.date_re,
                    Telephone = p.tele



                }).ToList();
            }


        }


        private void bt_aj_pat_Click(object sender, EventArgs e)
        {
            try
            {
                txt_cin.ReadOnly = false;
                if (txt_adress.Text!="" && txt_date.Text!="" && txt_nom.Text!="" && txt_prenom.Text!="" && txt_tele.Text!="" && picture.Image != null)
                {
                    string nom = txt_nom.Text.ToString();
                    string prenom = txt_prenom.Text.ToString();
                    DateTime date = Convert.ToDateTime(txt_date.Value.Date);
                    string telephone = txt_tele.Text;
                    string adresse = txt_adress.Text.ToString();
                    string cin = txt_cin.Text;
                    int maladie = int.Parse(cb_maladie.SelectedValue.ToString());
                    //image 
                    ImageConverter converter = new ImageConverter();
                    byte[] imagebyte = (byte[])converter.ConvertTo(image, typeof(byte[]));

                    //get value of radiobutton
                    string gendre;
                    if (rd_female.Checked)
                    {
                        gendre = rd_female.Text;
                    }
                    else
                    {
                        gendre = rd_male.Text;
                    }
                    //check if record already exist in database
                    if (!entities.Patient.Any(c => c.Cin_pat == txt_cin.Text))
                    {
                        entities.Ajouter_Patient(cin, nom, prenom, gendre, date, telephone, adresse, imagebyte, maladie);

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

        private void bt_su_pat_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Voulez vous vraiment supprimer cet agent?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //check if txt_cin is not empty
                    if (txt_cin.Text != "")
                    {
                        string cin = txt_cin.Text;

                        entities.Supprimer_rePatient_web(cin);

                        //Clear and refresh data
                        ViderChamps();
                        RefreshData();
                        MessageBox.Show("Bien supprimé");
                    }
                    else
                    {
                        MessageBox.Show("Saisir un cin !");
                    }
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

        private void bt_an_pat_Click(object sender, EventArgs e)
        {
            ViderChamps();
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
    }
}
