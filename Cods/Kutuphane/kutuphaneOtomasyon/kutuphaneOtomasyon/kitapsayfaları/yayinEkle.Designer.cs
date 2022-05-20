
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
            this.label1 = new System.Windows.Forms.Label();
            this.yayinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_yayin
            // 
            this.txt_yayin.Location = new System.Drawing.Point(131, 44);
            this.txt_yayin.Name = "txt_yayin";
            this.txt_yayin.Size = new System.Drawing.Size(158, 20);
            this.txt_yayin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yayın Evi Ekle";
            // 
            // yayinBtn
            // 
            this.yayinBtn.Location = new System.Drawing.Point(163, 85);
            this.yayinBtn.Name = "yayinBtn";
            this.yayinBtn.Size = new System.Drawing.Size(79, 39);
            this.yayinBtn.TabIndex = 6;
            this.yayinBtn.Text = "Yayın Evi Ekle";
            this.yayinBtn.UseVisualStyleBackColor = true;
            this.yayinBtn.Click += new System.EventHandler(this.yayinBtn_Click);
            // 
            // yayinEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(393, 205);
            this.Controls.Add(this.txt_yayin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yayinBtn);
            this.Name = "yayinEkle";
            this.Text = "yayinEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_yayin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yayinBtn;
    }
}