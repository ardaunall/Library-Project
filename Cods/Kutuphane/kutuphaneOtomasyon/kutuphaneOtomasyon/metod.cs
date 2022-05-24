using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace kutuphaneOtomasyon
{
    public class metod
    {
        #region Admin kontrol
        /*
        string ConStr = "SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.";

        public int KullaniciKontrol(string kAd, string kSifre, string kDepartman)
        {
            int sonuc = 0;

            using (var con = new MySqlConnection(ConStr))
            {
                using (var cmd = new MySqlCommand($"SELECT kullaniciadi,sifre,departman FROM admin WHERE kullaniciadi='{kAd}', sifre='{kSifre}', departman='{kDepartman}'",con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            string d_k = dtr["kullaniciadi"].ToString();
                            string d_s = dtr["sifre"].ToString();
                            string d_d = dtr["departman"].ToString();
                            if(d_k==kAd && d_s==kSifre && d_d==kDepartman)
                            {
                                sonuc = 1;
                            }
                            else
                            {
                                sonuc = 0;
                            }

                        }
                    }
                    catch 
                    {
                        sonuc = 0;
                    }
                }
            }

                return sonuc;
        }
       */
        #endregion
        public int RowIndex { get; }
    }
}
