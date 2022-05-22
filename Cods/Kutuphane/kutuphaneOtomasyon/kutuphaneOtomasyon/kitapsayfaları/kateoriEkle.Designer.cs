
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
            this.ktgBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kate
            // 
            this.txt_kate.Location = new System.Drawing.Point(210, 32);
            this.txt_kate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kate.Name = "txt_kate";
            this.txt_kate.Size = new System.Drawing.Size(209, 22);
            this.txt_kate.TabIndex = 5;
            // 
            // ktgBtn
            // 
            this.ktgBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ktgBtn.Location = new System.Drawing.Point(305, 62);
            this.ktgBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ktgBtn.Name = "ktgBtn";
            this.ktgBtn.Size = new System.Drawing.Size(114, 35);
            this.ktgBtn.TabIndex = 3;
            this.ktgBtn.Text = "Kategori Ekle";
            this.ktgBtn.UseVisualStyleBackColor = false;
            this.ktgBtn.Click += new System.EventHandler(this.yzreklebtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ktgBtn);
            this.panel1.Controls.Add(this.txt_kate);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 181);
            this.panel1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Adı:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::kutuphaneOtomasyon.Properties.Resources.icons8_opened_folder_40px;
            this.pictureBox7.Location = new System.Drawing.Point(180, 26);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 48;
            this.pictureBox7.TabStop = false;
            // 
            // kategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(520, 181);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kategoriEkle";
            this.Text = "yayinEkle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kate;
        private System.Windows.Forms.Button ktgBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}