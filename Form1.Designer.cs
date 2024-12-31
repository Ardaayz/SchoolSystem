namespace denemeodev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tboxsoyad = new TextBox();
            tboxad = new TextBox();
            tboxNo = new TextBox();
            cboxsinif = new ComboBox();
            lblNo = new Label();
            lblsınıf = new Label();
            lblsoyad = new Label();
            lblad = new Label();
            btnkaydet = new Button();
            btnguncelle = new Button();
            btnbul = new Button();
            btnderssec = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tboxsoyad);
            groupBox1.Controls.Add(tboxad);
            groupBox1.Controls.Add(tboxNo);
            groupBox1.Controls.Add(cboxsinif);
            groupBox1.Controls.Add(lblNo);
            groupBox1.Controls.Add(lblsınıf);
            groupBox1.Controls.Add(lblsoyad);
            groupBox1.Controls.Add(lblad);
            groupBox1.Location = new Point(3, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 296);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ogrenci Kaydet";
            // 
            // tboxsoyad
            // 
            tboxsoyad.Location = new Point(62, 103);
            tboxsoyad.Name = "tboxsoyad";
            tboxsoyad.Size = new Size(99, 23);
            tboxsoyad.TabIndex = 7;
            // 
            // tboxad
            // 
            tboxad.Location = new Point(62, 74);
            tboxad.Name = "tboxad";
            tboxad.Size = new Size(99, 23);
            tboxad.TabIndex = 6;
            // 
            // tboxNo
            // 
            tboxNo.Location = new Point(62, 133);
            tboxNo.Name = "tboxNo";
            tboxNo.Size = new Size(99, 23);
            tboxNo.TabIndex = 5;
            // 
            // cboxsinif
            // 
            cboxsinif.FormattingEnabled = true;
            cboxsinif.Location = new Point(62, 162);
            cboxsinif.Name = "cboxsinif";
            cboxsinif.Size = new Size(99, 23);
            cboxsinif.TabIndex = 4;
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(25, 136);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(26, 15);
            lblNo.TabIndex = 3;
            lblNo.Text = "No:";
            // 
            // lblsınıf
            // 
            lblsınıf.AutoSize = true;
            lblsınıf.Location = new Point(18, 167);
            lblsınıf.Name = "lblsınıf";
            lblsınıf.Size = new Size(33, 15);
            lblsınıf.TabIndex = 2;
            lblsınıf.Text = "Sınıf:";
            // 
            // lblsoyad
            // 
            lblsoyad.AutoSize = true;
            lblsoyad.Location = new Point(14, 106);
            lblsoyad.Name = "lblsoyad";
            lblsoyad.Size = new Size(42, 15);
            lblsoyad.TabIndex = 1;
            lblsoyad.Text = "Soyad:";
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Location = new Point(26, 77);
            lblad.Name = "lblad";
            lblad.Size = new Size(25, 15);
            lblad.TabIndex = 0;
            lblad.Text = "Ad:";
            // 
            // btnkaydet
            // 
            btnkaydet.Location = new Point(3, 319);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(90, 35);
            btnkaydet.TabIndex = 1;
            btnkaydet.Text = "kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // btnguncelle
            // 
            btnguncelle.Location = new Point(99, 319);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(90, 35);
            btnguncelle.TabIndex = 2;
            btnguncelle.Text = "Güncelle";
            btnguncelle.UseVisualStyleBackColor = true;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnbul
            // 
            btnbul.Location = new Point(195, 319);
            btnbul.Name = "btnbul";
            btnbul.Size = new Size(90, 35);
            btnbul.TabIndex = 3;
            btnbul.Text = "Bul";
            btnbul.UseVisualStyleBackColor = true;
            btnbul.Click += btnbul_Click;
            // 
            // btnderssec
            // 
            btnderssec.Location = new Point(65, 360);
            btnderssec.Name = "btnderssec";
            btnderssec.Size = new Size(165, 35);
            btnderssec.TabIndex = 4;
            btnderssec.Text = "Ders Seç";
            btnderssec.UseVisualStyleBackColor = true;
            btnderssec.Click += btnderssec_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 399);
            Controls.Add(btnderssec);
            Controls.Add(btnbul);
            Controls.Add(btnguncelle);
            Controls.Add(btnkaydet);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "A-Okul";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnkaydet;
        private Button btnguncelle;
        private Button btnbul;
        private Button btnderssec;
        private Label lblNo;
        private Label lblsınıf;
        private Label lblsoyad;
        private Label lblad;
        private ComboBox cboxsinif;
        private TextBox tboxsoyad;
        private TextBox tboxad;
        private TextBox tboxNo;
    }
}
