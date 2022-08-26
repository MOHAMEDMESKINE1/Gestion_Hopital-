using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excl = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Projet_Fin_classe_HOPITAL.Doctor_Forms
{
    public partial class Rendez_vous : Form
    {
        BackEnd.Gestion_HopitalEntities16 entities = new BackEnd.Gestion_HopitalEntities16();

        public Rendez_vous()
        {
            InitializeComponent();
        }
        //refersh data 
        public void RefreshData()
        {
            dg_rendez_vous.DataSource = entities.Rendez_vous.Select(r => new
            {
               Date  =  r.Date_rdv,
               Heure = r.Heure_rdv,
               CIN   = r.Patient.Cin_pat,
               Nom   = string.Concat(r.Doctor.Nom_Doc +" "+r.Doctor.Prenom_Doc)

            }).ToList();
        }
        //refersh total
        public void RefreshTotal()
        {
            lb_total.Text = "Total Rendez_vous : " + entities.Rendez_vous.Count();

        }
        private void Rendez_vous_Load(object sender, EventArgs e)
        {
            dg_rendez_vous.DataSource = entities.Afficher_Rdv();
            dg_rendez_vous.ReadOnly = true;
            //refersh total
            RefreshTotal();
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            if (txt_recherche.Text != "")
            {
                dg_rendez_vous.DataSource = entities.Rendez_vous.Where(re => re.Cin_pat == txt_recherche.Text).Select(r => new
                {
                   Date  =  r.Date_rdv,
                   Heure =  r.Heure_rdv,
                   CIN   =  r.Patient.Cin_pat,
                   Nom   =  r.Doctor.Nom_Doc

                }).ToList();
                //refersh total
                RefreshTotal();
            }
            else
            {
                RefreshData();
                //refersh total
                RefreshTotal();

            }
        }

        private void txt_date_ValueChanged(object sender, EventArgs e)
        {
          
            try
            {
                DateTime date = DateTime.Parse(txt_date.Value.ToShortDateString());
                if (entities.Rendez_vous.Any(re => re.Date_rdv == date))
                {
                    dg_rendez_vous.DataSource = entities.Rendez_vous.Where(re => re.Date_rdv == date).Select(r => new
                    {
                       Date = r.Date_rdv,
                      Heure = r.Heure_rdv,
                      CIN   = r.Patient.Cin_pat,
                      Docoteur =   r.Doctor.Nom_Doc

                    }).ToList();
                    //refersh total
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

        private void bt__excel_Click(object sender, EventArgs e)
        {
            if (dg_rendez_vous.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dg_rendez_vous.Columns.Count; i++)
                {
                    excel.Cells[1, i] = dg_rendez_vous.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dg_rendez_vous.Rows.Count; i++)
                {
                    for (int j = 0; j < dg_rendez_vous.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dg_rendez_vous.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }
        }

        private void bt__pdf_Click(object sender, EventArgs e)
        {
            if (dg_rendez_vous.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(dg_rendez_vous.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            // pdfTable.HorizontalAlignment = XElement.;

                            foreach (DataGridViewColumn column in dg_rendez_vous.Columns)
                            {
                                PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dg_rendez_vous.Rows)
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
