
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
            this.txt_raf.Location = new System.Drawing.Point(171, 25);
            this.txt_raf.Name = "txt_raf";
            this.txt_raf.Size = new System.Drawing.Size(158, 20);
            this.txt_raf.TabIndex = 5;
            // 
            // rafeklebtn
            // 
            this.rafeklebtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rafeklebtn.Location = new System.Drawing.Point(242, 50);
            this.rafeklebtn.Name = "rafeklebtn";
            this.rafeklebtn.Size = new System.Drawing.Size(86, 28);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 147);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::kutuphaneOtomasyon.Properties.Resources.icons8_book_shelf_40px;
            this.pictureBox11.Location = new System.Drawing.Point(148, 21);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(22, 24);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 52;
            this.pictureBox11.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raf Numarası:";
            // 
            // raf
            // 
            this.AcceptButton = this.rafeklebtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(391, 145);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "raf";
            this.Load += new System.EventHandler(this.raf_Load);
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