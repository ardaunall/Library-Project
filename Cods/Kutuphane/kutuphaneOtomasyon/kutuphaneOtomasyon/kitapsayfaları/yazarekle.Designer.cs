
namespace kutuphaneOtomasyon
{
    partial class yazarekle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.yzreklebtn = new System.Windows.Forms.Button();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.yzreklebtn);
            this.panel1.Controls.Add(this.txt_yazar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 181);
            this.panel1.TabIndex = 24;
            // 
            // yzreklebtn
            // 
            this.yzreklebtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.yzreklebtn.ForeColor = System.Drawing.Color.Black;
            this.yzreklebtn.Location = new System.Drawing.Point(370, 83);
            this.yzreklebtn.Name = "yzreklebtn";
            this.yzreklebtn.Size = new System.Drawing.Size(114, 32);
            this.yzreklebtn.TabIndex = 0;
            this.yzreklebtn.Text = "Yazarı Ekle";
            this.yzreklebtn.UseVisualStyleBackColor = false;
            this.yzreklebtn.Click += new System.EventHandler(this.yzreklebtn_Click);
            // 
            // txt_yazar
            // 
            this.txt_yazar.Location = new System.Drawing.Point(301, 54);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(183, 23);
            this.txt_yazar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yazar Adı ve Soyadı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kutuphaneOtomasyon.Properties.Resources.icons8_compose_48px1;
            this.pictureBox1.Location = new System.Drawing.Point(269, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // yazarekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(519, 178);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "yazarekle";
            this.Text = "yazarekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.yazarekle_FormClosing);
            this.Load += new System.EventHandler(this.yazarekle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button yzreklebtn;
        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}