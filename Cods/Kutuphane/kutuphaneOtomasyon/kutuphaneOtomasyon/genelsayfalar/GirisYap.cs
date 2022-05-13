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
        #region Bağlantı ve kullanıcı varlığı
        MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
        public static string ad, soyad, email, departman;
        bool kontrol = false;
        #endregion
        public GirisYap()
        {
            InitializeComponent();
            Init_Data();
        }

        #region Şifreyi Gizle
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) 
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Şifreyi Göster";
            }

           else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Şifreyi Gizle";
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void GirisYap_Shown(object sender, EventArgs e)
        {
        }

        private void GirisYap_Load(object sender, EventArgs e)
        {   
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Kullanıcı Tipine Göre Giriş
            baglanti.Open();
            MySqlCommand sorgu = new MySqlCommand("SELECT *FROM admin", baglanti);
            MySqlDataReader oku = sorgu.ExecuteReader();
            while (oku.Read() == true)
            {
                if (oku["kullaniciadi"].ToString() == textBox1.Text && oku["sifre"].ToString() == textBox2.Text && oku["departman"].ToString() == "kutuphane_gorevlisi")
                {
                    kontrol = true;
                    ad = oku.GetValue(1).ToString();
                    soyad = oku.GetValue(2).ToString();
                    email = oku.GetValue(3).ToString();
                    departman = oku.GetValue(6).ToString();
                    Save_Data();
                    anasayfa ac = new anasayfa();
                    this.Hide();
                    ac.Show();
                    

                    break;
                }

                if (oku["kullaniciadi"].ToString() == textBox1.Text && oku["sifre"].ToString() == textBox2.Text && oku["departman"].ToString() == "ogrenci_isleri")
                {
                    kontrol = true;
                    ad = oku.GetValue(1).ToString();
                    soyad = oku.GetValue(2).ToString();
                    email = oku.GetValue(3).ToString();
                    departman = oku.GetValue(6).ToString();
                    Save_Data();
                    Ogrenciİsleri ac = new Ogrenciİsleri();
                    this.Hide();
                    ac.Show();

                    break;
                }
            }

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz");
            }
            else if (kontrol == false)
            {
                MessageBox.Show("Geçersiz Kullanıcı Girişi");
            }
            baglanti.Close();
            #endregion
        }
       
        #region Beni Hatırla
        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName!=string.Empty)
            {
                if (Properties.Settings.Default.Remember==true)
                {
                    textBox1.Text = Properties.Settings.Default.UserName;
                    textBox2.Text = Properties.Settings.Default.Password;
                    checkBox2.Checked = true;
                }
                else
                {
                    textBox1.Text = Properties.Settings.Default.UserName;
                }

            }
        }

        private void Save_Data()
        {
            if (checkBox2.Checked)
            {
                Properties.Settings.Default.UserName = textBox1.Text;
                Properties.Settings.Default.Password = textBox2.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }

        #endregion
    }
}
