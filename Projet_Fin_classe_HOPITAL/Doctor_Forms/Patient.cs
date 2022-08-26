using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excl =Microsoft.Office.Interop.Excel;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Projet_Fin_classe_HOPITAL.Doctor_Forms
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        BackEnd.Gestion_HopitalEntities16 entities = new BackEnd.Gestion_HopitalEntities16();

        public void RefreshData()
        {
            dg_patient.DataSource = dg_patient.DataSource = entities.Patient.Select(p => new
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
            lb_total.Text = " Total Patient : " + entities.Patient.Count().ToString();
        }
        private void Patient_Load(object sender, EventArgs e)
        {
            dg_patient.ReadOnly = true;
            RefreshData();
        }

        private void txt_recherche_cin_TextChanged(object sender, EventArgs e)
        {
            if (txt_recherche_cin.Text != "")
            {
                dg_patient.DataSource = entities.Recherche_Patient_CIN(txt_recherche_cin.Text);
                lb_total.Text = " Total Patient : " + entities.Patient.Count().ToString();

            }
            else
            {
                RefreshData();
            }
        }

        private void txt_recherche_nom_TextChanged(object sender, EventArgs e)
        {
            if (txt_recherche_nom.Text != "")
            {
                dg_patient.DataSource = entities.Recherche_Patient_Prenom(txt_recherche_nom.Text);
                lb_total.Text = " Total Patient : " + entities.Patient.Count().ToString();

            }
            else
            {
                RefreshData();

            }
        }

        private void bt__excel_Click(object sender, EventArgs e)
        {

            if (dg_patient.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dg_patient.Columns.Count; i++)
                {
                    excel.Cells[1, i] = dg_patient.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dg_patient.Rows.Count; i++)
                {
                    for (int j = 0; j < dg_patient.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dg_patient.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }
        }

        private void bt__pdf_Click(object sender, EventArgs e)
        {
            if (dg_patient.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(dg_patient.Columns.Count);

                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            // pdfTable.HorizontalAlignment = XElement.;

                            foreach (DataGridViewColumn column in dg_patient.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dg_patient.Rows)
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

        private void lb_total_Click(object sender, EventArgs e)
        {

        }
    }
}
