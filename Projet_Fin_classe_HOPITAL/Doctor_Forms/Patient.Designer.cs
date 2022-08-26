namespace Projet_Fin_classe_HOPITAL.Doctor_Forms
{
    partial class Patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dg_patient = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_recherche_cin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_total = new Guna.UI.WinForms.GunaLabel();
            this.txt_recherche_nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt__pdf = new Guna.UI2.WinForms.Guna2Button();
            this.bt__excel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(9, 57);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(150, 17);
            this.gunaLabel2.TabIndex = 136;
            this.gunaLabel2.Text = "Rechercher par Nom :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(9, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(142, 17);
            this.gunaLabel1.TabIndex = 135;
            this.gunaLabel1.Text = "Rechercher par CIN :";
            // 
            // dg_patient
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dg_patient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_patient.BackgroundColor = System.Drawing.Color.White;
            this.dg_patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_patient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_patient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_patient.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_patient.DefaultCellStyle = dataGridViewCellStyle6;
            this.dg_patient.EnableHeadersVisualStyles = false;
            this.dg_patient.GridColor = System.Drawing.Color.Gray;
            this.dg_patient.Location = new System.Drawing.Point(14, 103);
            this.dg_patient.Name = "dg_patient";
            this.dg_patient.RowHeadersVisible = false;
            this.dg_patient.RowTemplate.Height = 30;
            this.dg_patient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_patient.Size = new System.Drawing.Size(804, 458);
            this.dg_patient.TabIndex = 134;
            this.dg_patient.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dg_patient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_patient.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_patient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dg_patient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dg_patient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dg_patient.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dg_patient.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dg_patient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dg_patient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_patient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_patient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(86)))));
            this.dg_patient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_patient.ThemeStyle.HeaderStyle.Height = 35;
            this.dg_patient.ThemeStyle.ReadOnly = false;
            this.dg_patient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_patient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_patient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_patient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dg_patient.ThemeStyle.RowsStyle.Height = 30;
            this.dg_patient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dg_patient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // txt_recherche_cin
            // 
            this.txt_recherche_cin.BorderColor = System.Drawing.Color.Gray;
            this.txt_recherche_cin.BorderRadius = 5;
            this.txt_recherche_cin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_recherche_cin.DefaultText = "";
            this.txt_recherche_cin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_recherche_cin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_recherche_cin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche_cin.DisabledState.Parent = this.txt_recherche_cin;
            this.txt_recherche_cin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche_cin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche_cin.FocusedState.Parent = this.txt_recherche_cin;
            this.txt_recherche_cin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_recherche_cin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche_cin.HoverState.Parent = this.txt_recherche_cin;
            this.txt_recherche_cin.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_recherche_cin.IconLeft")));
            this.txt_recherche_cin.Location = new System.Drawing.Point(207, 6);
            this.txt_recherche_cin.Name = "txt_recherche_cin";
            this.txt_recherche_cin.PasswordChar = '\0';
            this.txt_recherche_cin.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txt_recherche_cin.PlaceholderText = "CIN";
            this.txt_recherche_cin.SelectedText = "";
            this.txt_recherche_cin.ShadowDecoration.Parent = this.txt_recherche_cin;
            this.txt_recherche_cin.Size = new System.Drawing.Size(279, 36);
            this.txt_recherche_cin.TabIndex = 133;
            this.txt_recherche_cin.TextChanged += new System.EventHandler(this.txt_recherche_cin_TextChanged);
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lb_total.Location = new System.Drawing.Point(680, 69);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(74, 15);
            this.lb_total.TabIndex = 132;
            this.lb_total.Text = "[ Total Tests] ";
            this.lb_total.Click += new System.EventHandler(this.lb_total_Click);
            // 
            // txt_recherche_nom
            // 
            this.txt_recherche_nom.BorderColor = System.Drawing.Color.Gray;
            this.txt_recherche_nom.BorderRadius = 5;
            this.txt_recherche_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_recherche_nom.DefaultText = "";
            this.txt_recherche_nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_recherche_nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_recherche_nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche_nom.DisabledState.Parent = this.txt_recherche_nom;
            this.txt_recherche_nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche_nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche_nom.FocusedState.Parent = this.txt_recherche_nom;
            this.txt_recherche_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_recherche_nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche_nom.HoverState.Parent = this.txt_recherche_nom;
            this.txt_recherche_nom.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_recherche_nom.IconLeft")));
            this.txt_recherche_nom.Location = new System.Drawing.Point(207, 48);
            this.txt_recherche_nom.Name = "txt_recherche_nom";
            this.txt_recherche_nom.PasswordChar = '\0';
            this.txt_recherche_nom.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txt_recherche_nom.PlaceholderText = "Nom";
            this.txt_recherche_nom.SelectedText = "";
            this.txt_recherche_nom.ShadowDecoration.Parent = this.txt_recherche_nom;
            this.txt_recherche_nom.Size = new System.Drawing.Size(279, 36);
            this.txt_recherche_nom.TabIndex = 138;
            this.txt_recherche_nom.TextChanged += new System.EventHandler(this.txt_recherche_nom_TextChanged);
            // 
            // bt__pdf
            // 
            this.bt__pdf.BorderRadius = 5;
            this.bt__pdf.CheckedState.Parent = this.bt__pdf;
            this.bt__pdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt__pdf.CustomImages.Parent = this.bt__pdf;
            this.bt__pdf.FillColor = System.Drawing.Color.White;
            this.bt__pdf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt__pdf.ForeColor = System.Drawing.Color.Black;
            this.bt__pdf.HoverState.FillColor = System.Drawing.Color.White;
            this.bt__pdf.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt__pdf.HoverState.Parent = this.bt__pdf;
            this.bt__pdf.Image = ((System.Drawing.Image)(resources.GetObject("bt__pdf.Image")));
            this.bt__pdf.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt__pdf.ImageSize = new System.Drawing.Size(25, 25);
            this.bt__pdf.Location = new System.Drawing.Point(165, 567);
            this.bt__pdf.Name = "bt__pdf";
            this.bt__pdf.PressedColor = System.Drawing.Color.White;
            this.bt__pdf.ShadowDecoration.Parent = this.bt__pdf;
            this.bt__pdf.Size = new System.Drawing.Size(138, 40);
            this.bt__pdf.TabIndex = 174;
            this.bt__pdf.Text = "Exporter PDF";
            this.bt__pdf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt__pdf.Click += new System.EventHandler(this.bt__pdf_Click);
            // 
            // bt__excel
            // 
            this.bt__excel.BorderRadius = 5;
            this.bt__excel.CheckedState.Parent = this.bt__excel;
            this.bt__excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt__excel.CustomImages.Parent = this.bt__excel;
            this.bt__excel.FillColor = System.Drawing.Color.White;
            this.bt__excel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt__excel.ForeColor = System.Drawing.Color.Black;
            this.bt__excel.HoverState.FillColor = System.Drawing.Color.White;
            this.bt__excel.HoverState.ForeColor = System.Drawing.Color.Green;
            this.bt__excel.HoverState.Parent = this.bt__excel;
            this.bt__excel.Image = ((System.Drawing.Image)(resources.GetObject("bt__excel.Image")));
            this.bt__excel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt__excel.ImageSize = new System.Drawing.Size(25, 25);
            this.bt__excel.Location = new System.Drawing.Point(11, 567);
            this.bt__excel.Name = "bt__excel";
            this.bt__excel.PressedColor = System.Drawing.Color.White;
            this.bt__excel.ShadowDecoration.Parent = this.bt__excel;
            this.bt__excel.Size = new System.Drawing.Size(138, 40);
            this.bt__excel.TabIndex = 173;
            this.bt__excel.Text = "Exporter Excel";
            this.bt__excel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt__excel.Click += new System.EventHandler(this.bt__excel_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 616);
            this.Controls.Add(this.bt__pdf);
            this.Controls.Add(this.bt__excel);
            this.Controls.Add(this.txt_recherche_nom);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dg_patient);
            this.Controls.Add(this.txt_recherche_cin);
            this.Controls.Add(this.lb_total);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dg_patient;
        private Guna.UI2.WinForms.Guna2TextBox txt_recherche_cin;
        private Guna.UI.WinForms.GunaLabel lb_total;
        private Guna.UI2.WinForms.Guna2TextBox txt_recherche_nom;
        private Guna.UI2.WinForms.Guna2Button bt__pdf;
        private Guna.UI2.WinForms.Guna2Button bt__excel;
    }
}