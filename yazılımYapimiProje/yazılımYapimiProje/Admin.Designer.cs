
namespace yazılımYapimiProje
{
    partial class Admin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminSınavSorumlusuGetir = new System.Windows.Forms.Button();
            this.AdminOgrenciGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SilButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::yazılımYapimiProje.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(85, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminSınavSorumlusuGetir
            // 
            this.AdminSınavSorumlusuGetir.Location = new System.Drawing.Point(680, 27);
            this.AdminSınavSorumlusuGetir.Name = "AdminSınavSorumlusuGetir";
            this.AdminSınavSorumlusuGetir.Size = new System.Drawing.Size(146, 34);
            this.AdminSınavSorumlusuGetir.TabIndex = 1;
            this.AdminSınavSorumlusuGetir.Text = "Sınav Sorumluları";
            this.AdminSınavSorumlusuGetir.UseVisualStyleBackColor = true;
            this.AdminSınavSorumlusuGetir.Click += new System.EventHandler(this.AdminSınavSorumlusuGetir_Click);
            // 
            // AdminOgrenciGetir
            // 
            this.AdminOgrenciGetir.Location = new System.Drawing.Point(680, 80);
            this.AdminOgrenciGetir.Name = "AdminOgrenciGetir";
            this.AdminOgrenciGetir.Size = new System.Drawing.Size(146, 34);
            this.AdminOgrenciGetir.TabIndex = 2;
            this.AdminOgrenciGetir.Text = "Öğrenciler";
            this.AdminOgrenciGetir.UseVisualStyleBackColor = true;
            this.AdminOgrenciGetir.Click += new System.EventHandler(this.AdminOgrenciGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(581, 228);
            this.dataGridView1.TabIndex = 3;
            // 
            // SilButton
            // 
            this.SilButton.Location = new System.Drawing.Point(711, 335);
            this.SilButton.Name = "SilButton";
            this.SilButton.Size = new System.Drawing.Size(115, 25);
            this.SilButton.TabIndex = 4;
            this.SilButton.Text = "Sil";
            this.SilButton.UseVisualStyleBackColor = true;
            this.SilButton.Click += new System.EventHandler(this.SilButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Silinecek kişinin ID:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(776, 293);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(64, 23);
            this.TxtId.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(862, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SilButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AdminOgrenciGetir);
            this.Controls.Add(this.AdminSınavSorumlusuGetir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AdminSınavSorumlusuGetir;
        private System.Windows.Forms.Button AdminOgrenciGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SilButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button button1;
    }
}