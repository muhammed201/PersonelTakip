using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class AddCourt : Form
    {
        public AddCourt()
        {
            InitializeComponent();
        }

        void courtGridCaption()
        {
            courtGrid.Columns[0].HeaderText = "Brim Id";
            courtGrid.Columns[1].HeaderText = "Brim";
            courtGrid.Columns[2].HeaderText = "Oda Nu";
            courtGrid.Columns[3].HeaderText = "Kat";
            courtGrid.Columns[4].HeaderText = "Bina";
            courtGrid.Columns[5].HeaderText = "Not";                        
        }

        void courtsGroupEmpty()  //Textbox ve Combobox'ları temizleme fonksiyonu. Lazım oldukça çağırıyoruz.
        {
            foreach (Control item in courtsgroupBox.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox txt = item as ComboBox;
                    txt.Text = string.Empty;
                }
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Text = string.Empty;
                }
            }
        }
        private void AddCourt_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Kullanıcı: " + genel.enterUserName;

                //Brimlerin listesi CourtGrid'e yükleniyor.
                courtGrid.DataSource = veriTabani.vtbaglan("Select courts.idcourts, courts.court, courts.roomnumber, courts.floor, courts.build, courts.note from courts  ORDER BY courts.court ASC;");
                courtGridCaption();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. Hata: " + hata);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string hataMesaji = string.Empty;
                int hasRecord;

                hasRecord = veriTabani.kullaniciSayisi("Select COUNT(*) from courts where court='" + court.Text.Trim() + "'", ref hataMesaji);                

                if (String.IsNullOrEmpty(court.Text) != false) //Brim isminde boşluk olup olmadığını kontrol eden method çağırılıyor
                {
                    MessageBox.Show("Boş alanlar tespit edildi. Lütfen Brim adı alanını eksiksiz doldurduktan sonra tekrar deneyiniz", "Boş Alan Tespit Edildi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                else if(hasRecord != 0)
                {
                    MessageBox.Show("Bu isimle bir brim zaten kayıtlı. Lütfen yeni bir brim ismi ile tekrar deneyiniz", "Tekrarlayan Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                
                veriTabani.veriEkle("INSERT INTO courts (court, roomnumber, floor, build, note, courtlog) VALUES ('" + court.Text.Trim() + "','" + roomNumber.Text.Trim() + "','" + floor.Text.Trim() + "','" + built.Text.Trim() + "','" + note.Text.Trim() + "','" + genel.enterUserName + " tarafından " + DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss") +  " tarihinde kayıt edildi');", ref hataMesaji);
               
                if (hataMesaji == String.Empty)
                {
                    MessageBox.Show("Kayıt başarılı");                    
                    courtsGroupEmpty(); //Textbox ve Combobox'ları temizliyoruz                    
                    courtGrid.DataSource = veriTabani.vtbaglan("Select courts.idcourts, courts.court, courts.roomnumber, courts.floor, courts.build, courts.note from courts  ORDER BY courts.court ASC;");
                    courtGridCaption();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. Hata: " + hata);
            }

        }

        private void AddCourt_FormClosed(object sender, FormClosedEventArgs e)
        {
          //Brim ekle formu kapatılınca otomatik olarak personel formunu yenileyen kod yazılacak. Yoksa personel formundaki brimler ve ünvanlar güncellenmiyor. Formu yenilemek gerekiyor.
        }

        private void courtGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//Farenin sağ tuşuna masılmışsa
            {

                int satir = courtGrid.HitTest(e.X, e.Y).RowIndex; //Seçili satırı buluyoruz
                if (satir > -1)
                {
                    courtGrid.Rows[satir].Selected = true;//bu kodu yazmazsak önce tıklayıp sonra sağ tıklayabiliyoruz. Bunu ekledikten sonra sağ tıklada direk seçim yapıp menü açılıyor.                                        
                }
            }
        }

        private void courtGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            courtGridGroupBox.Text = courtGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            courtIdLabel.Text = courtGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            court.Text= courtGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            roomNumber.Text= courtGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            floor.Text= courtGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            built.Text= courtGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            note.Text= courtGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteCourt, deleteCourtId;
                string hataMesaji = null;
                Boolean deleteSuccessful = false;
                DialogResult yourChoice = new DialogResult();

                //Aşağıda tüm sicil, ad ve soyad değerlerini bir değişkene atıyoruz çünkü direk datagrid üzerinden aktarmaya çalıştığımda sağ tıklamada sorun oluştu. 
                //yanlış kayıt silme riskine karşı hepsini değişkene atayıp işlem yaptırdım
                deleteCourt = courtGridGroupBox.Text;
                deleteCourtId = courtIdLabel.Text;


                yourChoice = MessageBox.Show(deleteCourt + " brimini silmek istediğinize emin misiniz? DİKKAT BU BRİMİ SİLERSENİZ BU BRİME KAYITLI TÜM PERSONEL DE SİLİNECEKTİR!!!", "Brim Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (yourChoice == DialogResult.Yes)
                {
                    deleteSuccessful = veriTabani.veriSil("Delete From courts where court like '" + deleteCourt + "'", ref hataMesaji);
                    if (deleteSuccessful)
                    {
                        courtsGroupEmpty(); //Textbox ve Combobox'ları temizliyoruz                    
                        courtGrid.DataSource = veriTabani.vtbaglan("Select courts.idcourts, courts.court, courts.roomnumber, courts.floor, courts.build, courts.note from courts  ORDER BY courts.court ASC;");
                        courtGridCaption();
                        //Brim silindikten sonra bu brime kayıtlı kişiler siliniyor.
                        veriTabani.veriSil("Delete From staff where department='" + deleteCourtId + "'", ref hataMesaji);
                        MessageBox.Show("Kayıt silinmiştir", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Silme işleminde bir hata oluştu..." + Environment.NewLine + "HATA: " + hataMesaji, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. Hata: " + hata);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            courtsGroupEmpty(); //Textbox ve Combobox'ları temizliyoruz                    
            courtGridCaption();            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string hataMesaji = string.Empty;
                DialogResult yourChoice = new DialogResult();
                int hasRecord;

                hasRecord = veriTabani.kullaniciSayisi("Select COUNT(*) from courts where court='" + court.Text.Trim() + "' and court!='" + courtGridGroupBox.Text + "'", ref hataMesaji);                

                if (String.IsNullOrEmpty(court.Text) != false) //Brim isminde boşluk olup olmadığını kontrol eden method çağırılıyor
                {
                    MessageBox.Show("Boş alanlar tespit edildi. Lütfen Brim adı alanını eksiksiz doldurduktan sonra tekrar deneyiniz", "Boş Alan Tespit Edildi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                else if (hasRecord != 0)
                {
                    MessageBox.Show("Bu isimle bir brim zaten kayıtlı. Lütfen yeni bir brim ismi ile tekrar deneyiniz", "Tekrarlayan Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }                
                
                yourChoice = MessageBox.Show(courtGridGroupBox.Text.ToUpper() + " biriminde yapılan değişiklikleri güncellemek istiyor musunuz? DİKKAT BU BRİMDE YAPACAĞINIZ TÜM DEĞİŞİKLİKLER KAYITLI TÜM PERSONEL DE DEĞİŞİKLİK YAPACAKTIR!!!  ", "Birim Güncelleme", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                
                if (yourChoice == DialogResult.Yes)
                {
                    veriTabani.veriGuncelle("UPDATE courts SET court='" + court.Text.Trim() + "', roomnumber='" + roomNumber.Text.Trim() + "', floor='" + floor.Text.Trim() + "', build='" + built.Text.Trim() + "', note='" + note.Text.ToString() + "', courtlog= CONCAT(courtlog, ' ', ' log:" + DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss") + " Tarihinde " + genel.enterUserName + " tarafından güncellendi.') WHERE court='" + courtGridGroupBox.Text + "'", ref hataMesaji);
                }
                else
                {
                    MessageBox.Show("Güncelleme işleminden vazgeçtiniz", "Birim Güncelleme", MessageBoxButtons.OK);
                    hataMesaji = "Kayıt İptal Edildi";
                }

                

                if (hataMesaji == String.Empty)                    
                {
                    MessageBox.Show("Kayıt başarılı");
                    courtsGroupEmpty(); //Textbox ve Combobox'ları temizliyoruz                    
                    courtGrid.DataSource = veriTabani.vtbaglan("Select courts.idcourts, courts.court, courts.roomnumber, courts.floor, courts.build, courts.note from courts  ORDER BY courts.court ASC;");
                    courtGridCaption();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. Hata: " + hata);
            }
        }
    }
}
