namespace Projet_Fin_classe_HOPITAL.Doctor_Forms
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_recherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_total = new Guna.UI.WinForms.GunaLabel();
            this.dg_test = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bt_pop_up = new Guna.UI.WinForms.GunaButton();
            this.container = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cb_docteur = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_prix = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.bt_an_test = new Guna.UI2.WinForms.Guna2Button();
            this.bt_su_test = new Guna.UI2.WinForms.Guna2Button();
            this.bt_mo_test = new Guna.UI2.WinForms.Guna2Button();
            this.bt_aj_test = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_nom = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bt_modifier_all = new Guna.UI.WinForms.GunaButton();
            this.txt_rechercher_docteur = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt__pdf = new Guna.UI2.WinForms.Guna2Button();
            this.bt__excel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_test)).BeginInit();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_prix)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_recherche
            // 
            this.txt_recherche.BorderColor = System.Drawing.Color.Gray;
            this.txt_recherche.BorderRadius = 5;
            this.txt_recherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_recherche.DefaultText = "";
            this.txt_recherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_recherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_recherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche.DisabledState.Parent = this.txt_recherche;
            this.txt_recherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche.FocusedState.Parent = this.txt_recherche;
            this.txt_recherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_recherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche.HoverState.Parent = this.txt_recherche;
            this.txt_recherche.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_recherche.IconLeft")));
            this.txt_recherche.Location = new System.Drawing.Point(12, 5);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.PasswordChar = '\0';
            this.txt_recherche.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txt_recherche.PlaceholderText = "Rechercher par nom test";
            this.txt_recherche.SelectedText = "";
            this.txt_recherche.ShadowDecoration.Parent = this.txt_recherche;
            this.txt_recherche.Size = new System.Drawing.Size(279, 36);
            this.txt_recherche.TabIndex = 117;
            this.txt_recherche.TextChanged += new System.EventHandler(this.txt_recherche_TextChanged);
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lb_total.Location = new System.Drawing.Point(718, 26);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(78, 15);
            this.lb_total.TabIndex = 115;
            this.lb_total.Text = "[ Total Tests] ";
            // 
            // dg_test
            // 
            this.dg_test.AllowUserToAddRows = false;
            this.dg_test.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dg_test.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_test.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_test.BackgroundColor = System.Drawing.Color.White;
            this.dg_test.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_test.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_test.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_test.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_test.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_test.DefaultCellStyle = dataGridViewCellStyle6;
            this.dg_test.EnableHeadersVisualStyles = false;
            this.dg_test.GridColor = System.Drawing.Color.Gray;
            this.dg_test.Location = new System.Drawing.Point(12, 62);
            this.dg_test.Name = "dg_test";
            this.dg_test.ReadOnly = true;
            this.dg_test.RowHeadersVisible = false;
            this.dg_test.RowTemplate.Height = 30;
            this.dg_test.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_test.Size = new System.Drawing.Size(804, 501);
            this.dg_test.TabIndex = 118;
            this.dg_test.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dg_test.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_test.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_test.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dg_test.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dg_test.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dg_test.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dg_test.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dg_test.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dg_test.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_test.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_test.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(86)))));
            this.dg_test.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_test.ThemeStyle.HeaderStyle.Height = 35;
            this.dg_test.ThemeStyle.ReadOnly = true;
            this.dg_test.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_test.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_test.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_test.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dg_test.ThemeStyle.RowsStyle.Height = 30;
            this.dg_test.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dg_test.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dg_test.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_test_CellClick);
            this.dg_test.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_test_CellContentClick);
            this.dg_test.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_test_CellEnter);
            this.dg_test.SelectionChanged += new System.EventHandler(this.dg_test_SelectionChanged);
            // 
            // bt_pop_up
            // 
            this.bt_pop_up.AnimationHoverSpeed = 0.07F;
            this.bt_pop_up.AnimationSpeed = 0.03F;
            this.bt_pop_up.BackColor = System.Drawing.Color.Transparent;
            this.bt_pop_up.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(86)))));
            this.bt_pop_up.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(86)))));
            this.bt_pop_up.BorderSize = 1;
            this.bt_pop_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pop_up.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_pop_up.FocusedColor = System.Drawing.Color.Empty;
            this.bt_pop_up.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_pop_up.ForeColor = System.Drawing.Color.White;
            this.bt_pop_up.Image = ((System.Drawing.Image)(resources.GetObject("bt_pop_up.Image")));
            this.bt_pop_up.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_pop_up.Location = new System.Drawing.Point(638, 569);
            this.bt_pop_up.Name = "bt_pop_up";
            this.bt_pop_up.OnHoverBaseColor = System.Drawing.Color.White;
            this.bt_pop_up.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(86)))));
            this.bt_pop_up.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(86)))));
            this.bt_pop_up.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("bt_pop_up.OnHoverImage")));
            this.bt_pop_up.OnPressedColor = System.Drawing.Color.Black;
            this.bt_pop_up.Radius = 5;
            this.bt_pop_up.Size = new System.Drawing.Size(178, 42);
            this.bt_pop_up.TabIndex = 119;
            this.bt_pop_up.Text = "Ajouter un nouveau test";
            this.bt_pop_up.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.White;
            this.container.Controls.Add(this.cb_docteur);
            this.container.Controls.Add(this.txt_prix);
            this.container.Controls.Add(this.gunaButton1);
            this.container.Controls.Add(this.bt_an_test);
            this.container.Controls.Add(this.bt_su_test);
            this.container.Controls.Add(this.bt_mo_test);
            this.container.Controls.Add(this.bt_aj_test);
            this.container.Controls.Add(this.gunaLabel3);
            this.container.Controls.Add(this.gunaLabel2);
            this.container.Controls.Add(this.txt_nom);
            this.container.Controls.Add(this.gunaLabel1);
            this.container.FillColor = System.Drawing.Color.White;
            this.container.Location = new System.Drawing.Point(34, 205);
            this.container.Name = "container";
            this.container.ShadowColor = System.Drawing.Color.Black;
            this.container.ShadowDepth = 40;
            this.container.ShadowShift = 10;
            this.container.Size = new System.Drawing.Size(753, 258);
            this.container.TabIndex = 125;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // cb_docteur
            // 
            this.cb_docteur.BackColor = System.Drawing.Color.Transparent;
            this.cb_docteur.BorderColor = System.Drawing.Color.Silver;
            this.cb_docteur.BorderRadius = 5;
            this.cb_docteur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_docteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_docteur.FocusedColor = System.Drawing.Color.Empty;
            this.cb_docteur.FocusedState.Parent = this.cb_docteur;
            this.cb_docteur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_docteur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_docteur.FormattingEnabled = true;
            this.cb_docteur.HoverState.Parent = this.cb_docteur;
            this.cb_docteur.ItemHeight = 30;
            this.cb_docteur.ItemsAppearance.Parent = this.cb_docteur;
            this.cb_docteur.Location = new System.Drawing.Point(143, 181);
            this.cb_docteur.Name = "cb_docteur";
            this.cb_docteur.ShadowDecoration.Parent = this.cb_docteur;
            this.cb_docteur.Size = new System.Drawing.Size(368, 36);
            this.cb_docteur.TabIndex = 22;
            // 
            // txt_prix
            // 
            this.txt_prix.BackColor = System.Drawing.Color.Transparent;
            this.txt_prix.BorderColor = System.Drawing.Color.Silver;
            this.txt_prix.BorderRadius = 5;
            this.txt_prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prix.DisabledState.Parent = this.txt_prix;
            this.txt_prix.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txt_prix.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txt_prix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prix.FocusedState.Parent = this.txt_prix;
            this.txt_prix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_prix.Location = new System.Drawing.Point(143, 124);
            this.txt_prix.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_prix.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.ShadowDecoration.Parent = this.txt_prix;
            this.txt_prix.Size = new System.Drawing.Size(368, 36);
            this.txt_prix.TabIndex = 21;
            this.txt_prix.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(703, 10);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.White;
            this.gunaButton1.Size = new System.Drawing.Size(40, 40);
            this.gunaButton1.TabIndex = 20;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click_1);
            // 
            // bt_an_test
            // 
            this.bt_an_test.BorderRadius = 5;
            this.bt_an_test.CheckedState.Parent = this.bt_an_test;
            this.bt_an_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_an_test.CustomImages.Parent = this.bt_an_test;
            this.bt_an_test.FillColor = System.Drawing.Color.Gold;
            this.bt_an_test.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_an_test.ForeColor = System.Drawing.Color.White;
            this.bt_an_test.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.bt_an_test.HoverState.ForeColor = System.Drawing.Color.Black;
            this.bt_an_test.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("bt_an_test.HoverState.Image")));
            this.bt_an_test.HoverState.Parent = this.bt_an_test;
            this.bt_an_test.Image = ((System.Drawing.Image)(resources.GetObject("bt_an_test.Image")));
            this.bt_an_test.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_an_test.ImageOffset = new System.Drawing.Point(4, 0);
            this.bt_an_test.Location = new System.Drawing.Point(542, 188);
            this.bt_an_test.Name = "bt_an_test";
            this.bt_an_test.ShadowDecoration.Parent = this.bt_an_test;
            this.bt_an_test.Size = new System.Drawing.Size(142, 40);
            this.bt_an_test.TabIndex = 19;
            this.bt_an_test.Text = "Annuler";
            this.bt_an_test.TextOffset = new System.Drawing.Point(16, 0);
            this.bt_an_test.Click += new System.EventHandler(this.bt_an_test_Click);
            // 
            // bt_su_test
            // 
            this.bt_su_test.BorderRadius = 5;
            this.bt_su_test.CheckedState.Parent = this.bt_su_test;
            this.bt_su_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_su_test.CustomImages.Parent = this.bt_su_test;
            this.bt_su_test.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_su_test.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_su_test.ForeColor = System.Drawing.Color.White;
            this.bt_su_test.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.bt_su_test.HoverState.ForeColor = System.Drawing.Color.Black;
            this.bt_su_test.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("bt_su_test.HoverState.Image")));
            this.bt_su_test.HoverState.Parent = this.bt_su_test;
            this.bt_su_test.Image = ((System.Drawing.Image)(resources.GetObject("bt_su_test.Image")));
            this.bt_su_test.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_su_test.ImageSize = new System.Drawing.Size(25, 25);
            this.bt_su_test.Location = new System.Drawing.Point(542, 142);
            this.bt_su_test.Name = "bt_su_test";
            this.bt_su_test.ShadowDecoration.Parent = this.bt_su_test;
            this.bt_su_test.Size = new System.Drawing.Size(142, 40);
            this.bt_su_test.TabIndex = 18;
            this.bt_su_test.Text = "Supprimer";
            this.bt_su_test.TextOffset = new System.Drawing.Point(16, 0);
            this.bt_su_test.Click += new System.EventHandler(this.bt_su_test_Click);
            // 
            // bt_mo_test
            // 
            this.bt_mo_test.BorderRadius = 5;
            this.bt_mo_test.CheckedState.Parent = this.bt_mo_test;
            this.bt_mo_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mo_test.CustomImages.Parent = this.bt_mo_test;
            this.bt_mo_test.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_mo_test.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mo_test.ForeColor = System.Drawing.Color.White;
            this.bt_mo_test.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.bt_mo_test.HoverState.ForeColor = System.Drawing.Color.Black;
            this.bt_mo_test.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("bt_mo_test.HoverState.Image")));
            this.bt_mo_test.HoverState.Parent = this.bt_mo_test;
            this.bt_mo_test.Image = ((System.Drawing.Image)(resources.GetObject("bt_mo_test.Image")));
            this.bt_mo_test.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_mo_test.ImageSize = new System.Drawing.Size(25, 25);
            this.bt_mo_test.Location = new System.Drawing.Point(542, 96);
            this.bt_mo_test.Name = "bt_mo_test";
            this.bt_mo_test.ShadowDecoration.Parent = this.bt_mo_test;
            this.bt_mo_test.Size = new System.Drawing.Size(142, 40);
            this.bt_mo_test.TabIndex = 17;
            this.bt_mo_test.Text = "Modifier";
            this.bt_mo_test.TextOffset = new System.Drawing.Point(15, 0);
            this.bt_mo_test.Click += new System.EventHandler(this.bt_mo_test_Click);
            // 
            // bt_aj_test
            // 
            this.bt_aj_test.BorderRadius = 5;
            this.bt_aj_test.CheckedState.Parent = this.bt_aj_test;
            this.bt_aj_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_aj_test.CustomImages.Parent = this.bt_aj_test;
            this.bt_aj_test.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(86)))));
            this.bt_aj_test.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_aj_test.ForeColor = System.Drawing.Color.White;
            this.bt_aj_test.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.bt_aj_test.HoverState.ForeColor = System.Drawing.Color.Black;
            this.bt_aj_test.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("bt_aj_test.HoverState.Image")));
            this.bt_aj_test.HoverState.Parent = this.bt_aj_test;
            this.bt_aj_test.Image = ((System.Drawing.Image)(resources.GetObject("bt_aj_test.Image")));
            this.bt_aj_test.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_aj_test.ImageSize = new System.Drawing.Size(25, 25);
            this.bt_aj_test.Location = new System.Drawing.Point(542, 48);
            this.bt_aj_test.Name = "bt_aj_test";
            this.bt_aj_test.ShadowDecoration.Parent = this.bt_aj_test;
            this.bt_aj_test.Size = new System.Drawing.Size(142, 40);
            this.bt_aj_test.TabIndex = 16;
            this.bt_aj_test.Text = "Ajouter";
            this.bt_aj_test.TextOffset = new System.Drawing.Point(15, 0);
            this.bt_aj_test.Click += new System.EventHandler(this.bt_aj_test_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(53, 191);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(68, 17);
            this.gunaLabel3.TabIndex = 14;
            this.gunaLabel3.Text = "Docteur :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(53, 134);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(37, 17);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "Prix :";
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.Color.Transparent;
            this.txt_nom.BaseColor = System.Drawing.Color.White;
            this.txt_nom.BorderColor = System.Drawing.Color.Silver;
            this.txt_nom.BorderSize = 1;
            this.txt_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nom.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_nom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_nom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_nom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nom.Location = new System.Drawing.Point(143, 67);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PasswordChar = '\0';
            this.txt_nom.Radius = 5;
            this.txt_nom.SelectedText = "";
            this.txt_nom.Size = new System.Drawing.Size(368, 36);
            this.txt_nom.TabIndex = 11;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(53, 78);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(48, 17);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Nom :";
            // 
            // bt_modifier_all
            // 
            this.bt_modifier_all.AnimationHoverSpeed = 0.07F;
            this.bt_modifier_all.AnimationSpeed = 0.03F;
            this.bt_modifier_all.BackColor = System.Drawing.Color.Transparent;
            this.bt_modifier_all.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.bt_modifier_all.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.bt_modifier_all.BorderSize = 1;
            this.bt_modifier_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_modifier_all.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_modifier_all.FocusedColor = System.Drawing.Color.Empty;
            this.bt_modifier_all.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_modifier_all.ForeColor = System.Drawing.Color.Black;
            this.bt_modifier_all.Image = ((System.Drawing.Image)(resources.GetObject("bt_modifier_all.Image")));
            this.bt_modifier_all.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_modifier_all.Location = new System.Drawing.Point(513, 569);
            this.bt_modifier_all.Name = "bt_modifier_all";
            this.bt_modifier_all.OnHoverBaseColor = System.Drawing.Color.White;
            this.bt_modifier_all.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.bt_modifier_all.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.bt_modifier_all.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("bt_modifier_all.OnHoverImage")));
            this.bt_modifier_all.OnPressedColor = System.Drawing.Color.Black;
            this.bt_modifier_all.Radius = 5;
            this.bt_modifier_all.Size = new System.Drawing.Size(119, 42);
            this.bt_modifier_all.TabIndex = 157;
            this.bt_modifier_all.Text = "Modifier test";
            this.bt_modifier_all.Click += new System.EventHandler(this.bt_modifier_all_Click);
            // 
            // txt_rechercher_docteur
            // 
            this.txt_rechercher_docteur.BorderColor = System.Drawing.Color.Gray;
            this.txt_rechercher_docteur.BorderRadius = 5;
            this.txt_rechercher_docteur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_rechercher_docteur.DefaultText = "";
            this.txt_rechercher_docteur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_rechercher_docteur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_rechercher_docteur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_rechercher_docteur.DisabledState.Parent = this.txt_rechercher_docteur;
            this.txt_rechercher_docteur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_rechercher_docteur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rechercher_docteur.FocusedState.Parent = this.txt_rechercher_docteur;
            this.txt_rechercher_docteur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_rechercher_docteur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rechercher_docteur.HoverState.Parent = this.txt_rechercher_docteur;
            this.txt_rechercher_docteur.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_rechercher_docteur.IconLeft")));
            this.txt_rechercher_docteur.Location = new System.Drawing.Point(297, 4);
            this.txt_rechercher_docteur.Name = "txt_rechercher_docteur";
            this.txt_rechercher_docteur.PasswordChar = '\0';
            this.txt_rechercher_docteur.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txt_rechercher_docteur.PlaceholderText = "Rechercher par nom docteur";
            this.txt_rechercher_docteur.SelectedText = "";
            this.txt_rechercher_docteur.ShadowDecoration.Parent = this.txt_rechercher_docteur;
            this.txt_rechercher_docteur.Size = new System.Drawing.Size(279, 36);
            this.txt_rechercher_docteur.TabIndex = 158;
            this.txt_rechercher_docteur.TextChanged += new System.EventHandler(this.txt_rechercher_docteur_TextChanged);
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
            this.bt__pdf.Location = new System.Drawing.Point(158, 569);
            this.bt__pdf.Name = "bt__pdf";
            this.bt__pdf.PressedColor = System.Drawing.Color.White;
            this.bt__pdf.ShadowDecoration.Parent = this.bt__pdf;
            this.bt__pdf.Size = new System.Drawing.Size(138, 40);
            this.bt__pdf.TabIndex = 170;
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
            this.bt__excel.Location = new System.Drawing.Point(9, 569);
            this.bt__excel.Name = "bt__excel";
            this.bt__excel.PressedColor = System.Drawing.Color.White;
            this.bt__excel.ShadowDecoration.Parent = this.bt__excel;
            this.bt__excel.Size = new System.Drawing.Size(138, 40);
            this.bt__excel.TabIndex = 169;
            this.bt__excel.Text = "Exporter Excel";
            this.bt__excel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt__excel.Click += new System.EventHandler(this.bt__excel_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 616);
            this.Controls.Add(this.bt__pdf);
            this.Controls.Add(this.bt__excel);
            this.Controls.Add(this.txt_rechercher_docteur);
            this.Controls.Add(this.bt_modifier_all);
            this.Controls.Add(this.container);
            this.Controls.Add(this.bt_pop_up);
            this.Controls.Add(this.dg_test);
            this.Controls.Add(this.txt_recherche);
            this.Controls.Add(this.lb_total);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_test)).EndInit();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_prix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_recherche;
        private Guna.UI.WinForms.GunaLabel lb_total;
        private Guna.UI2.WinForms.Guna2DataGridView dg_test;
        private Guna.UI.WinForms.GunaButton bt_pop_up;
        private Guna.UI2.WinForms.Guna2ShadowPanel container;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI2.WinForms.Guna2Button bt_an_test;
        private Guna.UI2.WinForms.Guna2Button bt_su_test;
        private Guna.UI2.WinForms.Guna2Button bt_mo_test;
        private Guna.UI2.WinForms.Guna2Button bt_aj_test;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txt_nom;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_docteur;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_prix;
        private Guna.UI.WinForms.GunaButton bt_modifier_all;
        private Guna.UI2.WinForms.Guna2TextBox txt_rechercher_docteur;
        private Guna.UI2.WinForms.Guna2Button bt__pdf;
        private Guna.UI2.WinForms.Guna2Button bt__excel;
    }
}