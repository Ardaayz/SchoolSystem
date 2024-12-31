namespace denemeodev
{
    partial class Form2
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
            dgvDersler = new DataGridView();
            btnderssec = new Button();
            lblOgrenciBilgi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            SuspendLayout();
            // 
            // dgvDersler
            // 
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.Location = new Point(24, 68);
            dgvDersler.Name = "dgvDersler";
            dgvDersler.Size = new Size(294, 275);
            dgvDersler.TabIndex = 0;
            // 
            // btnderssec
            // 
            btnderssec.Location = new Point(24, 359);
            btnderssec.Name = "btnderssec";
            btnderssec.Size = new Size(147, 40);
            btnderssec.TabIndex = 1;
            btnderssec.Text = "dersleri sec";
            btnderssec.UseVisualStyleBackColor = true;
            btnderssec.Click += btnderssec_Click;
            // 
            // lblOgrenciBilgi
            // 
            lblOgrenciBilgi.AutoSize = true;
            lblOgrenciBilgi.Location = new Point(24, 20);
            lblOgrenciBilgi.Name = "lblOgrenciBilgi";
            lblOgrenciBilgi.Size = new Size(38, 15);
            lblOgrenciBilgi.TabIndex = 2;
            lblOgrenciBilgi.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 421);
            Controls.Add(lblOgrenciBilgi);
            Controls.Add(btnderssec);
            Controls.Add(dgvDersler);
            Name = "Form2";
            Text = "A-Okul Ders Seçim";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDersler;
        private Button btnderssec;
        private Label lblOgrenciBilgi;
    }
}