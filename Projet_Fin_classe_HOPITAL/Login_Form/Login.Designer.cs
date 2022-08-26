namespace Projet_Fin_classe_HOPITAL
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.rd_docteur = new Guna.UI.WinForms.GunaRadioButton();
            this.rd_agent = new Guna.UI.WinForms.GunaRadioButton();
            this.rd_admin = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.bt_connecter = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txt_nom_uti = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_mot_pass = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(349, 65);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(439, 416);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(134)))));
            this.gunaLabel1.Location = new System.Drawing.Point(448, 39);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(262, 40);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Gestion Hôpital";
            // 
            // rd_docteur
            // 
            this.rd_docteur.BaseColor = System.Drawing.SystemColors.Control;
            this.rd_docteur.CheckedOffColor = System.Drawing.Color.Gray;
            this.rd_docteur.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rd_docteur.FillColor = System.Drawing.Color.White;
            this.rd_docteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_docteur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rd_docteur.Location = new System.Drawing.Point(36, 332);
            this.rd_docteur.Name = "rd_docteur";
            this.rd_docteur.Size = new System.Drawing.Size(79, 20);
            this.rd_docteur.TabIndex = 19;
            this.rd_docteur.Text = "Docteur";
            // 
            // rd_agent
            // 
            this.rd_agent.BaseColor = System.Drawing.SystemColors.Control;
            this.rd_agent.CheckedOffColor = System.Drawing.Color.Gray;
            this.rd_agent.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rd_agent.FillColor = System.Drawing.Color.White;
            this.rd_agent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_agent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rd_agent.Location = new System.Drawing.Point(38, 358);
            this.rd_agent.Name = "rd_agent";
            this.rd_agent.Size = new System.Drawing.Size(66, 20);
            this.rd_agent.TabIndex = 18;
            this.rd_agent.Text = "Agent";
            // 
            // rd_admin
            // 
            this.rd_admin.BaseColor = System.Drawing.SystemColors.Control;
            this.rd_admin.CheckedOffColor = System.Drawing.Color.Gray;
            this.rd_admin.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rd_admin.FillColor = System.Drawing.Color.White;
            this.rd_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rd_admin.Location = new System.Drawing.Point(36, 306);
            this.rd_admin.Name = "rd_admin";
            this.rd_admin.Size = new System.Drawing.Size(119, 20);
            this.rd_admin.TabIndex = 17;
            this.rd_admin.Text = "Administrateur";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel4.Location = new System.Drawing.Point(32, 275);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(130, 21);
            this.gunaLabel4.TabIndex = 16;
            this.gunaLabel4.Text = "Fonctionnalité :";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel3.Location = new System.Drawing.Point(32, 200);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(123, 21);
            this.gunaLabel3.TabIndex = 15;
            this.gunaLabel3.Text = "Mot de passe :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel2.Location = new System.Drawing.Point(32, 128);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(148, 21);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "Nom d\'utilisateur :";
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(116, 9);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(88, 88);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 11;
            this.gunaPictureBox2.TabStop = false;
            // 
            // bt_connecter
            // 
            this.bt_connecter.AnimationHoverSpeed = 0.07F;
            this.bt_connecter.AnimationSpeed = 0.03F;
            this.bt_connecter.BackColor = System.Drawing.Color.Transparent;
            this.bt_connecter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(102)))));
            this.bt_connecter.BorderColor = System.Drawing.Color.Black;
            this.bt_connecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_connecter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_connecter.FocusedColor = System.Drawing.Color.Empty;
            this.bt_connecter.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.bt_connecter.ForeColor = System.Drawing.Color.White;
            this.bt_connecter.Image = null;
            this.bt_connecter.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_connecter.Location = new System.Drawing.Point(82, 403);
            this.bt_connecter.Name = "bt_connecter";
            this.bt_connecter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(194)))), ((int)(((byte)(119)))));
            this.bt_connecter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_connecter.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_connecter.OnHoverImage = null;
            this.bt_connecter.OnPressedColor = System.Drawing.Color.Black;
            this.bt_connecter.Radius = 5;
            this.bt_connecter.Size = new System.Drawing.Size(160, 35);
            this.bt_connecter.TabIndex = 20;
            this.bt_connecter.Text = "Connecter";
            this.bt_connecter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_connecter.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Lime;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(324, -11);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(10, 493);
            this.gunaElipsePanel1.TabIndex = 22;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Maroon;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(767, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 26);
            this.guna2ControlBox1.TabIndex = 25;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.Maroon;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(734, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(33, 26);
            this.guna2ControlBox2.TabIndex = 26;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // txt_nom_uti
            // 
            this.txt_nom_uti.BorderColor = System.Drawing.Color.Gray;
            this.txt_nom_uti.BorderRadius = 5;
            this.txt_nom_uti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nom_uti.DefaultText = "";
            this.txt_nom_uti.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nom_uti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nom_uti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nom_uti.DisabledState.Parent = this.txt_nom_uti;
            this.txt_nom_uti.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nom_uti.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nom_uti.FocusedState.Parent = this.txt_nom_uti;
            this.txt_nom_uti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nom_uti.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nom_uti.HoverState.Parent = this.txt_nom_uti;
            this.txt_nom_uti.Location = new System.Drawing.Point(36, 153);
            this.txt_nom_uti.Name = "txt_nom_uti";
            this.txt_nom_uti.PasswordChar = '\0';
            this.txt_nom_uti.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txt_nom_uti.PlaceholderText = "nom d\'utullisateur";
            this.txt_nom_uti.SelectedText = "";
            this.txt_nom_uti.ShadowDecoration.Parent = this.txt_nom_uti;
            this.txt_nom_uti.Size = new System.Drawing.Size(255, 30);
            this.txt_nom_uti.TabIndex = 27;
            // 
            // txt_mot_pass
            // 
            this.txt_mot_pass.BorderColor = System.Drawing.Color.Gray;
            this.txt_mot_pass.BorderRadius = 5;
            this.txt_mot_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mot_pass.DefaultText = "";
            this.txt_mot_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mot_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mot_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mot_pass.DisabledState.Parent = this.txt_mot_pass;
            this.txt_mot_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mot_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mot_pass.FocusedState.Parent = this.txt_mot_pass;
            this.txt_mot_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mot_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mot_pass.HoverState.Parent = this.txt_mot_pass;
            this.txt_mot_pass.IconRight = ((System.Drawing.Image)(resources.GetObject("txt_mot_pass.IconRight")));
            this.txt_mot_pass.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txt_mot_pass.Location = new System.Drawing.Point(36, 224);
            this.txt_mot_pass.Name = "txt_mot_pass";
            this.txt_mot_pass.PasswordChar = '\0';
            this.txt_mot_pass.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txt_mot_pass.PlaceholderText = "mot de passe";
            this.txt_mot_pass.SelectedText = "";
            this.txt_mot_pass.ShadowDecoration.Parent = this.txt_mot_pass;
            this.txt_mot_pass.Size = new System.Drawing.Size(255, 30);
            this.txt_mot_pass.TabIndex = 28;
            this.txt_mot_pass.UseSystemPasswordChar = true;
            this.txt_mot_pass.TextChanged += new System.EventHandler(this.txt_mot_pass_TextChanged);
            this.txt_mot_pass.IconRightClick += new System.EventHandler(this.txt_mot_pass_IconRightClick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_mot_pass);
            this.Controls.Add(this.txt_nom_uti);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.bt_connecter);
            this.Controls.Add(this.rd_docteur);
            this.Controls.Add(this.rd_agent);
            this.Controls.Add(this.rd_admin);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_form";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaRadioButton rd_docteur;
        private Guna.UI.WinForms.GunaRadioButton rd_agent;
        private Guna.UI.WinForms.GunaRadioButton rd_admin;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaButton bt_connecter;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_mot_pass;
        private Guna.UI2.WinForms.Guna2TextBox txt_nom_uti;
    }
}

