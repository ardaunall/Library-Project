
namespace kutuphaneOtomasyon
{
    partial class anasayfa
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
            this.cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(616, 309);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(111, 72);
            this.cikis.TabIndex = 0;
            this.cikis.Text = "Oturumu Kapat";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cikis);
            this.Name = "anasayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cikis;
    }
}