
namespace yazılımYapimiProje
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
            this.KullaniciAdiText = new System.Windows.Forms.TextBox();
            this.SifreText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GirisButton = new System.Windows.Forms.Button();
            this.KayitOlButton = new System.Windows.Forms.Button();
            this.comboGirisTuru = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cikisbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // KullaniciAdiText
            // 
            this.KullaniciAdiText.Location = new System.Drawing.Point(487, 88);
            this.KullaniciAdiText.Name = "KullaniciAdiText";
            this.KullaniciAdiText.Size = new System.Drawing.Size(240, 23);
            this.KullaniciAdiText.TabIndex = 0;
            // 
            // SifreText
            // 
            this.SifreText.Location = new System.Drawing.Point(487, 136);
            this.SifreText.Name = "SifreText";
            this.SifreText.Size = new System.Drawing.Size(240, 23);
            this.SifreText.TabIndex = 1;
            this.SifreText.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GirisButton
            // 
            this.GirisButton.Location = new System.Drawing.Point(652, 170);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(75, 23);
            this.GirisButton.TabIndex = 5;
            this.GirisButton.Text = "Giriş";
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // KayitOlButton
            // 
            this.KayitOlButton.Location = new System.Drawing.Point(487, 170);
            this.KayitOlButton.Name = "KayitOlButton";
            this.KayitOlButton.Size = new System.Drawing.Size(75, 23);
            this.KayitOlButton.TabIndex = 6;
            this.KayitOlButton.Text = "Kayıt Ol";
            this.KayitOlButton.UseVisualStyleBackColor = true;
            this.KayitOlButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboGirisTuru
            // 
            this.comboGirisTuru.FormattingEnabled = true;
            this.comboGirisTuru.Items.AddRange(new object[] {
            "Admin",
            "Sınav Sorumlusu",
            "Öğrenci"});
            this.comboGirisTuru.Location = new System.Drawing.Point(487, 41);
            this.comboGirisTuru.Name = "comboGirisTuru";
            this.comboGirisTuru.Size = new System.Drawing.Size(240, 23);
            this.comboGirisTuru.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giriş Türü:";
            // 
            // cikisbtn
            // 
            this.cikisbtn.Location = new System.Drawing.Point(567, 220);
            this.cikisbtn.Name = "cikisbtn";
            this.cikisbtn.Size = new System.Drawing.Size(75, 23);
            this.cikisbtn.TabIndex = 10;
            this.cikisbtn.Text = "Çıkış";
            this.cikisbtn.UseVisualStyleBackColor = true;
            this.cikisbtn.Click += new System.EventHandler(this.cikisbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(739, 255);
            this.Controls.Add(this.cikisbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboGirisTuru);
            this.Controls.Add(this.KayitOlButton);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SifreText);
            this.Controls.Add(this.KullaniciAdiText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KullaniciAdiText;
        private System.Windows.Forms.TextBox SifreText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.Button KayitOlButton;
        private System.Windows.Forms.ComboBox comboGirisTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cikisbtn;
    }
}

