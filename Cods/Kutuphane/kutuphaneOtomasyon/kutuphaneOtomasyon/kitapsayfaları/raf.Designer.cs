
namespace kutuphaneOtomasyon
{
    partial class raf
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
            this.txt_raf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rafeklebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_raf
            // 
            this.txt_raf.Location = new System.Drawing.Point(129, 49);
            this.txt_raf.Name = "txt_raf";
            this.txt_raf.Size = new System.Drawing.Size(158, 20);
            this.txt_raf.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Raf Numarası";
            // 
            // rafeklebtn
            // 
            this.rafeklebtn.Location = new System.Drawing.Point(157, 88);
            this.rafeklebtn.Name = "rafeklebtn";
            this.rafeklebtn.Size = new System.Drawing.Size(79, 39);
            this.rafeklebtn.TabIndex = 3;
            this.rafeklebtn.Text = "Raf Ekle";
            this.rafeklebtn.UseVisualStyleBackColor = true;
            this.rafeklebtn.Click += new System.EventHandler(this.rafeklebtn_Click);
            // 
            // raf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(364, 231);
            this.Controls.Add(this.txt_raf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rafeklebtn);
            this.Name = "raf";
            this.Text = "raf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_raf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rafeklebtn;
    }
}