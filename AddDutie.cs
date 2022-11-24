using Microsoft.Office.Interop.Excel;
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
    public partial class AddDuty : Form
    {
        public AddDuty()
        {
            InitializeComponent();
        }

        void dutyGridCaption()
        {
            dutyGrid.Columns[0].HeaderText = "Ünvan Id";
            dutyGrid.Columns[1].HeaderText = "Ünvan";            
        }

        private void AddDutie_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Kullanıcı: " + genel.enterUserName;

                //Brimlerin listesi CourtGrid'e yükleniyor.
                dutyGrid.DataSource = veriTabani.vtbaglan("Select duties.idduties, duties.duty from duties ORDER BY duties.duty ASC;");
                dutyGrid.Columns[0].HeaderText = "Ünvan";
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. Hata: " + hata);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try //Aşağıdaki kod kopyala yapıştır yapıldı. Düzeltilecek. uuu
            {
                string deleteDuty, deleteDutyId;
                string hataMesaji = null;
                Boolean deleteSuccessful = false;
                DialogResult yourChoice = new DialogResult();

                //Aşağıda tüm sicil, ad ve soyad değerlerini bir değişkene atıyoruz çünkü direk datagrid üzerinden aktarmaya çalıştığımda sağ tıklamada sorun oluştu. 
                //yanlış kayıt silme riskine karşı hepsini değişkene atayıp işlem yaptırdım
                deleteDuty = dutyGridGroupBox.Text;
                deleteDutyId= dutyIdLabel.Text;


                yourChoice = MessageBox.Show(deleteDuty + " ünvanını silmek istediğinize emin misiniz? DİKKAT BU ÜNVANI SİLERSENİZ BU ÜNVANA KAYITLI TÜM PERSONEL DE SİLİNECEKTİR!!!", "Ünvan Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (yourChoice == DialogResult.Yes)
                {
                    deleteSuccessful = veriTabani.veriSil("Delete From duties where duty like '" + deleteDuty + "'", ref hataMesaji);
                    if (deleteSuccessful)
                    {
                        duty.Text = "";
                        dutyGrid.DataSource = veriTabani.vtbaglan("Select * from duties ORDER BY duties.duty ASC;");
                        dutyGridCaption();
                        //Brim silindikten sonra bu brime kayıtlı kişiler siliniyor.
                        veriTabani.veriSil("Delete From staff where duty='" + deleteDutyId + "'", ref hataMesaji);
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

        private void dutyGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dutyGridGroupBox.Text = dutyGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            dutyIdLabel.Text = dutyGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            duty.Text = dutyGrid.Rows[e.RowIndex].Cells[1].Value.ToString();            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
