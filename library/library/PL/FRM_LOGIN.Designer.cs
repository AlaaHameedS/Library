namespace library.PL
{
    partial class FRM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            this.txtUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LB_Title = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtPss = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnADD = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUser.HintForeColor = System.Drawing.Color.Empty;
            this.txtUser.HintText = "";
            this.txtUser.isPassword = false;
            this.txtUser.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUser.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUser.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUser.LineThickness = 10;
            this.txtUser.Location = new System.Drawing.Point(70, 163);
            this.txtUser.Margin = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(390, 94);
            this.txtUser.TabIndex = 9;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_Title
            // 
            this.LB_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Title.AutoSize = true;
            this.LB_Title.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LB_Title.Location = new System.Drawing.Point(522, 192);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(246, 57);
            this.LB_Title.TabIndex = 8;
            this.LB_Title.Text = "اسم المستخدم";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = global::library.Properties.Resources.delete_sign_64px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(2, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 45);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txtPss
            // 
            this.txtPss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPss.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPss.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPss.HintForeColor = System.Drawing.Color.Empty;
            this.txtPss.HintText = "";
            this.txtPss.isPassword = false;
            this.txtPss.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPss.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPss.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPss.LineThickness = 10;
            this.txtPss.Location = new System.Drawing.Point(79, 338);
            this.txtPss.Margin = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.txtPss.Name = "txtPss";
            this.txtPss.Size = new System.Drawing.Size(390, 94);
            this.txtPss.TabIndex = 12;
            this.txtPss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(554, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 57);
            this.label1.TabIndex = 11;
            this.label1.Text = "كلمة السر";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(249, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 76);
            this.label2.TabIndex = 13;
            this.label2.Text = "تسجيل الدخول";
            // 
            // btnADD
            // 
            this.btnADD.ActiveBorderThickness = 1;
            this.btnADD.ActiveCornerRadius = 20;
            this.btnADD.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnADD.ActiveForecolor = System.Drawing.Color.White;
            this.btnADD.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnADD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnADD.BackColor = System.Drawing.Color.White;
            this.btnADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnADD.BackgroundImage")));
            this.btnADD.ButtonText = "تسجيل الدخول";
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnADD.IdleBorderThickness = 1;
            this.btnADD.IdleCornerRadius = 20;
            this.btnADD.IdleFillColor = System.Drawing.Color.White;
            this.btnADD.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnADD.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnADD.Location = new System.Drawing.Point(198, 545);
            this.btnADD.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(443, 78);
            this.btnADD.TabIndex = 14;
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // FRM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 643);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.bunifuImageButton1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FRM_LOGIN";
            this.Text = "FRM_LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuMaterialTextbox txtUser;
        private System.Windows.Forms.Label LB_Title;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuThinButton2 btnADD;
    }
}