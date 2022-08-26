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
using Image = System.Drawing.Image;

namespace Projet_Fin_classe_HOPITAL.Agent_Form
{

    public partial class Patient : Form
    {
        Image image;
        public Patient()
        {

            InitializeComponent();
        }
        //entities
        BackEnd.Gestion_HopitalEntities16 entities = new BackEnd.Gestion_HopitalEntities16();

        //check fields
        public bool VerifieChamps()
        {
            if (txt_cin.Text == string.Empty || txt_adress.Text == string.Empty || txt_date.Value.ToString() == string.Empty || txt_nom.Text == string.Empty || txt_prenom.Text == string.Empty || txt_tele.Text == string.Empty || rd_female.Checked == false && rd_male.Checked == false || cb_maladie.SelectedIndex == -1 || picture.Image == null)
                return false;
            return true;


        }
        //RefreshData
        public void RefreshData()
        {
            //dg_agent_pat.DataSource = entities.Afficher_Patient();
            dg_agent_pat.DataSource = entities.Patient.Select(p => new
            {
                CIN = p.Cin_pat,
                Nom = p.Nom_pat,
                Prenom = p.Prenom_pat,
                Genre = p.Genre_pat,
                Date_Naissance = p.DateNaissance_pat,
                Adresse = p.Adresse_pat,
                Phone = p.Phone_pat,
                Maladie = p.Ordonnance.Maladie
            }).ToList();
            //total record
            lb_total.Text = " Total Patient : " + entities.Patient.Count().ToString();

        }
        //clear data
        //Vider les champs
        public void ViderChamps()
        {
            try
            {


                txt_adress.Text = "";
                txt_nom.Text = "";
                txt_prenom.Text = "";
                txt_recherche_agent_pat.Text = "";
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

                MessageBox.Show($" Exception :  {ex}");

            }
        }
        private void Patient_Load(object sender, EventArgs e)
        {
            //****************************************load
            container_agent_pat.Visible = false;
            bt_modifier_all.Visible = false;
            cb_maladie.SelectedIndex = -1;
            dg_agent_pat.ReadOnly = true;

            //datagridview 
            dg_agent_pat.DataSource = entities.Afficher_Patient();
            dg_agent_pat.Columns["Image"].Visible = false;

            //combo maladie
            cb_maladie.DataSource = entities.Ordonnance.ToList();
            cb_maladie.DisplayMember = "Maladie";
            cb_maladie.ValueMember = "Ord_Num";
            //remplir count label
            lb_total.Text = "Total Patient " + entities.Patient.Count();
            txt_cin.ReadOnly = false;
        }

        private void bt_pop_up_agent_pat_Click(object sender, EventArgs e)
        {
            //*****************************************************************************visible the pop up
            container_agent_pat.Visible = true;
            txt_recherche_agent_pat.ReadOnly = true;
            dg_agent_pat.ReadOnly = true;
            bt_pop_up_agent_pat.Enabled = false;
            //*************************************************************disabled the buttons of update,delete,update_all
            bt_modifier_all.Enabled = false;
            bt_mo_pat.Enabled = false;
            bt_su_pat.Enabled = false;
            ViderChamps();
            txt_cin.Enabled = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //**************************************************************************cancel the pop up modal
            container_agent_pat.Visible = false;
            txt_recherche_agent_pat.ReadOnly = false;
            dg_agent_pat.ReadOnly = false;
            //**************************************************************************enabled all buttons
            bt_pop_up_agent_pat.Enabled = true;
            bt_modifier_all.Enabled = true;
            bt_aj_pat.Enabled = true;
            bt_mo_pat.Enabled = true;
            bt_su_pat.Enabled = true;
            //**************************************************************************hide update-all button
            bt_modifier_all.Visible = false;
            txt_cin.ReadOnly = false;
            ViderChamps();
        }

        private void bt_modifier_all_Click(object sender, EventArgs e)
        {
            //**********************************************************************on click button upadata all
            container_agent_pat.Visible = true;
            txt_recherche_agent_pat.ReadOnly = true;
            dg_agent_pat.ReadOnly = true;
            //********************************************************************disabled and enabled the button
            bt_pop_up_agent_pat.Enabled = false;
            bt_modifier_all.Enabled = false;
            bt_aj_pat.Enabled = false;
        }

        private void dg_agent_pat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //************************************************************************show button update all on click on cell
            bt_modifier_all.Visible = true;
            txt_cin.ReadOnly = true;

            try
            {
                

                txt_cin.Text = dg_agent_pat.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_nom.Text = dg_agent_pat.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_prenom.Text = dg_agent_pat.Rows[e.RowIndex].Cells[2].Value.ToString();

              

                if (dg_agent_pat.Rows[e.RowIndex].Cells[3].Value.ToString() == "Male")
                {
                    rd_male.Checked = true;
                }
                else
                {
                    rd_female.Checked = true;
                }


                txt_date.Text = dg_agent_pat.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_adress.Text = dg_agent_pat.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_tele.Text = dg_agent_pat.Rows[e.RowIndex].Cells[6].Value.ToString();
                
                //get image from gridview 
                MemoryStream ms = new MemoryStream((byte[])dg_agent_pat.Rows[e.RowIndex].Cells[7].Value);
                picture.Image =Image.FromStream(ms);

                cb_maladie.Text = dg_agent_pat.Rows[e.RowIndex].Cells[8].Value.ToString();

              

            }
            catch
            {


            }
            //comment en peut recuperer l'image a modifier??
        }

        private void bt_aj_pat_Click(object sender, EventArgs e)
        {
            try
            {
                txt_cin.ReadOnly = false;
                if (VerifieChamps())
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
                       entities.Ajouter_Patient(cin, nom, prenom, gendre, date, telephone, adresse, imagebyte,maladie );

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
                //refresh total record
                lb_total.Text = " Total Patient : " + entities.Patient.Count().ToString();

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


        private void bt_mo_pat_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (VerifieChamps())
                {
                    string nom = txt_nom.Text.ToString();
                    string prenom = txt_prenom.Text.ToString();
                    string date = txt_date.Value.ToString("yyy-MM-dd");
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
                    if (MessageBox.Show(" Voulez vous vraiment modifier cet agent?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        entities.Modifier_Patient(cin, nom, prenom, gendre, Convert.ToDateTime(date), adresse, telephone, maladie, imagebyte);

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

        private void bt_su_pat_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Voulez vous vraiment supprimer cet agent?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //check if txt_cin is not empty
                    if (txt_cin.Text != "")
                    {
                        string cin = txt_cin.Text;

                        entities.Supprimer_Patient(cin);

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
   

        private void txt_recherche_agent_pat_TextChanged(object sender, EventArgs e)
        {


            try
            {
                if (txt_recherche_agent_pat.Text != "")
                {
                    dg_agent_pat.DataSource = entities.Recherche_Patient_CIN(txt_recherche_agent_pat.Text);

                }
                else
                {
                    RefreshData();
                }
               
                lb_total.Text = "Total Patient "+ entities.Patient.Count();

            }
            catch (SqlException sqlex)
            {
                MessageBox.Show($"SQLException : {sqlex}");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception : {ex}");
            }



        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            if (dg_agent_pat.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dg_agent_pat.Columns.Count; i++)
                {
                    excel.Cells[1, i] = dg_agent_pat.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dg_agent_pat.Rows.Count; i++)
                {
                    for (int j = 0; j < dg_agent_pat.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dg_agent_pat.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }
        }

        private void bt_pdf_Click(object sender, EventArgs e)
        {
            if (dg_agent_pat.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(dg_agent_pat.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            // pdfTable.HorizontalAlignment = XElement.;

                            foreach (DataGridViewColumn column in dg_agent_pat.Columns)
                            {
                                PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dg_agent_pat.Rows)
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

        private void dg_agent_pat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
