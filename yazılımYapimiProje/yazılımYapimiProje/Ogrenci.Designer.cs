
namespace yazılımYapimiProje
{
    partial class Ogrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci));
            this.SoruCozButton = new System.Windows.Forms.Button();
            this.AyarlarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SonucBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SoruCozButton
            // 
            this.SoruCozButton.Location = new System.Drawing.Point(306, 12);
            this.SoruCozButton.Name = "SoruCozButton";
            this.SoruCozButton.Size = new System.Drawing.Size(166, 47);
            this.SoruCozButton.TabIndex = 0;
            this.SoruCozButton.Text = "Soru Çöz";
            this.SoruCozButton.UseVisualStyleBackColor = true;
            this.SoruCozButton.Click += new System.EventHandler(this.SoruCozButton_Click);
            // 
            // AyarlarButton
            // 
            this.AyarlarButton.Location = new System.Drawing.Point(306, 65);
            this.AyarlarButton.Name = "AyarlarButton";
            this.AyarlarButton.Size = new System.Drawing.Size(166, 47);
            this.AyarlarButton.TabIndex = 2;
            this.AyarlarButton.Text = "Ayarlar";
            this.AyarlarButton.UseVisualStyleBackColor = true;
            this.AyarlarButton.Click += new System.EventHandler(this.AyarlarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SonucBtn
            // 
            this.SonucBtn.Location = new System.Drawing.Point(306, 118);
            this.SonucBtn.Name = "SonucBtn";
            this.SonucBtn.Size = new System.Drawing.Size(166, 47);
            this.SonucBtn.TabIndex = 5;
            this.SonucBtn.Text = "Sonuçlar";
            this.SonucBtn.UseVisualStyleBackColor = true;
            this.SonucBtn.Click += new System.EventHandler(this.Sonuç_Click);
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(487, 233);
            this.Controls.Add(this.SonucBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AyarlarButton);
            this.Controls.Add(this.SoruCozButton);
            this.Name = "Ogrenci";
            this.Text = "Ogrenci";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SoruCozButton;
        private System.Windows.Forms.Button AyarlarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SonucBtn;
    }
}