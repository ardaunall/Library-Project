using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyon
{
    public partial class Emanet : Form
    {
        public Emanet()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
        void KisiListele()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT emanetkitap.emanet_id,emanetkitap.ogrenci_no,kitap.kitap_ad,emanetkitap.emanet_tarih,emanetkitap.teslimtarih, emanetkitap.teslimedildi FROM emanetkitap INNER JOIN ogrenci ON emanetkitap.ogrenci_no = ogrenci.ogrenci_id INNER JOIN kitap ON emanetkitap.kitap_id = kitap.id", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            anasayfa ac = new anasayfa();
            ac.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region emanet ver
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into emanetkitap(ogrenci_no,kitap_id,emanet_tarih,teslimtarih) values (@ogrno,@ad,@emanet,@teslim)", baglanti);
            komut.Parameters.AddWithValue("@ogrno",comboOgr.SelectedValue.ToString());
            komut.Parameters.AddWithValue("@ad",comboKitap.SelectedValue.ToString());
            komut.Parameters.AddWithValue("@emanet", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@teslim", dateTimePicker2.Text);
            if (String.IsNullOrEmpty(comboOgr.Text) || String.IsNullOrEmpty(comboKitap.Text))
            {
                MessageBox.Show("Boş Geçilemez");
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Emanet Kaydı Oluşturuldu");
            }
            baglanti.Close();
            KisiListele();
            #endregion
        }

        private void Emanet_Load(object sender, EventArgs e)
        {
            #region Emanet Listele
            KisiListele();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Öğrenci No";
            dataGridView1.Columns[2].HeaderText = "Kitap İsmi";
            dataGridView1.Columns[3].HeaderText = "Emanet Tarihi";
            dataGridView1.Columns[4].HeaderText = "Teslim Tarihi";
            dataGridView1.Columns[5].HeaderText = "Emanet Durum";
            #endregion
            #region Kitap
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM kitap ORDER BY kitap_ad ASC", baglanti);
            MySqlDataAdapter daCategories1 = new MySqlDataAdapter(command);
            DataSet dsCategories1 = new DataSet();
            daCategories1.Fill(dsCategories1);
            command.ExecuteNonQuery();
            baglanti.Close();
            comboKitap.DataSource = dsCategories1.Tables[0];
            comboKitap.DisplayMember = "kitap_ad";
            comboKitap.ValueMember = "id";
            #endregion
            KisiListele();
            #region Öğrenci 
            baglanti.Open();
            MySqlCommand com = new MySqlCommand("SELECT * FROM ogrenci ORDER BY ad,soyad ASC", baglanti);
            MySqlDataAdapter daCategories2 = new MySqlDataAdapter(com);
            DataSet dsCategories2 = new DataSet();
            daCategories2.Fill(dsCategories2);
            com.ExecuteNonQuery();
            baglanti.Close();
            comboOgr.DataSource = dsCategories2.Tables[0];
            comboOgr.DisplayMember = "ad,soyad";
            comboOgr.ValueMember = "ogrenci_id";
            #endregion
            KisiListele();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Emanet Alma
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            string sorgu = "UPDATE emanetkitap SET teslimedildi= \"Teslim Edildi\" where emanet_id=@id";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Emanet Başarı İle güncellendi");
            KisiListele();
            #endregion
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            comboOgr.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboKitap.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
