
namespace kutuphaneOtomasyon
{
    partial class kategoriEkle
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
            this.txt_kate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ktgBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_kate
            // 
            this.txt_kate.Location = new System.Drawing.Point(159, 47);
            this.txt_kate.Name = "txt_kate";
            this.txt_kate.Size = new System.Drawing.Size(158, 20);
            this.txt_kate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategori Adı";
            // 
            // ktgBtn
            // 
            this.ktgBtn.Location = new System.Drawing.Point(191, 88);
            this.ktgBtn.Name = "ktgBtn";
            this.ktgBtn.Size = new System.Drawing.Size(79, 39);
            this.ktgBtn.TabIndex = 3;
            this.ktgBtn.Text = "Kategori Ekle";
            this.ktgBtn.UseVisualStyleBackColor = true;
            this.ktgBtn.Click += new System.EventHandler(this.yzreklebtn_Click);
            // 
            // kategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(439, 198);
            this.Controls.Add(this.txt_kate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ktgBtn);
            this.Name = "kategoriEkle";
            this.Text = "yayinEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ktgBtn;
    }
}