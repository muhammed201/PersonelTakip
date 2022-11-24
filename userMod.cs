using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class userMod : Form
    {
        public userMod()
        {
            InitializeComponent();
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

        void dutyLoad()
        {
            //Önceden başka tabloda tanımlanan görevler Combobox'a aktarılıyor
            //duty comboboxını temizliyoruz yoksa tekrara düşüyor.
            duty.Items.Clear();
            duty.Text = String.Empty;
            MySqlConnection conn = new MySqlConnection("server=" + veriTabani.serverInfo[0] + "; port=" + veriTabani.serverInfo[1] + "; user id=" + veriTabani.serverInfo[2] + ";password=" + veriTabani.serverInfo[3] + ";persistsecurityinfo=True;database=" + veriTabani.serverInfo[4] + "");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("Select duty from duties GROUP BY duty ORDER BY duty ASC", conn);
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

            MySqlCommand cmd = new MySqlCommand("Select court from courts GROUP BY court ORDER BY court ASC", conn);
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

        private void userMod_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Kullanıcı: " + genel.enterUserName;

                //Personel listesi staffGrid'e yükleniyor.
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts)  ORDER BY staff.stafName ASC;");
                staffGridCaption();
                dutyLoad();
                departmentLoad();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. Hata: " + hata);
            }
        }

        private void searchRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(searchRadioButton1.Checked==true)
            {
                searchBox.Location = new Point(searchBox.Location.X, searchRadioButton1.Location.Y);
                searchBox.Text = String.Empty;
                searchBox.Focus();
            }
        }

        private void searchRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (searchRadioButton2.Checked == true)
            {
                searchBox.Location = new Point(searchBox.Location.X, searchRadioButton2.Location.Y);
                searchBox.Text = String.Empty;
                searchBox.Focus();
            }
        }

        private void searchRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (searchRadioButton3.Checked == true)
            {
                searchBox.Location = new Point(searchBox.Location.X, searchRadioButton3.Location.Y);
                searchBox.Text = String.Empty;
                searchBox.Focus();
            }
        }

        private void searchRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (searchRadioButton4.Checked == true)
            {
                searchBox.Location = new Point(searchBox.Location.X, searchRadioButton4.Location.Y);
                searchBox.Text = String.Empty;
                searchBox.Focus();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchRadioButton1.Checked)
            {
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts) WHERE (staff.registration like '%" + searchBox.Text.TrimEnd() + "%') ORDER BY staff.stafName ASC;");
            }
            else if (searchRadioButton2.Checked)
            {
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts) WHERE (staff.stafName like '%" + searchBox.Text.TrimEnd() + "%') ORDER BY staff.stafName ASC;");
            }
            else if (searchRadioButton3.Checked)
            {
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts) WHERE (staff.stafSurname like '%" + searchBox.Text.TrimEnd() + "%') ORDER BY staff.stafName ASC;");

            }
            else if (searchRadioButton4.Checked)
            {
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts) WHERE (staff.registration like '%" + searchBox.Text.TrimEnd() + "%') or (staff.stafName like '%" + searchBox.Text.TrimEnd() + "%') or (staff.stafSurname like '%" + searchBox.Text.TrimEnd() + "%') or (staff.duty like '%" + searchBox.Text.TrimEnd() + "%') or (staff.department like '%" + searchBox.Text.TrimEnd() + "%') or (staff.mobilephone like '%" + searchBox.Text.TrimEnd() + "%') or (staff.internalphone like '%" + searchBox.Text.TrimEnd() + "%') ORDER BY staff.stafName ASC;");
            }
            else
            {
                ;
            }
        }

        private void groupRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (groupRadioButton1.Checked)
            {
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts)  ORDER BY staff.idstaff DESC;");
            }
        }

        private void groupRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (groupRadioButton2.Checked)
            {
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts)  ORDER BY courts.court ASC;");
            }
        }

        private void groupRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (groupRadioButton3.Checked)
            {
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts)  ORDER BY duties.duty ASC;");
            }
        }

        private void groupRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (groupRadioButton4.Checked)
            {
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts)  ORDER BY staff.stafName ASC;");
            }
        }

        private void groupRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (groupRadioButton5.Checked)
            {
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts)  ORDER BY staff.stafSurname ASC;");
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (genel.enterUserAuthority == "admin") //Admin kullanıcı açılmış ise 
            {
                MessageBox.Show("Admin Moduna geçiş yapıyorsunuz", "Tam Yetki...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                personel personelForm = new personel();
                personelForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bu modu sadece admin yetkisi olan kullanıcılar kullanabilir", "Giriş İzni Yok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userMod_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void staffGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            staffGroupBox.Text = staffGrid.Rows[e.RowIndex].Cells[0].Value.ToString() + "   " + staffGrid.Rows[e.RowIndex].Cells[1].Value.ToString() + "   " + staffGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dutyRadioButton.Checked)
            {
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts) WHERE duties.duty like '" + duty.Text + "' ORDER BY staff.stafName ASC;");
            }
            else if (departmentRadioButton.Checked)
            {
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts) WHERE courts.court like '" + department.Text + "'  ORDER BY staff.stafName ASC;");
            }
            else if(dutyDepartmentradioButton.Checked)
            {
                staffGrid.DataSource = veriTabani.vtbaglan("Select staff.registration, staff.stafName, staff.stafSurname, duties.duty, courts.court, staff.mobilephone, staff.internalphone from ((bilgiislem.staff INNER JOIN bilgiislem.duties ON staff.duty = duties.idduties) INNER JOIN bilgiislem.courts ON staff.department = courts.idcourts) WHERE duties.duty like '" + duty.Text + "' AND courts.court like '" + department.Text + "'  ORDER BY staff.stafName ASC;");
            }
            else
            {
                ;
            }
        }
    }
}
