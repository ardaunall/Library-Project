using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kutuphaneOtomasyon
{
    public partial class GirisYap : Form
    {
        metod mtt = new metod();    

        public GirisYap()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) 
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }

           else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void GirisYap_Shown(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void GirisYap_Load(object sender, EventArgs e)
        {
            #region admin üyelerini çektik
            string ConStr = "SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.";
            using (var baglan = new MySqlConnection(ConStr))
            {
                using (var komut = new MySqlCommand("SELECT kullaniciadi FROM admin ORDER BY kullaniciadi ASC", baglan))
                {
                    try
                    {
                        komut.Connection.Open();
                        MySqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            kullanciadi.Items.Add(dr["kullaniciadi"].ToString());
                        }
                        kullanciadi.SelectedIndex = 0;
                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.Message);
                    }
                }
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(mtt.KullaniciKontrol(kullanciadi.SelectedItem.ToString(),textBox2.Text)==1)
            {
                MessageBox.Show("Giriş Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Giriş Geçersiz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
