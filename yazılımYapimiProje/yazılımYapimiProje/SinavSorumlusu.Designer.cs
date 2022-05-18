
namespace yazılımYapimiProje
{
    partial class SinavSorumlusu
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
            this.SinavSorumlusuData = new System.Windows.Forms.DataGridView();
            this.ListeleButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SoruEklemeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SinavSorumlusuData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SinavSorumlusuData
            // 
            this.SinavSorumlusuData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SinavSorumlusuData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SinavSorumlusuData.Location = new System.Drawing.Point(1, 259);
            this.SinavSorumlusuData.Name = "SinavSorumlusuData";
            this.SinavSorumlusuData.RowTemplate.Height = 25;
            this.SinavSorumlusuData.Size = new System.Drawing.Size(787, 179);
            this.SinavSorumlusuData.TabIndex = 0;
            // 
            // ListeleButton
            // 
            this.ListeleButton.Location = new System.Drawing.Point(373, 98);
            this.ListeleButton.Name = "ListeleButton";
            this.ListeleButton.Size = new System.Drawing.Size(406, 44);
            this.ListeleButton.TabIndex = 1;
            this.ListeleButton.Text = "Öğrencileri Listele";
            this.ListeleButton.UseVisualStyleBackColor = true;
            this.ListeleButton.Click += new System.EventHandler(this.ListeleButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::yazılımYapimiProje.Properties.Resources.kisspng_tamil_nadu_public_service_commission_civil_service_parents_5ac1a26fa34e50_3011734615226394716689;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SoruEklemeButton
            // 
            this.SoruEklemeButton.Location = new System.Drawing.Point(373, 12);
            this.SoruEklemeButton.Name = "SoruEklemeButton";
            this.SoruEklemeButton.Size = new System.Drawing.Size(406, 47);
            this.SoruEklemeButton.TabIndex = 3;
            this.SoruEklemeButton.Text = "Soru Ekle";
            this.SoruEklemeButton.UseVisualStyleBackColor = true;
            this.SoruEklemeButton.Click += new System.EventHandler(this.SoruEklemeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SinavSorumlusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SoruEklemeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ListeleButton);
            this.Controls.Add(this.SinavSorumlusuData);
            this.Name = "SinavSorumlusu";
            this.Text = "SinavSorumlusu";
            ((System.ComponentModel.ISupportInitialize)(this.SinavSorumlusuData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SinavSorumlusuData;
        private System.Windows.Forms.Button ListeleButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SoruEklemeButton;
        private System.Windows.Forms.Button button1;
    }
}