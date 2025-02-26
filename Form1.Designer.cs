namespace PersonelApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnKaydet = new Button();
            label1 = new Label();
            panel2 = new Panel();
            lbPersoneller = new ListBox();
            label7 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            label4 = new Label();
            txtYas = new TextBox();
            txtTel = new TextBox();
            label6 = new Label();
            txtAdres = new TextBox();
            label5 = new Label();
            btnEkleGuncelle = new Button();
            btnSil = new Button();
            btnYeni = new Button();
            pbYeni = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbYeni).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 54);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.SteelBlue;
            btnKaydet.Font = new Font("Segoe UI", 14F);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(714, 4);
            btnKaydet.Margin = new Padding(4, 3, 4, 3);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(114, 45);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(96, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 46);
            label1.TabIndex = 0;
            label1.Text = "Personel Takibi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(lbPersoneller);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 54);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 376);
            panel2.TabIndex = 1;
            // 
            // lbPersoneller
            // 
            lbPersoneller.Font = new Font("Segoe UI", 12F);
            lbPersoneller.FormattingEnabled = true;
            lbPersoneller.ItemHeight = 21;
            lbPersoneller.Location = new Point(4, 43);
            lbPersoneller.Margin = new Padding(4, 3, 4, 3);
            lbPersoneller.Name = "lbPersoneller";
            lbPersoneller.Size = new Size(253, 298);
            lbPersoneller.TabIndex = 1;
            lbPersoneller.SelectedIndexChanged += lbPersoneller_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.BackColor = Color.SteelBlue;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(276, 35);
            label7.TabIndex = 0;
            label7.Text = "Personel Listesi";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(329, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 25);
            label2.TabIndex = 2;
            label2.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(451, 97);
            txtAd.Margin = new Padding(4, 3, 4, 3);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(358, 23);
            txtAd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(329, 128);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 2;
            label3.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(451, 128);
            txtSoyad.Margin = new Padding(4, 3, 4, 3);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(358, 23);
            txtSoyad.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(329, 159);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 25);
            label4.TabIndex = 2;
            label4.Text = "Yaş";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(451, 159);
            txtYas.Margin = new Padding(4, 3, 4, 3);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(116, 23);
            txtYas.TabIndex = 3;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(451, 209);
            txtTel.Margin = new Padding(4, 3, 4, 3);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(358, 23);
            txtTel.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(329, 240);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 2;
            label6.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(451, 240);
            txtAdres.Margin = new Padding(4, 3, 4, 3);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(358, 109);
            txtAdres.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(329, 209);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 2;
            label5.Text = "Telefon";
            // 
            // btnEkleGuncelle
            // 
            btnEkleGuncelle.BackColor = Color.SeaGreen;
            btnEkleGuncelle.Font = new Font("Segoe UI", 14F);
            btnEkleGuncelle.ForeColor = Color.White;
            btnEkleGuncelle.Location = new Point(598, 370);
            btnEkleGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnEkleGuncelle.Name = "btnEkleGuncelle";
            btnEkleGuncelle.Size = new Size(212, 47);
            btnEkleGuncelle.TabIndex = 4;
            btnEkleGuncelle.Text = "Ekle/Güncelle";
            btnEkleGuncelle.UseVisualStyleBackColor = false;
            btnEkleGuncelle.Click += btnEkleGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.Font = new Font("Segoe UI", 14F);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(309, 370);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(114, 47);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnYeni
            // 
            btnYeni.BackColor = Color.BurlyWood;
            btnYeni.Font = new Font("Segoe UI", 14F);
            btnYeni.ForeColor = Color.White;
            btnYeni.Location = new Point(451, 370);
            btnYeni.Margin = new Padding(4, 3, 4, 3);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(114, 47);
            btnYeni.TabIndex = 4;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // pbYeni
            // 
            pbYeni.BackColor = Color.Transparent;
            pbYeni.Image = (Image)resources.GetObject("pbYeni.Image");
            pbYeni.Location = new Point(329, 61);
            pbYeni.Margin = new Padding(4, 3, 4, 3);
            pbYeni.Name = "pbYeni";
            pbYeni.Size = new Size(50, 36);
            pbYeni.SizeMode = PictureBoxSizeMode.StretchImage;
            pbYeni.TabIndex = 5;
            pbYeni.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(843, 430);
            Controls.Add(btnYeni);
            Controls.Add(btnSil);
            Controls.Add(btnEkleGuncelle);
            Controls.Add(txtAdres);
            Controls.Add(label6);
            Controls.Add(txtTel);
            Controls.Add(label5);
            Controls.Add(txtYas);
            Controls.Add(label4);
            Controls.Add(txtSoyad);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pbYeni);
            Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel App";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbYeni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox txtAd;
        private Label label3;
        private TextBox txtSoyad;
        private Label label4;
        private TextBox txtYas;
        private TextBox txtTel;
        private Label label6;
        private TextBox txtAdres;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label7;
        private ListBox lbPersoneller;
        private Button btnEkleGuncelle;
        private Button btnSil;
        private Button btnYeni;
        private PictureBox pbYeni;
        private Button btnKaydet;
    }
}
