namespace library.PL
{
    partial class FRM_ADDBOOK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDBOOK));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.cboCAT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthorName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LB_Title = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtRate = new Bunifu.Framework.UI.BunifuRating();
            this.txtDateTime = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtCover = new System.Windows.Forms.PictureBox();
            this.btnADD = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCover)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.cboCAT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAuthorName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.LB_Title);
            this.groupBox1.Location = new System.Drawing.Point(425, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات الاساسية ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(26, 334);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(65, 26);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "اضافة ";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // cboCAT
            // 
            this.cboCAT.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCAT.FormattingEnabled = true;
            this.cboCAT.Location = new System.Drawing.Point(117, 334);
            this.cboCAT.Name = "cboCAT";
            this.cboCAT.Size = new System.Drawing.Size(251, 37);
            this.cboCAT.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(276, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "سعر الكتاب";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrice.LineThickness = 5;
            this.txtPrice.Location = new System.Drawing.Point(20, 429);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(344, 60);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(306, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "الصنف";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAuthorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthorName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAuthorName.HintForeColor = System.Drawing.Color.Empty;
            this.txtAuthorName.HintText = "";
            this.txtAuthorName.isPassword = false;
            this.txtAuthorName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAuthorName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAuthorName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAuthorName.LineThickness = 5;
            this.txtAuthorName.Location = new System.Drawing.Point(20, 196);
            this.txtAuthorName.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(344, 60);
            this.txtAuthorName.TabIndex = 7;
            this.txtAuthorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(276, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم المؤلف";
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBookName.HintForeColor = System.Drawing.Color.Empty;
            this.txtBookName.HintText = "";
            this.txtBookName.isPassword = false;
            this.txtBookName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBookName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBookName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBookName.LineThickness = 5;
            this.txtBookName.Location = new System.Drawing.Point(26, 78);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(344, 60);
            this.txtBookName.TabIndex = 5;
            this.txtBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_Title
            // 
            this.LB_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_Title.AutoSize = true;
            this.LB_Title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LB_Title.Location = new System.Drawing.Point(276, 50);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(77, 23);
            this.LB_Title.TabIndex = 4;
            this.LB_Title.Text = "اسم الكتاب";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.txtCover);
            this.groupBox2.Controls.Add(this.txtRate);
            this.groupBox2.Controls.Add(this.txtDateTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(11, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 532);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المعلومات الاساسية ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(177, 500);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 26);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "تحميل الصورة ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.Transparent;
            this.txtRate.Font = new System.Drawing.Font("Arabic Typesetting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtRate.Location = new System.Drawing.Point(34, 225);
            this.txtRate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(306, 62);
            this.txtRate.TabIndex = 10;
            this.txtRate.Value = 0;
            // 
            // txtDateTime
            // 
            this.txtDateTime.BackColor = System.Drawing.Color.SeaGreen;
            this.txtDateTime.BorderRadius = 0;
            this.txtDateTime.ForeColor = System.Drawing.Color.White;
            this.txtDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtDateTime.FormatCustom = null;
            this.txtDateTime.Location = new System.Drawing.Point(10, 94);
            this.txtDateTime.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(354, 44);
            this.txtDateTime.TabIndex = 9;
            this.txtDateTime.Value = new System.DateTime(2023, 5, 19, 1, 34, 45, 579);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(267, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "غلاف الكتاب";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(276, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "تقييم الكتاب";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(268, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "تاريخ النشر ";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = global::library.Properties.Resources.delete_sign_64px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(11, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 45);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txtCover
            // 
            this.txtCover.Image = global::library.Properties.Resources.books_40px;
            this.txtCover.Location = new System.Drawing.Point(156, 351);
            this.txtCover.Name = "txtCover";
            this.txtCover.Size = new System.Drawing.Size(198, 138);
            this.txtCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtCover.TabIndex = 11;
            this.txtCover.TabStop = false;
            // 
            // btnADD
            // 
            this.btnADD.ActiveBorderThickness = 1;
            this.btnADD.ActiveCornerRadius = 20;
            this.btnADD.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnADD.ActiveForecolor = System.Drawing.Color.White;
            this.btnADD.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnADD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnADD.BackColor = System.Drawing.Color.White;
            this.btnADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnADD.BackgroundImage")));
            this.btnADD.ButtonText = "اضافة";
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnADD.IdleBorderThickness = 1;
            this.btnADD.IdleCornerRadius = 20;
            this.btnADD.IdleFillColor = System.Drawing.Color.White;
            this.btnADD.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnADD.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnADD.Location = new System.Drawing.Point(156, 596);
            this.btnADD.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(479, 67);
            this.btnADD.TabIndex = 5;
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // FRM_ADDBOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 663);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRM_ADDBOOK";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADDBOOK";
            this.Load += new System.EventHandler(this.FRM_ADDBOOK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.Framework.UI.BunifuThinButton2 btnADD;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtAuthorName;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtBookName;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        public Bunifu.Framework.UI.BunifuDatepicker txtDateTime;
        public Bunifu.Framework.UI.BunifuRating txtRate;
        public System.Windows.Forms.PictureBox txtCover;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox cboCAT;
    }
}