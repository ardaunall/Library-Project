
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(raf));
            this.txt_raf = new System.Windows.Forms.TextBox();
            this.rafeklebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_raf
            // 
            this.txt_raf.Location = new System.Drawing.Point(228, 31);
            this.txt_raf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_raf.Name = "txt_raf";
            this.txt_raf.Size = new System.Drawing.Size(209, 22);
            this.txt_raf.TabIndex = 5;
            // 
            // rafeklebtn
            // 
            this.rafeklebtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rafeklebtn.Location = new System.Drawing.Point(323, 61);
            this.rafeklebtn.Margin = new System.Windows.Forms.Padding(4);
            this.rafeklebtn.Name = "rafeklebtn";
            this.rafeklebtn.Size = new System.Drawing.Size(114, 35);
            this.rafeklebtn.TabIndex = 3;
            this.rafeklebtn.Text = "Raf Ekle";
            this.rafeklebtn.UseVisualStyleBackColor = false;
            this.rafeklebtn.Click += new System.EventHandler(this.rafeklebtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rafeklebtn);
            this.panel1.Controls.Add(this.txt_raf);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 181);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::kutuphaneOtomasyon.Properties.Resources.icons8_book_shelf_40px;
            this.pictureBox11.Location = new System.Drawing.Point(197, 26);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(29, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 52;
            this.pictureBox11.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raf Numarası:";
            // 
            // raf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(521, 179);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "raf";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_raf;
        private System.Windows.Forms.Button rafeklebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}