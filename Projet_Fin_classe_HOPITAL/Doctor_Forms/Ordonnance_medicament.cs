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
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;
namespace Projet_Fin_classe_HOPITAL.Doctor_Forms
{
    public partial class Ordonnance_medicament : Form
    {

        BackEnd.Gestion_HopitalEntities16 entities = new BackEnd.Gestion_HopitalEntities16();
        public Ordonnance_medicament()
        {
            InitializeComponent();
        }
        //Reresh data
        public void RefreshData()
        {
            dg_ord_med.DataSource = entities.Ordonnance_Medicament.Select(om => new
            {
                om.Ordonnance.Maladie,
                om.Nom_medic,
                om.Quantite,
                om.NbrJr,
                Docteur = string.Concat(om.Doctor.Nom_Doc + " " + om.Doctor.Prenom_Doc),
                ID= om.id_ord_med
                }).ToList();

        }
        //VerifierChamps
        public bool VerifierChamps()
        {
            if (txt_nb_jour.Value == 0 || txt_nom_medic.Text == string.Empty|| txt_qte.Value == 0 || cb_docteur.SelectedIndex == -1 || cb_maladie.SelectedIndex == -1)
                return false;
            return true;
        }
        //ViderChamps
        public void ViderChamps()
        {
            txt_nb_jour.Value = 0;
            txt_nom_medic.Text = "";
            txt_qte.Value = 0;
            cb_docteur.SelectedIndex = -1;
            cb_maladie.SelectedIndex = -1;

        }
        //Refresh Total Ordonnance_medicament
        public void RefreshTotal()
        {
            lb_total.Text = " Total ordonnance Medicale : " + entities.Ordonnance_Medicament.Count().ToString();

        }
        private void Ordonnance_medicament_Load(object sender, EventArgs e)
        {
            //****************************************load
            container_ord_med.Visible = false;
            bt_modifier_all.Visible = false;
            dg_ord_med.ReadOnly = true;
            cb_docteur.Enabled = true;
            bt_print.Visible = false;

            //ordonnance_medicament data
            dg_ord_med.DataSource = entities.Ordonnance_Medicament.Select(om => new
            {

                om.Ordonnance.Maladie,
                om.Nom_medic,
                om.Quantite,
                om.NbrJr,
                Docteur = string.Concat(om.Doctor.Nom_Doc + " " + om.Doctor.Prenom_Doc),
                ID= om.id_ord_med
            }).ToList();

            dg_ord_med.Columns["ID"].Visible = false;

            //remplir combo maladie
            cb_maladie.DataSource = entities.Ordonnance.ToList();
            cb_maladie.DisplayMember = "Maladie";
            cb_maladie.ValueMember = "Ord_Num";

            //remplir combo docteur
            cb_docteur.DataSource = entities.AfficherFullName_Doc();
            cb_docteur.DisplayMember = "Fullname";
            cb_docteur.ValueMember = "Id_Doc";


            //total record
            RefreshTotal();
        }

        private void bt_pop_up_ord_med_Click(object sender, EventArgs e)
        {
            //*****************************************************************************visible the pop up
            container_ord_med.Visible = true;
            bt_pop_up_ord_med.Enabled = false;
            txt_recherche_ord_med.ReadOnly = true;
            dg_ord_med.ReadOnly = true;
            //*************************************************************disabled the buttons of update,delete,update_all
            bt_modifier_all.Enabled = false;
            bt_su_or_med.Enabled = false;
            bt_mo_or_med.Enabled = false;
            ViderChamps();
            cb_docteur.Enabled = true;
            bt_print.Visible = false;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //**************************************************************************cancel the pop up modal
            container_ord_med.Visible = false;
            bt_pop_up_ord_med.Enabled = true;
            txt_recherche_ord_med.ReadOnly = false;
            //**************************************************************************enabled all buttons
            dg_ord_med.ReadOnly = false;
            bt_modifier_all.Enabled = true;
            bt_aj_or_med.Enabled = true;
            bt_mo_or_med.Enabled = true;
            bt_su_or_med.Enabled = true;
            //**************************************************************************hide update-all button
            bt_modifier_all.Visible = false;
            cb_docteur.Enabled = true;
            ViderChamps();
        }

        private void bt_modifier_all_Click(object sender, EventArgs e)
        {
            //**********************************************************************on click button upadata all
            container_ord_med.Visible = true;
            bt_pop_up_ord_med.Enabled = false;
            txt_recherche_ord_med.ReadOnly = true;
            //********************************************************************disabled and enabled the button
            dg_ord_med.ReadOnly = true;
            bt_modifier_all.Enabled = false;
            bt_aj_or_med.Enabled = false;
            bt_print.Visible = false;
        }
        int id_ord_medic;
        private void dg_ord_med_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_docteur.Enabled = false;
            bt_print.Visible = true;
            //************************************************************************show button update all on click on cell
            bt_modifier_all.Visible = true;

            //reporting 


            try
            {

                int ind = e.RowIndex;
                DataGridViewRow selectedRows = dg_ord_med.Rows[ind];
                cb_maladie.Text = selectedRows.Cells[0].Value.ToString();
                txt_nom_medic.Text = selectedRows.Cells[1].Value.ToString();
                txt_qte.Value = Convert.ToDecimal(selectedRows.Cells[2].Value.ToString());
                txt_nb_jour.Value = Convert.ToDecimal(selectedRows.Cells[3].Value.ToString());
                cb_docteur.Text = selectedRows.Cells[4].Value.ToString();

                id_ord_medic = int.Parse(selectedRows.Cells[5].Value.ToString());
            }
            catch {

            }


        }
        private void bt_aj_or_med_Click(object sender, EventArgs e)
        {
            try
                  
            {
                cb_docteur.Enabled = true;
                if (VerifierChamps())
                {
                    int qte = int.Parse(txt_qte.Value.ToString());
                    int nbrjour = int.Parse(txt_nb_jour.Value.ToString());
                    string medicament = txt_nom_medic.Text.ToString();
                    int maladie = int.Parse(cb_maladie.SelectedValue.ToString());
                    int doctor = int.Parse(cb_docteur.SelectedValue.ToString());


                    //si le meme docteur a deja ajoute le meme medicament
                    if (!entities.Ordonnance_Medicament.Any(om => om.Nom_medic == medicament && om.Doctor.Id_Doc.ToString() == doctor.ToString()))
                    {

                        entities.Ajouter_Ord_Medicament(qte, nbrjour, medicament, maladie, doctor);


                        //mise a jour
                        RefreshData();
                        ViderChamps();
                        RefreshTotal();
                        MessageBox.Show("bien ajouté");

                    }
                    else
                    {
                        MessageBox.Show("Cette ordonnance déja ajouté  ");
                    }
                }
                else
                {
                    MessageBox.Show("Remplir les champs ! ");
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

        private void bt_mo_or_med_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifierChamps())
                {
                    string qte = txt_qte.Text.ToString();
                    int nbrjour = int.Parse(txt_nb_jour.Value.ToString());
                    int maladie = int.Parse(cb_maladie.SelectedValue.ToString());
                    string medicament = txt_nom_medic.Text.ToString();
                    int doctor = int.Parse(cb_docteur.SelectedValue.ToString());

                    if (MessageBox.Show(" Voulez vous vraiment modifier cet Ordonnance?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        entities.ModifierOrd_Medicament(int.Parse(qte), nbrjour, medicament, maladie, doctor);


                        //mise a jour
                        RefreshData();
                        ViderChamps();
                        MessageBox.Show("bien modifié");
                    }
                    else
                    {

                        MessageBox.Show(" modification annulé!");
                        ViderChamps();
                    }
                       
                }
                else
                {
                    MessageBox.Show("Remplir les champs ! ");
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

        private void bt_su_or_med_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_docteur.SelectedIndex !=-1 )
                {
                    int doctor = int.Parse(cb_docteur.SelectedValue.ToString());
                    if (MessageBox.Show(" Voulez vous vraiment modifier cet Ordonnance?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        entities.SupprimerOrd_Medicament(doctor);

                        //mise a jour
                        RefreshData();
                        ViderChamps();
                        RefreshTotal();
                        MessageBox.Show("bien supprimer");
                    }
                    else
                    {
                        ViderChamps();
                        MessageBox.Show(" Suppression  annulé!");
                      
                    }
                       
                }
                else
                {
                    MessageBox.Show("Sélectionnez un docteur!");
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

        private void txt_recherche_ord_med_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_recherche_ord_med.Text != "")
                {
                    dg_ord_med.DataSource = entities.Ordonnance_Medicament.Where(om => om.Doctor.Nom_Doc == txt_recherche_ord_med.Text).Select(orm => new
                    {
                        orm.Ordonnance.Maladie,
                        orm.Nom_medic,
                        orm.Quantite,
                        orm.NbrJr,
                        Docteur = string.Concat(orm.Doctor.Nom_Doc + " " + orm.Doctor.Prenom_Doc),
                        
                    }).ToList();

                    RefreshTotal();                }
                else
                {
                    //mise a jour
                    dg_ord_med.DataSource = entities.Ordonnance_Medicament.Select(orm => new
                    {
                        orm.Ordonnance.Maladie,
                        orm.Nom_medic,
                        orm.Quantite,
                        orm.NbrJr,
                        Docteur = string.Concat(orm.Doctor.Nom_Doc + " " + orm.Doctor.Prenom_Doc),

                    }).ToList();

                    RefreshTotal();
                }
            }
            catch 
            {

                
            }
            bt_print.Visible = false;
        }

        private void bt_an_or_med_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }

        private void bt__excel_Click(object sender, EventArgs e)
        {
            if (dg_ord_med.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dg_ord_med.Columns.Count; i++)
                {
                    excel.Cells[1, i] = dg_ord_med.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dg_ord_med.Rows.Count; i++)
                {
                    for (int j = 0; j < dg_ord_med.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dg_ord_med.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }
            bt_print.Visible = false;
        }

        private void bt__pdf_Click(object sender, EventArgs e)
        {

            if (dg_ord_med.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(dg_ord_med.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            // pdfTable.HorizontalAlignment = XElement.;

                            foreach (DataGridViewColumn column in dg_ord_med.Columns)
                            {
                                PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dg_ord_med.Rows)
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
            Reporting.Doctor_Report1 report = new Reporting.Doctor_Report1();
            report.Parameters["id_ord_medic"].Value = id_ord_medic;
            report.Parameters["id_ord_medic"].Visible = false;
            report.CreateDocument();
            report.ShowPreview();
          

        }

        private void dg_ord_med_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }
    }
}
