
namespace yazılımYapimiProje
{
    partial class KayıtOlma
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
            this.label1 = new System.Windows.Forms.Label();
            this.ComboMeslekTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KayitAdText = new System.Windows.Forms.TextBox();
            this.KayitSoyadText = new System.Windows.Forms.TextBox();
            this.KayitKullaniciAdiText = new System.Windows.Forms.TextBox();
            this.KayitSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KayıtOlmaButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesleğiniz:";
            // 
            // ComboMeslekTuru
            // 
            this.ComboMeslekTuru.FormattingEnabled = true;
            this.ComboMeslekTuru.Items.AddRange(new object[] {
            "Öğrenci",
            "Sınav Sorumlusu",
            "Admin"});
            this.ComboMeslekTuru.Location = new System.Drawing.Point(104, 27);
            this.ComboMeslekTuru.Name = "ComboMeslekTuru";
            this.ComboMeslekTuru.Size = new System.Drawing.Size(157, 23);
            this.ComboMeslekTuru.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adınız:";
            // 
            // KayitAdText
            // 
            this.KayitAdText.Location = new System.Drawing.Point(104, 68);
            this.KayitAdText.Name = "KayitAdText";
            this.KayitAdText.Size = new System.Drawing.Size(157, 23);
            this.KayitAdText.TabIndex = 3;
            // 
            // KayitSoyadText
            // 
            this.KayitSoyadText.Location = new System.Drawing.Point(104, 109);
            this.KayitSoyadText.Name = "KayitSoyadText";
            this.KayitSoyadText.Size = new System.Drawing.Size(157, 23);
            this.KayitSoyadText.TabIndex = 4;
            // 
            // KayitKullaniciAdiText
            // 
            this.KayitKullaniciAdiText.Location = new System.Drawing.Point(104, 151);
            this.KayitKullaniciAdiText.Name = "KayitKullaniciAdiText";
            this.KayitKullaniciAdiText.Size = new System.Drawing.Size(157, 23);
            this.KayitKullaniciAdiText.TabIndex = 5;
            // 
            // KayitSifre
            // 
            this.KayitSifre.Location = new System.Drawing.Point(104, 195);
            this.KayitSifre.Name = "KayitSifre";
            this.KayitSifre.Size = new System.Drawing.Size(157, 23);
            this.KayitSifre.TabIndex = 6;
            this.KayitSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyadınız:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifre:";
            // 
            // KayıtOlmaButton
            // 
            this.KayıtOlmaButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.KayıtOlmaButton.Location = new System.Drawing.Point(132, 236);
            this.KayıtOlmaButton.Name = "KayıtOlmaButton";
            this.KayıtOlmaButton.Size = new System.Drawing.Size(78, 33);
            this.KayıtOlmaButton.TabIndex = 11;
            this.KayıtOlmaButton.Text = "Kayıt Ol";
            this.KayıtOlmaButton.UseVisualStyleBackColor = false;
            this.KayıtOlmaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hesabın Var mı?";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Giriş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KayıtOlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(334, 323);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KayıtOlmaButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KayitSifre);
            this.Controls.Add(this.KayitKullaniciAdiText);
            this.Controls.Add(this.KayitSoyadText);
            this.Controls.Add(this.KayitAdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboMeslekTuru);
            this.Controls.Add(this.label1);
            this.Name = "KayıtOlma";
            this.Text = "KayıtOlma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboMeslekTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KayitAdText;
        private System.Windows.Forms.TextBox KayitSoyadText;
        private System.Windows.Forms.TextBox KayitKullaniciAdiText;
        private System.Windows.Forms.TextBox KayitSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button KayıtOlmaButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}