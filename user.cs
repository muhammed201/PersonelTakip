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

namespace PersonelTakip
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void cancelSystem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterSystem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable veri = new DataTable();
                veri= veriTabani.vtbaglan("Select * from users where userName='" + userName.Text + "' and userPassword='" + userPassword.Text + "';");                
                genel.enterUserName = veri.Rows[0][1].ToString();       //Kullanıcı adını genel bir değişkene atıyoruz. 
                genel.enterUserAuthority= veri.Rows[0][3].ToString();   //Kullanıcı yetkisini genel bir değişkene atıyoruz.
                veri.Clear();
                
                //Kullanıcı adı ve şifresi doğru ise personel formunu açıyoruz. Personel formunun açıp olup olmadığını kontrol ediyoruz. 
                bool donen = genel.acikFormKontrolEt("personel");
                if (donen == true)
                {
                    MessageBox.Show("Açmak istediğiniz pencere zaten açık...", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(genel.enterUserAuthority=="admin") //Admin kullanıcı açılmış ise 
                {
                    MessageBox.Show("Giriş başarılı", "Hoşgeldiniz...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    personel personelForm= new personel();
                    personelForm.Show();
                    this.Hide();
                }
                else if(genel.enterUserAuthority == "user") // Kısıtlı kullanıcı açılmış ise 
                {
                    MessageBox.Show("Giriş başarılı", "Hoşgeldiniz...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userMod userModForm = new userMod();
                    userModForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Farklı bir durum oluştu. Lütfen sistem yöneticinize başvurunuz. (Eskişehir Bilgiişlem Müdürlüğü: Muhammed ZENGİN) ");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kullanıcı adınız yada şifreniz yanlış. Hata:  " + hata.Message);
            }
        }

        private void userPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterSystem_Click(sender, e);
            }
        }

        private void user_Load(object sender, EventArgs e)
        {
            veriTabani.dataBaseCheck();
        }
    }
}
