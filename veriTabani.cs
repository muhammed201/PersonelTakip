using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace PersonelTakip
{
    internal class veriTabani
    {
        
        public static string[] serverInfo = new string[10];  //Server bilgileri için genel bir dizi oluşturuyoruz
        public static void dataBaseCheck()                  //Server bilgilerini text dosyasından çekmek için bir methot oluşturuyoruz
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "/db.txt");
            string satir = null;
            int x = 0;

            while (true)
            {
                satir = sr.ReadLine();
                if (satir == null)
                {
                    break;
                }
                serverInfo[x] = satir;
                x++;
            }            
        }
        public static DataTable vtbaglan(string gelenKomut)
        {
            MySqlConnection baglanti = new MySqlConnection("server=" + serverInfo[0] + "; port=" + serverInfo[1] + "; user id=" + serverInfo[2] + ";password=" + serverInfo[3] + ";persistsecurityinfo=True;database=" + serverInfo[4] + "");
            baglanti.Open();
            MySqlDataAdapter veri = new MySqlDataAdapter(gelenKomut, baglanti);
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public static int kullaniciSayisi(string gelenKomut, ref string hataMesaji)
        {
            try
            {
                int kulSayisi;
                MySqlConnection baglanti = new MySqlConnection("server=" + serverInfo[0] + "; port=" + serverInfo[1] + "; user id=" + serverInfo[2] + ";password=" + serverInfo[3] + ";persistsecurityinfo=True;database=" + serverInfo[4] + "");
                baglanti.Open();

                MySqlCommand kmt = new MySqlCommand(gelenKomut, baglanti);
                //Aşağıdaki kodla kullanıcı sayısını hesaplıyoruz, diğer sorgular genelde ExecuteNonQuery() metoduyla yapılırken aşağıda ExecuteScalar() medoduyla yapılıp int32'ye çevriliyor.
                kulSayisi = Convert.ToInt32(kmt.ExecuteScalar());
                baglanti.Close();
                return kulSayisi;
            }
            catch (Exception sorun)
            {
                hataMesaji = sorun.Message;
                return 0;

            }
        }

        public static bool veriEkle(string gelenKomut, ref string hataMesaji)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("server=" + serverInfo[0] + "; port=" + serverInfo[1] + "; user id=" + serverInfo[2] + ";password=" + serverInfo[3] + ";persistsecurityinfo=True;database=" + serverInfo[4] + "");
                baglanti.Open();

                MySqlCommand kmt = new MySqlCommand(gelenKomut, baglanti);
                kmt.ExecuteNonQuery();

                baglanti.Close();
                return true;
            }
            catch (Exception sorun)
            {
                hataMesaji = sorun.Message;
                MessageBox.Show("Bir hata oluştu. Hata: " + hataMesaji,"Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;

            }
        }
        public static bool veriGuncelle(string gelenKomut, ref string hataMesaji)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("server=" + serverInfo[0] + "; port=" + serverInfo[1] + "; user id=" + serverInfo[2] + ";password=" + serverInfo[3] + ";persistsecurityinfo=True;database=" + serverInfo[4] + "");
                baglanti.Open();

                MySqlCommand kmt = new MySqlCommand(gelenKomut, baglanti);
                kmt.ExecuteNonQuery();

                //dataGridView1.DataSource = tablo;
                baglanti.Close();
                return true;
            }
            catch (Exception sorun)
            {
                hataMesaji = sorun.Message;
                return false;

            }
        }

        public static bool veriSil(string gelenKomut, ref string hataMesaji)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("server=" + serverInfo[0] + "; port=" + serverInfo[1] + "; user id=" + serverInfo[2] + ";password=" + serverInfo[3] + ";persistsecurityinfo=True;database=" + serverInfo[4] + "");
                baglanti.Open();

                MySqlCommand kmt = new MySqlCommand(gelenKomut, baglanti);
                kmt.ExecuteNonQuery();

                //dataGridView1.DataSource = tablo;
                baglanti.Close();
                return true;
            }
            catch (Exception sorun)
            {
                hataMesaji = sorun.Message;
                return false;

            }
        }
        public static void dbUpdate()
        {
            string constring = "server=" + serverInfo[0] + "; port="+ serverInfo[1] + "; user=" + serverInfo[2] + "; pwd=" + serverInfo[3] + "; database=" + serverInfo[4] +";";            
            string file = "D:\\" + DateTime.Now.ToString("dddd, dd MMMM yyyy") + ".sql";
            MessageBox.Show("MySql veritabanı " + file + " yoluna kayıt edilecektir");
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
        }
       
    }
}
