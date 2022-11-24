namespace PersonelTakip
{
    partial class personel
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel));
            this.staffGroup = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.staffSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.staffPicture = new System.Windows.Forms.PictureBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.duty = new System.Windows.Forms.ComboBox();
            this.internalphone = new System.Windows.Forms.TextBox();
            this.mobilephone = new System.Windows.Forms.TextBox();
            this.stafSurname = new System.Windows.Forms.TextBox();
            this.stafName = new System.Windows.Forms.TextBox();
            this.registration = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.staffGroupBox = new System.Windows.Forms.GroupBox();
            this.staffGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.quickSearch = new System.Windows.Forms.TextBox();
            this.exportToExcel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.veritabaniniYedekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıModGorunumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanimlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brimTanimlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unvanTanimlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh = new System.Windows.Forms.Button();
            this.staffGroup.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffPicture)).BeginInit();
            this.staffGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffGroup
            // 
            this.staffGroup.Controls.Add(this.groupBox4);
            this.staffGroup.Controls.Add(this.groupBox3);
            this.staffGroup.Controls.Add(this.department);
            this.staffGroup.Controls.Add(this.duty);
            this.staffGroup.Controls.Add(this.internalphone);
            this.staffGroup.Controls.Add(this.mobilephone);
            this.staffGroup.Controls.Add(this.stafSurname);
            this.staffGroup.Controls.Add(this.stafName);
            this.staffGroup.Controls.Add(this.registration);
            this.staffGroup.Controls.Add(this.label7);
            this.staffGroup.Controls.Add(this.label6);
            this.staffGroup.Controls.Add(this.label5);
            this.staffGroup.Controls.Add(this.label4);
            this.staffGroup.Controls.Add(this.label3);
            this.staffGroup.Controls.Add(this.label2);
            this.staffGroup.Controls.Add(this.label1);
            this.staffGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.staffGroup.Location = new System.Drawing.Point(21, 42);
            this.staffGroup.Name = "staffGroup";
            this.staffGroup.Size = new System.Drawing.Size(1103, 218);
            this.staffGroup.TabIndex = 0;
            this.staffGroup.TabStop = false;
            this.staffGroup.Text = "Personel Kayıt";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.staffSave);
            this.groupBox4.Location = new System.Drawing.Point(149, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 64);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // staffSave
            // 
            this.staffSave.Location = new System.Drawing.Point(6, 15);
            this.staffSave.Name = "staffSave";
            this.staffSave.Size = new System.Drawing.Size(111, 40);
            this.staffSave.TabIndex = 7;
            this.staffSave.Text = "Kaydet";
            this.staffSave.UseVisualStyleBackColor = true;
            this.staffSave.Click += new System.EventHandler(this.staffSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.staffPicture);
            this.groupBox3.Location = new System.Drawing.Point(860, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 165);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resim";
            // 
            // staffPicture
            // 
            this.staffPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffPicture.ErrorImage = global::PersonelTakip.Properties.Resources.noImg;
            this.staffPicture.Image = global::PersonelTakip.Properties.Resources.noImg;
            this.staffPicture.Location = new System.Drawing.Point(3, 22);
            this.staffPicture.Name = "staffPicture";
            this.staffPicture.Size = new System.Drawing.Size(211, 140);
            this.staffPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffPicture.TabIndex = 1;
            this.staffPicture.TabStop = false;
            // 
            // department
            // 
            this.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(588, 75);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(239, 28);
            this.department.TabIndex = 4;
            // 
            // duty
            // 
            this.duty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.duty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duty.FormattingEnabled = true;
            this.duty.Location = new System.Drawing.Point(588, 32);
            this.duty.Name = "duty";
            this.duty.Size = new System.Drawing.Size(239, 28);
            this.duty.TabIndex = 3;
            // 
            // internalphone
            // 
            this.internalphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.internalphone.Location = new System.Drawing.Point(588, 171);
            this.internalphone.MaxLength = 10;
            this.internalphone.Name = "internalphone";
            this.internalphone.Size = new System.Drawing.Size(243, 26);
            this.internalphone.TabIndex = 6;
            // 
            // mobilephone
            // 
            this.mobilephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mobilephone.Location = new System.Drawing.Point(588, 121);
            this.mobilephone.Name = "mobilephone";
            this.mobilephone.Size = new System.Drawing.Size(243, 26);
            this.mobilephone.TabIndex = 5;
            this.mobilephone.TextChanged += new System.EventHandler(this.mobilephone_TextChanged);
            this.mobilephone.Leave += new System.EventHandler(this.mobilephone_Leave);
            // 
            // stafSurname
            // 
            this.stafSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stafSurname.Location = new System.Drawing.Point(149, 105);
            this.stafSurname.MaxLength = 45;
            this.stafSurname.Name = "stafSurname";
            this.stafSurname.Size = new System.Drawing.Size(243, 26);
            this.stafSurname.TabIndex = 2;
            this.stafSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stafSurname_KeyPress);
            // 
            // stafName
            // 
            this.stafName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stafName.Location = new System.Drawing.Point(149, 67);
            this.stafName.MaxLength = 45;
            this.stafName.Name = "stafName";
            this.stafName.Size = new System.Drawing.Size(243, 26);
            this.stafName.TabIndex = 1;
            this.stafName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stafName_KeyPress);
            // 
            // registration
            // 
            this.registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registration.Location = new System.Drawing.Point(149, 27);
            this.registration.MaxLength = 10;
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(243, 26);
            this.registration.TabIndex = 0;
            this.registration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registration_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(454, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dahili Nu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(454, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cep Telefonu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(454, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Görev Yeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(454, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Görevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sicil";
            // 
            // staffGroupBox
            // 
            this.staffGroupBox.Controls.Add(this.staffGrid);
            this.staffGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.staffGroupBox.Location = new System.Drawing.Point(21, 275);
            this.staffGroupBox.Name = "staffGroupBox";
            this.staffGroupBox.Size = new System.Drawing.Size(1103, 363);
            this.staffGroupBox.TabIndex = 1;
            this.staffGroupBox.TabStop = false;
            this.staffGroupBox.Text = "Personeller";
            // 
            // staffGrid
            // 
            this.staffGrid.AllowUserToAddRows = false;
            this.staffGrid.AllowUserToDeleteRows = false;
            this.staffGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.staffGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.staffGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.staffGrid.Location = new System.Drawing.Point(6, 25);
            this.staffGrid.MultiSelect = false;
            this.staffGrid.Name = "staffGrid";
            this.staffGrid.ReadOnly = true;
            this.staffGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffGrid.Size = new System.Drawing.Size(1081, 332);
            this.staffGrid.TabIndex = 11;
            this.staffGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffGrid_RowEnter);
            this.staffGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.staffGrid_MouseDown_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateStaff,
            this.deleteStaff,
            this.cancelSelection});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // updateStaff
            // 
            this.updateStaff.Name = "updateStaff";
            this.updateStaff.Size = new System.Drawing.Size(148, 22);
            this.updateStaff.Text = "Güncelle";
            this.updateStaff.Click += new System.EventHandler(this.updateStaff_Click_1);
            // 
            // deleteStaff
            // 
            this.deleteStaff.Name = "deleteStaff";
            this.deleteStaff.Size = new System.Drawing.Size(148, 22);
            this.deleteStaff.Text = "Sil";
            this.deleteStaff.Click += new System.EventHandler(this.deleteStaff_Click);
            // 
            // cancelSelection
            // 
            this.cancelSelection.Name = "cancelSelection";
            this.cancelSelection.Size = new System.Drawing.Size(148, 22);
            this.cancelSelection.Text = "Seçimi İptal Et";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(727, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Hızlı Arama";
            // 
            // quickSearch
            // 
            this.quickSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quickSearch.Location = new System.Drawing.Point(822, 13);
            this.quickSearch.Name = "quickSearch";
            this.quickSearch.Size = new System.Drawing.Size(243, 26);
            this.quickSearch.TabIndex = 9;
            this.quickSearch.TextChanged += new System.EventHandler(this.quickSearch_TextChanged);
            // 
            // exportToExcel
            // 
            this.exportToExcel.Location = new System.Drawing.Point(1019, 638);
            this.exportToExcel.Name = "exportToExcel";
            this.exportToExcel.Size = new System.Drawing.Size(89, 26);
            this.exportToExcel.TabIndex = 11;
            this.exportToExcel.Text = "Excel\'e Aktar";
            this.toolTip1.SetToolTip(this.exportToExcel, "Verileri excele aktarmak için lisanslı bir Office 2010 yada üzeri sürüm kullanmal" +
        "ısınız. Lisanssız \r\nve belirtilen sürüm dışı bir kullanım dışında olası bir hata" +
        " almanız yüksektir.");
            this.exportToExcel.UseVisualStyleBackColor = true;
            this.exportToExcel.Click += new System.EventHandler(this.exportToExcel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 681);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1157, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(197, 17);
            this.toolStripStatusLabel1.Text = "Eskişehir Bilgi İşlem Müdürlüğü";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veritabaniniYedekleToolStripMenuItem,
            this.kullanıcıModGorunumuToolStripMenuItem,
            this.tanimlamaToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::PersonelTakip.Properties.Resources.lock1;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // veritabaniniYedekleToolStripMenuItem
            // 
            this.veritabaniniYedekleToolStripMenuItem.Name = "veritabaniniYedekleToolStripMenuItem";
            this.veritabaniniYedekleToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.veritabaniniYedekleToolStripMenuItem.Text = "Veritabanını Yedekle";
            this.veritabaniniYedekleToolStripMenuItem.Click += new System.EventHandler(this.veritabaniniYedekleToolStripMenuItem_Click);
            // 
            // kullanıcıModGorunumuToolStripMenuItem
            // 
            this.kullanıcıModGorunumuToolStripMenuItem.Name = "kullanıcıModGorunumuToolStripMenuItem";
            this.kullanıcıModGorunumuToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.kullanıcıModGorunumuToolStripMenuItem.Text = "Kullanıcı Mod Görünümü";
            this.kullanıcıModGorunumuToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıModGorunumuToolStripMenuItem_Click);
            // 
            // tanimlamaToolStripMenuItem
            // 
            this.tanimlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brimTanimlamaToolStripMenuItem,
            this.unvanTanimlamaToolStripMenuItem});
            this.tanimlamaToolStripMenuItem.Name = "tanimlamaToolStripMenuItem";
            this.tanimlamaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.tanimlamaToolStripMenuItem.Text = "Tanımlama";
            // 
            // brimTanimlamaToolStripMenuItem
            // 
            this.brimTanimlamaToolStripMenuItem.Name = "brimTanimlamaToolStripMenuItem";
            this.brimTanimlamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brimTanimlamaToolStripMenuItem.Text = "Brim Tanımlama";
            this.brimTanimlamaToolStripMenuItem.Click += new System.EventHandler(this.brimTanimlamaToolStripMenuItem_Click);
            // 
            // unvanTanimlamaToolStripMenuItem
            // 
            this.unvanTanimlamaToolStripMenuItem.Name = "unvanTanimlamaToolStripMenuItem";
            this.unvanTanimlamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unvanTanimlamaToolStripMenuItem.Text = "Ünvan Tanımlama";
            this.unvanTanimlamaToolStripMenuItem.Click += new System.EventHandler(this.unvanTanimlamaToolStripMenuItem_Click);
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.Location = new System.Drawing.Point(1066, 10);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 29);
            this.refresh.TabIndex = 10;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 703);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.exportToExcel);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.staffGroupBox);
            this.Controls.Add(this.staffGroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quickSearch);
            this.Name = "personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Takip";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.personel_FormClosed);
            this.Load += new System.EventHandler(this.personel_Load);
            this.staffGroup.ResumeLayout(false);
            this.staffGroup.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffPicture)).EndInit();
            this.staffGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox staffGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.ComboBox duty;
        private System.Windows.Forms.TextBox internalphone;
        private System.Windows.Forms.TextBox mobilephone;
        private System.Windows.Forms.TextBox stafSurname;
        private System.Windows.Forms.TextBox stafName;
        private System.Windows.Forms.TextBox registration;
        private System.Windows.Forms.GroupBox staffGroupBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button staffSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quickSearch;
        private System.Windows.Forms.DataGridView staffGrid;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateStaff;
        private System.Windows.Forms.ToolStripMenuItem deleteStaff;
        private System.Windows.Forms.ToolStripMenuItem cancelSelection;
        private System.Windows.Forms.Button exportToExcel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıModGorunumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veritabaniniYedekleToolStripMenuItem;
        private System.Windows.Forms.PictureBox staffPicture;
        private System.Windows.Forms.ToolStripMenuItem tanimlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brimTanimlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unvanTanimlamaToolStripMenuItem;
    }
}

