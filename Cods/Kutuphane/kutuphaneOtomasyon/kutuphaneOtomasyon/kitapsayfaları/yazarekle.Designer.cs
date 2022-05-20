
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
            this.yzreklebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // yzreklebtn
            // 
            this.yzreklebtn.Location = new System.Drawing.Point(174, 82);
            this.yzreklebtn.Name = "yzreklebtn";
            this.yzreklebtn.Size = new System.Drawing.Size(79, 39);
            this.yzreklebtn.TabIndex = 0;
            this.yzreklebtn.Text = "Yazarı Ekle";
            this.yzreklebtn.UseVisualStyleBackColor = true;
            this.yzreklebtn.Click += new System.EventHandler(this.yzreklebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yazar Adı ve Soyadı:";
            // 
            // txt_yazar
            // 
            this.txt_yazar.Location = new System.Drawing.Point(139, 46);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(158, 20);
            this.txt_yazar.TabIndex = 2;
            // 
            // yazarekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(369, 192);
            this.Controls.Add(this.txt_yazar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yzreklebtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "yazarekle";
            this.Text = "yazarekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.yazarekle_FormClosing);
            this.Load += new System.EventHandler(this.yazarekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yzreklebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_yazar;
    }
}