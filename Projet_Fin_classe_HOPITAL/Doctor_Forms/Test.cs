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

namespace Projet_Fin_classe_HOPITAL.Doctor_Forms
{
    public partial class Test : Form
    {
        BackEnd.Gestion_HopitalEntities16 entities = new BackEnd.Gestion_HopitalEntities16();

        public Test()
        {
            InitializeComponent();            
        }
        //RefreshData
        public void RefreshData()
        {
            //dg_test.DataSource = entities.Test.Select(t => new
            //{
            //    Id = t.Test_num,
            //    Nom = t.Nom_test,
            //    Prix = t.Prix_test,
            //    Docteur = t.Doctor.Nom_Doc
            //}).ToList();
            dg_test.DataSource = entities.AfficherTest();
        }
        //ViderChamps
        public void ViderChamps()
        {
            txt_nom.Text = "";
            txt_prix.Value = 100;
            cb_docteur.SelectedIndex = -1;

        }
        //VerifierChamps
        public bool VerifierChamps()
        {
            if (txt_nom.Text == string.Empty || txt_prix.Value == 0 || cb_docteur.SelectedIndex == -1)
                return false;
            return true;
        }
        //Refresh Total
        public void RefreshTotal()
        {
            lb_total.Text = "Total test : " + entities.Test.Count();
        }
        private void Test_Load(object sender, EventArgs e)
        {
            //****************************************load
            container.Visible = false;
            bt_modifier_all.Visible = false;
            dg_test.ReadOnly = true;
            txt_nom.ReadOnly = true;
            

            //datagridview  test
            RefreshData();

            //cb doctor
            cb_docteur.DataSource = entities.AfficherFullName_Doc();
            cb_docteur.DisplayMember = "Fullname";
            cb_docteur.ValueMember = "Id_Doc";

            //total
            RefreshTotal();
            cb_docteur.Enabled = true;
            //dg_test.Columns["Id"].Visible = false;

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //*****************************************************************************visible the pop up
            txt_recherche.ReadOnly = true;
            dg_test.ReadOnly = true;
            bt_pop_up.Enabled = false;
            container.Visible = true;
            //*************************************************************disabled the buttons of update,delete,update_all
            bt_modifier_all.Enabled = false;
            bt_mo_test.Enabled = false;
            bt_su_test.Enabled = false;
            ViderChamps();
            cb_docteur.Enabled = true;
            txt_nom.ReadOnly = false;
        }


    

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            //**************************************************************************cancel the pop up modal
            container.Visible = false;
            txt_recherche.ReadOnly = false;
            dg_test.ReadOnly = false;
            //**************************************************************************enabled all buttons
            bt_pop_up.Enabled = true;
            bt_modifier_all.Enabled = true;
            bt_aj_test.Enabled = true;
            bt_mo_test.Enabled = true;
            bt_su_test.Enabled = true;
            //**************************************************************************hide update-all button
            bt_modifier_all.Visible = false;
            cb_docteur.Enabled = true;
            txt_nom.ReadOnly = true;
            ViderChamps();
        }

        private void bt_modifier_all_Click(object sender, EventArgs e)
        {
            //**********************************************************************on click button upadata all
            txt_recherche.ReadOnly = true;
            dg_test.ReadOnly = true;
            bt_pop_up.Enabled = false;
            //********************************************************************disabled and enabled the button
            container.Visible = true;
            bt_modifier_all.Enabled = false;
            bt_aj_test.Enabled = false;
            txt_nom.ReadOnly = true;
        }
        //int id_test;
        private void dg_test_CellClick(object sender, DataGridViewCellEventArgs e)
        {  //************************************************************************show button update all on click on cell
            cb_docteur.Enabled = false;

            bt_modifier_all.Visible = true;
            try
            {
                //   int ind = e.RowIndex;
                //  DataGridViewRow selectedRows = dg_test.Rows[ind];
                // DataGridViewRow selectedRowscombo = (DataRowView)cb_docteur.SelectedItem;
                //id_test = int.Parse(dg_test.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_nom.Text = dg_test.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_prix.Value = Convert.ToDecimal(dg_test.Rows[e.RowIndex].Cells[1].Value.ToString());
                cb_docteur.Text = dg_test.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {


            }
          
        }
        private void dg_test_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_nom.Text = dg_test.CurrentRow.Cells[0].Value.ToString();
                txt_prix.Value = Decimal.Parse(dg_test.CurrentRow.Cells[1].Value.ToString());
                
                //cbdocteur doesnt return the selectedvalue !
                cb_docteur.SelectedValue = entities.Doctor.FirstOrDefault().Nom_Doc;

            }
            catch 
            {

                
            }

        }

        private void bt_aj_test_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifierChamps())
                {

                    string nom = txt_nom.Text;
                    int prix = int.Parse(txt_prix.Value.ToString());
                    int docteur = int.Parse(cb_docteur.SelectedValue.ToString());

                    // on verifie si le docteur a saisie déja le meme test??!!
                    var check_test = entities.Test.Any(t => t.Nom_test == nom && t.Doctor.Id_Doc == docteur);
                    if (!check_test)
                    {
                        entities.AjouterTest(nom, prix, docteur);
                        MessageBox.Show("Bien ajouté !");


                        RefreshData();
                        ViderChamps();
                        RefreshTotal();
                    }
                    else
                    {
                        MessageBox.Show("déja ajouté !");

                    }


                }
                else
                {
                    MessageBox.Show("Remplir les champs !");
                }
        }
            catch (SqlException sqlex)
            {

                MessageBox.Show($"SqlExecption : {sqlex}");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Execption : {ex}");
            }

        }

        private void bt_mo_test_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifierChamps())
                {

                    if (MessageBox.Show(" Voulez vous vraiment modifier ce test ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string nom = txt_nom.Text;
                        int prix = int.Parse(txt_prix.Value.ToString());
                        int docteur = int.Parse(cb_docteur.SelectedValue.ToString());

                        entities.ModifierTest(nom, prix, docteur);
                        MessageBox.Show(" Bien modifié !");
                        RefreshData();
                        ViderChamps();
                      

                    }
                    else
                    {
                        MessageBox.Show(" modification annulé!");
                        ViderChamps();
                    }

                      
                }
                else
                {
                    MessageBox.Show("Remplir les champs !");
                }

            }
            catch (SqlException sqlex)
            {

                MessageBox.Show($"SqlExecption : {sqlex}");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Execption : {ex}");
            }
        }

        private void bt_su_test_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_docteur.SelectedIndex !=-1)
                {
                    if (MessageBox.Show(" Voulez vous vraiment supprimer ce test ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        int docteur = int.Parse(cb_docteur.SelectedValue.ToString());
                        string nom = txt_nom.Text.ToString();

                        entities.SupprimerTest(docteur,nom);
                        MessageBox.Show("Bien supprimé !");
                        RefreshData();
                        ViderChamps();
                        RefreshTotal();

                    }
                    else
                    {
                        MessageBox.Show(" suppression annulé!");
                        ViderChamps();
                    }
                }
                else
                {
                    MessageBox.Show("Choisir un doctor !");
                }

            }
            catch (SqlException sqlex)
            {

                MessageBox.Show($"SqlExecption : {sqlex}");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Execption : {ex}");
            }
        }

        private void bt_an_test_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string test = txt_recherche.Text;
                if (test!="")
                {
               

                    dg_test.DataSource= entities.RechercherNomTest(test);
                    RefreshTotal();
                }
                else
                {
                    RefreshData();
                    RefreshTotal();
                }

            }
            catch (SqlException sqlex)
            {

                MessageBox.Show($"SqlExecption : {sqlex}");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Execption : {ex}");
            }
        }

       

        private void dg_test_SelectionChanged(object sender, EventArgs e)
        {
            //txt_nom.Text = dg_test.SelectedRows(0).ce
            //txt_prix.Value = Decimal.Parse(dg_test.CurrentRow.Cells[1].Value.ToString());
            //cb_docteur.Text = dg_test.CurrentRow.Cells[2].Value.ToString();
        }

        private void dg_test_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = this.dg_test.Rows[e.RowIndex];
            //txt_nom.Text = row.Cells[0].Value.ToString();
            //txt_prix.Value = Decimal.Parse(row.Cells[1].Value.ToString());
            //cb_docteur.Text = row.Cells[2].Value.ToString();
        }

        private void txt_rechercher_docteur_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string docteur =  txt_rechercher_docteur.Text;
                if (docteur != "")
                {
                   dg_test.DataSource= entities.RechercherTestDocNom(docteur);

                    //dg_test.DataSource = entities.Test.Where(t => t.Id_Doc == txt_recherche.Text).Select(i => new
                    //{
                    //    i.Nom_test,
                    //    i.Prix_test,
                    //    i.Doctor.Nom_Doc
                    //}).ToList();

                    RefreshTotal();
                }
                else
                {
                    RefreshData();
                    RefreshTotal();
                }

            }
            catch
            {

                
            }
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt__excel_Click(object sender, EventArgs e)
        {
            if (dg_test.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dg_test.Columns.Count; i++)
                {
                    excel.Cells[1, i] = dg_test.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dg_test.Rows.Count; i++)
                {
                    for (int j = 0; j < dg_test.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dg_test.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }
        }

        private void bt__pdf_Click(object sender, EventArgs e)
        {
            if (dg_test.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(dg_test.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            // pdfTable.HorizontalAlignment = XElement.;

                            foreach (DataGridViewColumn column in dg_test.Columns)
                            {
                                PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dg_test.Rows)
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
