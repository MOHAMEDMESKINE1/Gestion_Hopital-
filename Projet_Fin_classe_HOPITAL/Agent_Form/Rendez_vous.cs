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
namespace Projet_Fin_classe_HOPITAL.Agent_Form
{
   
    public partial class Rendez_vous : Form
    {
        BackEnd.Gestion_HopitalEntities16 entities = new BackEnd.Gestion_HopitalEntities16();
        public Rendez_vous()
        {
            InitializeComponent();
        }
        //verifie les champs
        //check fields
        public bool VerifieChamps()
        {
            if (txt_heure.Value ==0 || txt_date.Value.ToString() == null || cb_cin.SelectedIndex == -1 || cb_doc.SelectedIndex ==-1)
                return false;
            return true;


        }
        //Vider champs
        public void ViderChamps()
        {
            txt_date.Value = DateTime.Now;
            cb_cin.SelectedIndex = -1;
            cb_doc.SelectedIndex = -1;
            txt_heure.Value = 0;

        }
        //Refresh Data
        public void RefreshData()
        {
            dg_agent_rv.DataSource = entities.Afficher_Rdv();
            //referesh total record
            lb_total.Text = " Total rendez_vous : " + entities.Rendez_vous.Count().ToString();
        }


        private void Rendez_vous_Load(object sender, EventArgs e)
        {
            //****************************************load
            container_agent_rv.Visible = false;
            bt_modifier_all.Visible = false;
            cb_cin.Enabled = true;
            //afficher liste rdv
            RefreshData();
         
            //dg_agent_rv.DataSource = entities.Afficher_Rdv();
            //dg_agent_rv.DataSource = entities.Rendez_vous.Select(r => new
            //{
            //    Date = r.Date_rdv,
            //    Heure = r.Heure_rdv,
            //    CIN = r.Patient.Cin_pat
            //}).ToList();

            //combo patient
            cb_cin.DataSource = entities.Patient.ToList();
            cb_cin.DisplayMember = "Cin_pat";
            cb_cin.ValueMember = "Cin_pat";

            //combo doctor
            cb_doc.DataSource = entities.AfficherFullName_Doc();
            cb_doc.DisplayMember = "FullName";
            cb_doc.ValueMember = "Id_Doc";
            //vider combo
            cb_cin.SelectedIndex = -1;
          

        }

        private void bt_pop_up_agent_rv_Click(object sender, EventArgs e)
        {
            //*****************************************************************************visible the pop up
            container_agent_rv.Visible = true;
            txt_recherche_agent_rv.ReadOnly = true;
            dg_agent_rv.ReadOnly = true;
            bt_pop_up_agent_rv.Enabled = false;
            //*************************************************************disabled the buttons of update,delete,update_all
            bt_modifier_all.Enabled = false;
            bt_mo_rev.Enabled = false;
            bt_su_rev.Enabled = false;
            ViderChamps();
            cb_cin.Enabled = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //**************************************************************************cancel the pop up modal
            container_agent_rv.Visible = false;
            txt_recherche_agent_rv.ReadOnly = false;
            dg_agent_rv.ReadOnly = false;
            //**************************************************************************enabled all buttons
            bt_pop_up_agent_rv.Enabled = true;
            bt_modifier_all.Enabled = true;
            bt_mo_rev.Enabled = true;
            bt_su_rev.Enabled = true;
            bt_aj_rev.Enabled = true;
            cb_cin.Enabled = true;
            //**************************************************************************hide update-all button
            bt_modifier_all.Visible = false;
            ViderChamps();
        }

        private void bt_modifier_all_Click(object sender, EventArgs e)
        {
            //**********************************************************************on click button upadata all
            container_agent_rv.Visible = true;
            txt_recherche_agent_rv.ReadOnly = true;
            dg_agent_rv.ReadOnly = true;
            //********************************************************************disabled and enabled the button
            bt_pop_up_agent_rv.Enabled = false;
            bt_modifier_all.Enabled = false;
            bt_aj_rev.Enabled = false;
        }

        private void dg_agent_rv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dg_agent_rv.ReadOnly = true;
            cb_cin.Enabled = false;
            try
            {   //************************************************************************show button update all on click on cell
                bt_modifier_all.Visible = true;

                txt_date.Text = dg_agent_rv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_heure.Text = dg_agent_rv.Rows[e.RowIndex].Cells[1].Value.ToString();
                cb_cin.Text = dg_agent_rv.Rows[e.RowIndex].Cells[2].Value.ToString();
                cb_doc.Text = dg_agent_rv.Rows[e.RowIndex].Cells[3].Value.ToString();


            }
            catch
            {

               
            }
         

        }

      

        private void txt_recherche_agent_rv_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_recherche_agent_rv.Text != "")
                {
                    dg_agent_rv.DataSource = entities.rechercherRdvDoc_CIN(txt_recherche_agent_rv.Text);

                }
                else
                {
                    RefreshData();
                }
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

        private void bt_aj_rev_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (VerifieChamps())

                {
                    DateTime date = Convert.ToDateTime(txt_date.Value.Date);
                    int heure = int.Parse(txt_heure.Value.ToString());
                    string cin = cb_cin.SelectedValue.ToString();
                    int nomDoc = int.Parse(cb_doc.SelectedValue.ToString());

                    if (!entities.Rendez_vous.Any(c => c.Date_rdv == date))
                    {
                      
                        entities.Ajouter_Rdv(date, heure, nomDoc, cin);

                        //Clear and Refresh Data
                        ViderChamps();
                        RefreshData();

                        MessageBox.Show("Rendez_vous Bien Ajouté");
                    }
                    else
                    {
                        MessageBox.Show("Ce Patient a déja un Rendez vous  a cette date ");

                    }
                }
                else
                {
                    MessageBox.Show("Remplir tous les champs! ");

                }


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

        private void bt_mo_rev_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (VerifieChamps())
                {
                    string date = txt_date.Value.ToString("yyy-MM-dd");
                    int heure = int.Parse(txt_heure.Value.ToString());
                    string cin =cb_cin.SelectedValue.ToString();
                    int nomDoc =int.Parse(cb_doc.SelectedValue.ToString());

                    //  entities.Modifier_Rdv(Convert.ToDateTime(date), heure, nomDoc,cin);

                    //procedure sql server ila pas marché si pour ca en utilise la requete simple entityF
                    BackEnd.Rendez_vous rdv = entities.Rendez_vous.Where(r => r.Cin_pat ==cin ).FirstOrDefault();
                    rdv.Date_rdv =DateTime.Parse(date);
                    rdv.Heure_rdv = heure;
                    rdv.Id_Doc = nomDoc;
                    entities.SaveChanges();
                   
                    //Clear and Refresh Data
                    ViderChamps();
                    RefreshData();
                    MessageBox.Show("Rendez_vous Bien modifié!");
                }
                else
                {
                    MessageBox.Show("Remplir les champs!");
                }

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

        private void bt_su_rev_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Voulez vous vraiment supprimer cette Rendez-vous ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //check if cb_cin is not empty
                    if (cb_cin.SelectedIndex != -1)
                    {
                        string cin = cb_cin.SelectedValue.ToString();

                        entities.Supprimer_Rdv(cin);

                        //Clear and Refresh Data
                        ViderChamps();
                        RefreshData();
                        //Refresh total record
                        lb_total.Text = " Total rendez_vous : " + entities.Rendez_vous.Count().ToString();


                        MessageBox.Show("Rendez_vous Bien Supprimer!");
                    }
                    else
                    {
                        MessageBox.Show("Sélectionnez  un Patient a supprimer !");
                    }
                }
                
                else
                {
                    MessageBox.Show("Suppression annulé!");
                }

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

        private void bt_an_rev_Click(object sender, EventArgs e)
        {

            ViderChamps();
        }
       
        private void dg_agent_rv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dg_agent_rv.ReadOnly = true;
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            if (dg_agent_rv.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dg_agent_rv.Columns.Count; i++)
                {
                    excel.Cells[1, i] = dg_agent_rv.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dg_agent_rv.Rows.Count; i++)
                {
                    for (int j = 0; j < dg_agent_rv.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dg_agent_rv.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }
        }

        private void bt_pdf_Click(object sender, EventArgs e)
        {
            if (dg_agent_rv.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(dg_agent_rv.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            // pdfTable.HorizontalAlignment = XElement.;

                            foreach (DataGridViewColumn column in dg_agent_rv.Columns)
                            {
                                PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dg_agent_rv.Rows)
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
    }
}
