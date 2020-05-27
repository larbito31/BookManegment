namespace BookManegment
{
    partial class FRM_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADD));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_cat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_author = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cover = new System.Windows.Forms.PictureBox();
            this.txt_rate = new Bunifu.Framework.UI.BunifuRating();
            this.txt_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cover)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 53);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(47, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnadd);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 51);
            this.panel2.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.ActiveBorderThickness = 1;
            this.btnadd.ActiveCornerRadius = 20;
            this.btnadd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnadd.ActiveForecolor = System.Drawing.Color.White;
            this.btnadd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnadd.BackColor = System.Drawing.Color.White;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.ButtonText = "Add";
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnadd, BunifuAnimatorNS.DecorationType.None);
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnadd.IdleBorderThickness = 1;
            this.btnadd.IdleCornerRadius = 20;
            this.btnadd.IdleFillColor = System.Drawing.Color.White;
            this.btnadd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnadd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Location = new System.Drawing.Point(186, -1);
            this.btnadd.Margin = new System.Windows.Forms.Padding(5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(385, 51);
            this.btnadd.TabIndex = 4;
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadd.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 400);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt_cat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_price);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_author);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Location = new System.Drawing.Point(12, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(336, 382);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic information";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(183, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 57);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_cat
            // 
            this.bunifuTransition1.SetDecoration(this.txt_cat, BunifuAnimatorNS.DecorationType.None);
            this.txt_cat.FormattingEnabled = true;
            this.txt_cat.Location = new System.Drawing.Point(0, 319);
            this.txt_cat.Name = "txt_cat";
            this.txt_cat.Size = new System.Drawing.Size(152, 31);
            this.txt_cat.TabIndex = 7;
            this.txt_cat.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(6, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type";
            // 
            // txt_price
            // 
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_price, BunifuAnimatorNS.DecorationType.None);
            this.txt_price.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_price.HintForeColor = System.Drawing.Color.Empty;
            this.txt_price.HintText = "";
            this.txt_price.isPassword = false;
            this.txt_price.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_price.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_price.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_price.LineThickness = 6;
            this.txt_price.Location = new System.Drawing.Point(0, 234);
            this.txt_price.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(336, 32);
            this.txt_price.TabIndex = 5;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(6, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // txt_author
            // 
            this.txt_author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_author, BunifuAnimatorNS.DecorationType.None);
            this.txt_author.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_author.HintForeColor = System.Drawing.Color.Empty;
            this.txt_author.HintText = "";
            this.txt_author.isPassword = false;
            this.txt_author.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_author.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_author.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_author.LineThickness = 6;
            this.txt_author.Location = new System.Drawing.Point(0, 155);
            this.txt_author.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(336, 32);
            this.txt_author.TabIndex = 3;
            this.txt_author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(6, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_name, BunifuAnimatorNS.DecorationType.None);
            this.txt_name.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_name.HintText = "";
            this.txt_name.isPassword = false;
            this.txt_name.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_name.LineThickness = 6;
            this.txt_name.Location = new System.Drawing.Point(0, 70);
            this.txt_name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(336, 32);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.cover);
            this.groupBox1.Controls.Add(this.txt_rate);
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(430, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.linkLabel1, BunifuAnimatorNS.DecorationType.None);
            this.linkLabel1.Location = new System.Drawing.Point(99, 356);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 23);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Load Image";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cover
            // 
            this.bunifuTransition1.SetDecoration(this.cover, BunifuAnimatorNS.DecorationType.None);
            this.cover.Image = ((System.Drawing.Image)(resources.GetObject("cover.Image")));
            this.cover.Location = new System.Drawing.Point(94, 237);
            this.cover.Name = "cover";
            this.cover.Size = new System.Drawing.Size(115, 116);
            this.cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cover.TabIndex = 6;
            this.cover.TabStop = false;
            this.cover.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_rate
            // 
            this.txt_rate.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.txt_rate, BunifuAnimatorNS.DecorationType.None);
            this.txt_rate.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rate.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_rate.Location = new System.Drawing.Point(8, 158);
            this.txt_rate.Margin = new System.Windows.Forms.Padding(5);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(249, 46);
            this.txt_rate.TabIndex = 5;
            this.txt_rate.Value = 0;
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.SeaGreen;
            this.txt_date.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.txt_date, BunifuAnimatorNS.DecorationType.None);
            this.txt_date.ForeColor = System.Drawing.Color.White;
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_date.FormatCustom = null;
            this.txt_date.Location = new System.Drawing.Point(2, 73);
            this.txt_date.Margin = new System.Windows.Forms.Padding(5);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(342, 35);
            this.txt_date.TabIndex = 4;
            this.txt_date.Value = new System.DateTime(2020, 5, 26, 15, 50, 7, 924);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Book cover";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // FRM_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 504);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRM_ADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADD";
            this.Activated += new System.EventHandler(this.FRM_ADD_Activated);
            this.Load += new System.EventHandler(this.FRM_ADD_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        public Bunifu.Framework.UI.BunifuThinButton2 btnadd;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_price;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_author;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_name;
        public System.Windows.Forms.PictureBox cover;
        public Bunifu.Framework.UI.BunifuRating txt_rate;
        public Bunifu.Framework.UI.BunifuDatepicker txt_date;
        public System.Windows.Forms.ComboBox txt_cat;
    }
}