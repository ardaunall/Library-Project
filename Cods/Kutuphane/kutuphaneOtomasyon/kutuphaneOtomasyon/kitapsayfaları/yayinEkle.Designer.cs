
namespace kutuphaneOtomasyon
{
    partial class yayinEkle
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
            this.txt_yayin = new System.Windows.Forms.TextBox();
            this.yayinBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_yayin
            // 
            this.txt_yayin.Location = new System.Drawing.Point(225, 31);
            this.txt_yayin.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yayin.Name = "txt_yayin";
            this.txt_yayin.Size = new System.Drawing.Size(209, 22);
            this.txt_yayin.TabIndex = 8;
            // 
            // yayinBtn
            // 
            this.yayinBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.yayinBtn.Location = new System.Drawing.Point(320, 61);
            this.yayinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.yayinBtn.Name = "yayinBtn";
            this.yayinBtn.Size = new System.Drawing.Size(114, 35);
            this.yayinBtn.TabIndex = 6;
            this.yayinBtn.Text = "Yayın Evi Ekle";
            this.yayinBtn.UseVisualStyleBackColor = false;
            this.yayinBtn.Click += new System.EventHandler(this.yayinBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.yayinBtn);
            this.panel1.Controls.Add(this.txt_yayin);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 181);
            this.panel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yayınevi Ekle:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::kutuphaneOtomasyon.Properties.Resources.icons8_edit_property_50px;
            this.pictureBox4.Location = new System.Drawing.Point(194, 26);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // yayinEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(517, 175);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "yayinEkle";
            this.Text = "yayinEkle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_yayin;
        private System.Windows.Forms.Button yayinBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}