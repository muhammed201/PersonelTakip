using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace PersonelTakip
{
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }
        string gDutyId, gDepartmentId; //Duty(görev) ve department(görevyeri) id'lerini bulmak için genel bir değişken oluşturuyoruz. dutyDepartmentIdFind() fonksiyonu ile bulunup gerekli yerlerde kullanılıyor
        void dutyLoad()
        {
            //Önceden başka tabloda tanımlanan görevler Combobox'a aktarılıyor
            //duty comboboxını temizliyoruz yoksa tekrara düşüyor.
            duty.Items.Clear();
            duty.Text = String.Empty;            
            MySqlConnection conn = new MySqlConnection("server=" + veriTabani.serverInfo[0] + "; port=" + veriTabani.serverInfo[1] + "; user id=" + veriTabani.serverInfo[2] + ";password=" + veriTabani.serverInfo[3] + ";persistsecurityinfo=True;database=" + veriTabani.serverInfo[4] + "");
            conn.Open();            

            MySqlCommand cmd = new MySqlCommand("Select * from duties ORDER BY duty ASC", conn);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                duty.Items.Add(dr["duty"].ToString());
            }

            conn.Close();

        }
        void departmentLoad()
        {
            //Önceden başka tabloda tanımlanan görev yerlerini Combobox'a aktarılıyor
            //department comboboxını temizliyoruz yoksa tekrara düşüyor.
            department.Items.Clear();
            department.Text = String.Empty;            

            MySqlConnection conn = new MySqlConnection("server=" + veriTabani.serverInfo[0] + "; port=" + veriTabani.serverInfo[1] + "; user id=" + veriTabani.serverInfo[2] + ";password=" + veriTabani.serverInfo[3] + ";persistsecurityinfo=True;database=" + veriTabani.serverInfo[4] + "");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("Select * from courts ORDER BY court ASC", conn);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                department.Items.Add(dr["court"].ToString());
            }

            conn.Close();

        }

        void dutyDepartmentIdFind(string cDuty, string cDepartment)
        {
            //Herhangi bir hata durumunda bu fonksiyonun doğru çalışmama durumuna karşın gDutyId ve gDepartmendId değerleri boşaltılıyor böylece yanlış id atama riski kaldırılıyor
            gDutyId = String.Empty;
            gDepartmentId = String.Empty;

            //duty metin kutusunda yazan görevin id'si bulunuyor conn
            MySqlConnection conn = new MySqlConnection("server=" + veriTabani.serverInfo[0] + "; port=" + veriTabani.serverInfo[1] + "; user id=" + veriTabani.serverInfo[2] + ";password=" + veriTabani.serverInfo[3] + ";persistsecurityinfo=True;database=" + veriTabani.serverInfo[4] + "");
            conn.Open();

            //department metin kutusunda yazan görevin id'si bulunuyor conn2
            MySqlConnection conn2 = new MySqlConnection("server=" + veriTabani.serverInfo[0] + "; port=" + veriTabani.serverInfo[1] + "; user id=" + veriTabani.serverInfo[2] + ";password=" + veriTabani.serverInfo[3] + ";persistsecurityinfo=True;database=" + veriTabani.serverInfo[4] + "");
            conn2.Open();


            MySqlCommand cmd = new MySqlCommand("Select * from duties where duty like '" + cDuty + "'", conn);
            cmd.ExecuteNonQuery();

            MySqlCommand cmd2 = new MySqlCommand("Select * from courts where court like '" + cDepartment + "'", conn);
            cmd2.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);

            DataTable dt2 = new DataTable();
            MySqlDataAdapter adp2 = new MySqlDataAdapter(cmd2);
            adp2.Fill(dt2);

            foreach (DataRow dr in dt.Rows)
            {
                gDutyId= (dr["idduties"].ToString()); //duty'nin bulunan id'si kayıt işlemi sırasında kullanılmak üzere gDutyId'ye aktarılıyor
            }

            foreach (DataRow dr2 in dt2.Rows)
            {
                gDepartmentId = (dr2["idcourts"].ToString()); //department'ın bulunan id'si kayıt işlemi sırasında kullanılmak üzere gDepartmentId'ye aktarılıyor
            }

            conn.Close();
            conn2.Close();
            
        }

        void staffGroupEmpty()  //Textbox ve Combobox'ları temizleme fonksiyonu. Lazım oldukça çağırıyoruz.
        {
            foreach (Control item in staffGroup.Controls)
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

        void staffGridCaption()
        {
            staffGrid.Columns[0].HeaderText = "Sicil";
            staffGrid.Columns[1].HeaderText = "Adı";
            staffGrid.Columns[2].HeaderText = "Soyadı";
            staffGrid.Columns[3].HeaderText = "Görevi";
            staffGrid.Columns[4].HeaderText = "Görev Yeri";
            staffGrid.Columns[5].HeaderText = "Cep Tel";
            staffGrid.Columns[6].HeaderText = "Dahili";
        }
        public bool checkEmpty()  //Textbox ve Combobox'larda boşluk olup olmadığını kontrol ediyoruz
        {
            foreach (Control item in staffGroup.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox txt = item as ComboBox;
                    if (String.IsNullOrEmpty(txt.Text))
                    {
                        return false;
                    }
                }
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    if (String.IsNullOrEmpty(txt.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        void replaceMobile()
        {
            if (mobilephone.Text.Length != 10)
            {
                if(Regex.Match(mobilephone.Text, @"(\d{3}) (\d{3}) (\d{4})").Success && mobilephone.Text.Length == 12)
                {
                    ;
                }
                else
                {
                    MessageBox.Show("Yanlış cep telefonu formatı girdiniz. Lütfen 10 hane olacak şekilde ve başında 0(sıfır) olmadan deneyiniz", "Yanlış Format", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mobilephone.Text = string.Empty;
                    mobilephone.Focus(); //Hatalı telefon formatı denemesinden sonra telefon numarası temizlenip tekrar imleç telefon numarası giriş kutusuna geliyor.
                    return;
                }
            }
            mobilephone.Text=Regex.Replace(mobilephone.Text, @"(\d{3})(\d{3})(\d{4})", "$1 $2 $3");
        }


        private void personel_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Kullanıcı: " + genel.enterUserName;
               
                //Personel listesi staffGrid'e yükleniyor.
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts)  ORDER BY staff.stafName ASC;");
                dutyLoad();
                departmentLoad();
                staffGridCaption();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. Hata: " + hata);
            }
        }

        private void staffSave_Click(object sender, EventArgs e)
        {
            try
            {
                string hataMesaji = string.Empty;
                int hasRecord;

                hasRecord = veriTabani.kullaniciSayisi("Select COUNT(*) from staff where registration='" + registration.Text + "'", ref hataMesaji);  
                
                if (checkEmpty() != true) //Boşluk olup olmadığını kontrol eden method çağırılıyor
                {
                    MessageBox.Show("Boş alanlar tespit edildi. Lütfen tüm alanları eksiksiz doldurduktan sonra tekrar deneyiniz", "Boş Alan Tespit Edildi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                else if(hasRecord != 0 && staffSave.Text=="Kaydet")
                 {
                    MessageBox.Show("Bu sicil ile daha önceden kayıt edilmiş. Lütfen kontrol edip tekrar deneyiziniz", "Kayıt Tekrarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if(((hasRecord !=0 && staffGroupBox.Text!=registration.Text) || (!(hasRecord >=1) && staffGroupBox.Text== registration.Text))  && staffSave.Text == "Güncelle")
                {
                    MessageBox.Show("Bu sicil ile daha önceden kayıt edilmiş. Lütfen kontrol edip tekrar deneyiziniz", "Kayıt Tekrarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                                
                dutyDepartmentIdFind(duty.Text, department.Text); //Duty ve Department'ların isimlerinden id'leri bulunup veri tabanına id'lerin kayıt edilmesi sağlanması için hazırlanıyor gDutyId ve gDepartmentId değişkenlerine atanıyor.

                if (staffSave.Text == "Kaydet")
                {
                    veriTabani.veriEkle("INSERT INTO staff (registration, stafName, stafSurname, duty, department, mobilephone, internalphone, reg, regdate, stafflog) VALUES ('" + registration.Text.Trim() + "','" + stafName.Text.Trim() + "','" + stafSurname.Text.Trim() + "','" + gDutyId + "','" + gDepartmentId + "','" + mobilephone.Text + "','" + internalphone.Text.Trim() + "','" + genel.enterUserName + "','" + DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss") + "','" + DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss") + " tarihinde kayıt edildi');", ref hataMesaji);
                }
                else if(staffSave.Text == "Güncelle")
                {
                    //Aşağıdaki güncelleme işleminde stafflog işlemini güncellerken concat işlemi ile veritabanındaki stafflog'u aynen alıp eklemek istediğimiz veriyi sonuna ekliyoruz. 
                    veriTabani.veriGuncelle("UPDATE staff SET registration='" + registration.Text.Trim() + "', stafName='" + stafName.Text.Trim() + "', stafSurname='" + stafSurname.Text.Trim() + "', duty='" + gDutyId + "', department='" + gDepartmentId + "', mobilephone='" + mobilephone.Text + "', internalphone='" + internalphone.Text + "', stafflog= CONCAT(stafflog, ' ', ' log:" + DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss") + " Tarihinde " + genel.enterUserName + " tarafından güncellendi.') WHERE registration='" + staffGroupBox.Text + "'", ref hataMesaji);
                    staffSave.Text = "Kaydet";
                    button3.Text = "Temizle";
                    staffGrid.Enabled = true;                    
                }
                
                if (hataMesaji == String.Empty)
                {
                    MessageBox.Show("Kayıt başarılı");

                    staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts)  ORDER BY staff.stafName ASC;");
                    staffGroupEmpty(); //Textbox ve Combobox'ları temizliyoruz                    
                    dutyLoad();
                    departmentLoad();
                }
                else
                {
                    MessageBox.Show(hataMesaji);
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. Hata: " + hata);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text=="Temizle")
            {
                staffGroupEmpty(); //Textbox ve Combobox'ları temizliyoruz
                dutyLoad();
                departmentLoad();                
            }
            else if (button3.Text=="İptal")
            {
                button3.Text = "Temizle";
                staffSave.Text = "Kaydet";
                staffGrid.Enabled = true;
                staffGroupEmpty();
                dutyLoad();
                departmentLoad();
            }

            
        }

        private void mobilephone_Leave(object sender, EventArgs e)
        {
            replaceMobile();
        }

        private void mobilephone_TextChanged(object sender, EventArgs e)
        {
            //replaceMobile();
        }

        private void stafName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aşağıdaki kodlarla sadece harf girilmesine izin veriliyor
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void stafSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aşağıdaki kodlarla sadece harf girilmesine izin veriliyor
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);            
        }

        private void registration_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aşagıdaki kodlar sadece sayı ve harf girilmesine izin veriliyor
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void quickSearch_TextChanged(object sender, EventArgs e)
        {
            //staffGrid.DataSource = veriTabani.vtbaglan("Select registration, stafName, stafSurname, duty, department, mobilephone, internalphone from staff where (registration like '%" + quickSearch.Text.TrimEnd() + "%') or (stafName like '%" + quickSearch.Text.TrimEnd() + "%') or (stafSurname like '%" + quickSearch.Text.TrimEnd() + "%') or (duty like '%" + quickSearch.Text.TrimEnd() + "%') or (department like '%" + quickSearch.Text.TrimEnd() + "%') or (mobilephone like '%" + quickSearch.Text.TrimEnd() + "%') or (internalphone like '%" + quickSearch.Text.TrimEnd() + "%');");
            staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts) WHERE (staff.registration like '%" + quickSearch.Text.TrimEnd() + "%') or (staff.stafName like '%" + quickSearch.Text.TrimEnd() + "%') or (staff.stafSurname like '%" + quickSearch.Text.TrimEnd() + "%') or (staff.duty like '%" + quickSearch.Text.TrimEnd() + "%') or (staff.department like '%" + quickSearch.Text.TrimEnd() + "%') or (staff.mobilephone like '%" + quickSearch.Text.TrimEnd() + "%') or (staff.internalphone like '%" + quickSearch.Text.TrimEnd() + "%') ORDER BY staff.idstaff DESC;");            
        }

        private void staffGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            staffGroupBox.Text = staffGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                //MessageBox.Show(Application.StartupPath + "\\Img\\" + staffGrid.Rows[e.RowIndex].Cells[0].Value.ToString() + ".jpg");
                staffPicture.Image = Image.FromFile(Application.StartupPath + "\\img\\" + staffGrid.Rows[e.RowIndex].Cells[0].Value.ToString() + ".jpg");
            }
            catch
            {
                staffPicture.Image = Image.FromFile(Application.StartupPath + "\\img\\" + "noImg" + ".jpg");
            }
        }

        private void staffGrid_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//Farenin sağ tuşuna masılmışsa
            {

                int satir = staffGrid.HitTest(e.X, e.Y).RowIndex; //Seçili satırı buluyoruz
                if (satir > -1) 
                {
                    staffGrid.Rows[satir].Selected = true;//bu kodu yazmazsak önce tıklayıp sonra sağ tıklayabiliyoruz. Bunu ekledikten sonra sağ tıklada direk seçim yapıp menü açılıyor.                                        
                }
            }
        }

        
        private void deleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteRegistration, deleteName, deleteSurname;
                string hataMesaji = null;
                Boolean deleteSuccessful=false;
                DialogResult yourChoice = new DialogResult();

                //Aşağıda tüm sicil, ad ve soyad değerlerini bir değişkene atıyoruz çünkü direk datagrid üzerinden aktarmaya çalıştığımda sağ tıklamada sorun oluştu. 
                //yanlış kayıt silme riskine karşı hepsini değişkene atayıp işlem yaptırdım
                deleteRegistration = staffGrid.SelectedRows[0].Cells[0].Value.ToString();
                deleteName= staffGrid.SelectedRows[0].Cells[1].Value.ToString();
                deleteSurname = staffGrid.SelectedRows[0].Cells[2].Value.ToString();


                yourChoice = MessageBox.Show(deleteRegistration + " Sicilli " + deleteName + " " + deleteSurname + " kişisiniz silmek istediğinize emin misiniz?", "Kişi Silme İşlemi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                
                if (yourChoice == DialogResult.Yes)
                {
                    deleteSuccessful = veriTabani.veriSil("Delete From staff where registration like '" + deleteRegistration + "'", ref hataMesaji);
                    if (deleteSuccessful)
                    {
                        staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts)  ORDER BY staff.stafName ASC;");
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

        private void updateStaff_Click_1(object sender, EventArgs e)
        {            
            registration.Text = staffGrid.SelectedRows[0].Cells[0].Value.ToString();
            stafName.Text= staffGrid.SelectedRows[0].Cells[1].Value.ToString();
            stafSurname.Text= staffGrid.SelectedRows[0].Cells[2].Value.ToString();
            duty.Text= staffGrid.SelectedRows[0].Cells[3].Value.ToString();
            department.Text = staffGrid.SelectedRows[0].Cells[4].Value.ToString();
            mobilephone.Text= staffGrid.SelectedRows[0].Cells[5].Value.ToString().Trim();
            internalphone.Text= staffGrid.SelectedRows[0].Cells[6].Value.ToString();
            staffSave.Text = "Güncelle";
            button3.Text = "İptal";
            staffGrid.Enabled = false;
        }

        private void exportToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook calismaKitabi = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)calismaKitabi.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < staffGrid.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[StartRow, StartCol + j];
                myRange.Value2 = staffGrid.Columns[j].HeaderText;
            }

            StartRow++;

            for (int i = 0; i < staffGrid.Rows.Count; i++)
            {
                for (int j = 0; j < staffGrid.Columns.Count; j++)
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = staffGrid[j, i].Value == null ? "" : staffGrid[j, i].Value;
                    }
                    catch
                    {
                        MessageBox.Show("Bir hata ile karşılaşıldı. Excel'in lisanslı olup olmadığını kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ;
                    }
                }
            }
        }

        private void kullanıcıModGorunumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanıcı Moduna geçiş yapıyorsunuz", "Kısıtlı Kullanıcı...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userMod userModForm = new userMod();
            userModForm.Show();
            this.Hide();
        }


        private void refresh_Click(object sender, EventArgs e)
        {
            staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts)  ORDER BY staff.stafName ASC;;");
            quickSearch.Text = null;
            staffGroupEmpty(); //Textbox ve Combobox'ları temizliyoruz
            dutyLoad();
            departmentLoad();
        }

        private void veritabaniniYedekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            veriTabani.dbUpdate();
        }

        private void brimTanimlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            AddCourt AddCourtForm = new AddCourt();
            AddCourtForm.Show();
        }

        private void unvanTanimlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDuty AddDutyForm = new AddDuty();
            AddDutyForm.Show();
        }

        private void personel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
