namespace PersonelTakip
{
    partial class userMod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.staffGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupRadioButton5 = new System.Windows.Forms.RadioButton();
            this.groupRadioButton4 = new System.Windows.Forms.RadioButton();
            this.groupRadioButton3 = new System.Windows.Forms.RadioButton();
            this.groupRadioButton2 = new System.Windows.Forms.RadioButton();
            this.groupRadioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchRadioButton4 = new System.Windows.Forms.RadioButton();
            this.searchRadioButton3 = new System.Windows.Forms.RadioButton();
            this.searchRadioButton2 = new System.Windows.Forms.RadioButton();
            this.searchRadioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.staffPicture = new System.Windows.Forms.PictureBox();
            this.staffGroupBox = new System.Windows.Forms.GroupBox();
            this.staffGrid = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.departmentRadioButton = new System.Windows.Forms.RadioButton();
            this.dutyRadioButton = new System.Windows.Forms.RadioButton();
            this.department = new System.Windows.Forms.ComboBox();
            this.duty = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dutyDepartmentradioButton = new System.Windows.Forms.RadioButton();
            this.staffGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffPicture)).BeginInit();
            this.staffGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffGroup
            // 
            this.staffGroup.Controls.Add(this.groupBox2);
            this.staffGroup.Controls.Add(this.groupBox1);
            this.staffGroup.Controls.Add(this.groupBox4);
            this.staffGroup.Controls.Add(this.groupBox3);
            this.staffGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.staffGroup.Location = new System.Drawing.Point(12, 12);
            this.staffGroup.Name = "staffGroup";
            this.staffGroup.Size = new System.Drawing.Size(1103, 218);
            this.staffGroup.TabIndex = 1;
            this.staffGroup.TabStop = false;
            this.staffGroup.Text = "Personel Bilgileri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupRadioButton5);
            this.groupBox1.Controls.Add(this.groupRadioButton4);
            this.groupBox1.Controls.Add(this.groupRadioButton3);
            this.groupBox1.Controls.Add(this.groupRadioButton2);
            this.groupBox1.Controls.Add(this.groupRadioButton1);
            this.groupBox1.Location = new System.Drawing.Point(430, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listeleme Kriteri";
            // 
            // groupRadioButton5
            // 
            this.groupRadioButton5.AutoSize = true;
            this.groupRadioButton5.Location = new System.Drawing.Point(6, 128);
            this.groupRadioButton5.Name = "groupRadioButton5";
            this.groupRadioButton5.Size = new System.Drawing.Size(133, 24);
            this.groupRadioButton5.TabIndex = 9;
            this.groupRadioButton5.Text = "Soyadına Göre";
            this.groupRadioButton5.UseVisualStyleBackColor = true;
            this.groupRadioButton5.CheckedChanged += new System.EventHandler(this.groupRadioButton5_CheckedChanged);
            // 
            // groupRadioButton4
            // 
            this.groupRadioButton4.AutoSize = true;
            this.groupRadioButton4.Checked = true;
            this.groupRadioButton4.Location = new System.Drawing.Point(6, 99);
            this.groupRadioButton4.Name = "groupRadioButton4";
            this.groupRadioButton4.Size = new System.Drawing.Size(102, 24);
            this.groupRadioButton4.TabIndex = 9;
            this.groupRadioButton4.TabStop = true;
            this.groupRadioButton4.Text = "İsme Göre";
            this.groupRadioButton4.UseVisualStyleBackColor = true;
            this.groupRadioButton4.CheckedChanged += new System.EventHandler(this.groupRadioButton4_CheckedChanged);
            // 
            // groupRadioButton3
            // 
            this.groupRadioButton3.AutoSize = true;
            this.groupRadioButton3.Location = new System.Drawing.Point(6, 73);
            this.groupRadioButton3.Name = "groupRadioButton3";
            this.groupRadioButton3.Size = new System.Drawing.Size(122, 24);
            this.groupRadioButton3.TabIndex = 9;
            this.groupRadioButton3.Text = "Ünvana Göre";
            this.groupRadioButton3.UseVisualStyleBackColor = true;
            this.groupRadioButton3.CheckedChanged += new System.EventHandler(this.groupRadioButton3_CheckedChanged);
            // 
            // groupRadioButton2
            // 
            this.groupRadioButton2.AutoSize = true;
            this.groupRadioButton2.Location = new System.Drawing.Point(6, 47);
            this.groupRadioButton2.Name = "groupRadioButton2";
            this.groupRadioButton2.Size = new System.Drawing.Size(108, 24);
            this.groupRadioButton2.TabIndex = 10;
            this.groupRadioButton2.Text = "Brime Göre";
            this.groupRadioButton2.UseVisualStyleBackColor = true;
            this.groupRadioButton2.CheckedChanged += new System.EventHandler(this.groupRadioButton2_CheckedChanged);
            // 
            // groupRadioButton1
            // 
            this.groupRadioButton1.AutoSize = true;
            this.groupRadioButton1.Location = new System.Drawing.Point(6, 25);
            this.groupRadioButton1.Name = "groupRadioButton1";
            this.groupRadioButton1.Size = new System.Drawing.Size(129, 24);
            this.groupRadioButton1.TabIndex = 11;
            this.groupRadioButton1.Text = "Gruplama Yok";
            this.groupRadioButton1.UseVisualStyleBackColor = true;
            this.groupRadioButton1.CheckedChanged += new System.EventHandler(this.groupRadioButton1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchBox);
            this.groupBox4.Controls.Add(this.searchRadioButton4);
            this.groupBox4.Controls.Add(this.searchRadioButton3);
            this.groupBox4.Controls.Add(this.searchRadioButton2);
            this.groupBox4.Controls.Add(this.searchRadioButton1);
            this.groupBox4.Location = new System.Drawing.Point(6, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 173);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Arama Kriteri";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(220, 114);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(189, 26);
            this.searchBox.TabIndex = 12;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchRadioButton4
            // 
            this.searchRadioButton4.AutoSize = true;
            this.searchRadioButton4.Checked = true;
            this.searchRadioButton4.Location = new System.Drawing.Point(6, 115);
            this.searchRadioButton4.Name = "searchRadioButton4";
            this.searchRadioButton4.Size = new System.Drawing.Size(107, 24);
            this.searchRadioButton4.TabIndex = 8;
            this.searchRadioButton4.TabStop = true;
            this.searchRadioButton4.Text = "Hızlı Arama";
            this.searchRadioButton4.UseVisualStyleBackColor = true;
            this.searchRadioButton4.CheckedChanged += new System.EventHandler(this.searchRadioButton4_CheckedChanged);
            // 
            // searchRadioButton3
            // 
            this.searchRadioButton3.AutoSize = true;
            this.searchRadioButton3.Location = new System.Drawing.Point(6, 85);
            this.searchRadioButton3.Name = "searchRadioButton3";
            this.searchRadioButton3.Size = new System.Drawing.Size(172, 24);
            this.searchRadioButton3.TabIndex = 9;
            this.searchRadioButton3.Text = "Soyada Göre Arama";
            this.searchRadioButton3.UseVisualStyleBackColor = true;
            this.searchRadioButton3.CheckedChanged += new System.EventHandler(this.searchRadioButton3_CheckedChanged);
            // 
            // searchRadioButton2
            // 
            this.searchRadioButton2.AutoSize = true;
            this.searchRadioButton2.Location = new System.Drawing.Point(6, 55);
            this.searchRadioButton2.Name = "searchRadioButton2";
            this.searchRadioButton2.Size = new System.Drawing.Size(153, 24);
            this.searchRadioButton2.TabIndex = 10;
            this.searchRadioButton2.Text = "İsme Göre Arama";
            this.searchRadioButton2.UseVisualStyleBackColor = true;
            this.searchRadioButton2.CheckedChanged += new System.EventHandler(this.searchRadioButton2_CheckedChanged);
            // 
            // searchRadioButton1
            // 
            this.searchRadioButton1.AutoSize = true;
            this.searchRadioButton1.Location = new System.Drawing.Point(6, 25);
            this.searchRadioButton1.Name = "searchRadioButton1";
            this.searchRadioButton1.Size = new System.Drawing.Size(155, 24);
            this.searchRadioButton1.TabIndex = 11;
            this.searchRadioButton1.Text = "Sicile Göre Arama";
            this.searchRadioButton1.UseVisualStyleBackColor = true;
            this.searchRadioButton1.CheckedChanged += new System.EventHandler(this.searchRadioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.staffPicture);
            this.groupBox3.Location = new System.Drawing.Point(946, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 169);
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
            this.staffPicture.Size = new System.Drawing.Size(125, 144);
            this.staffPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffPicture.TabIndex = 0;
            this.staffPicture.TabStop = false;
            // 
            // staffGroupBox
            // 
            this.staffGroupBox.Controls.Add(this.staffGrid);
            this.staffGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.staffGroupBox.Location = new System.Drawing.Point(12, 236);
            this.staffGroupBox.Name = "staffGroupBox";
            this.staffGroupBox.Size = new System.Drawing.Size(1103, 363);
            this.staffGroupBox.TabIndex = 2;
            this.staffGroupBox.TabStop = false;
            this.staffGroupBox.Text = "Personeller";
            // 
            // staffGrid
            // 
            this.staffGrid.AllowUserToAddRows = false;
            this.staffGrid.AllowUserToDeleteRows = false;
            this.staffGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.staffGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.staffGrid.Location = new System.Drawing.Point(6, 25);
            this.staffGrid.MultiSelect = false;
            this.staffGrid.Name = "staffGrid";
            this.staffGrid.ReadOnly = true;
            this.staffGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffGrid.Size = new System.Drawing.Size(1081, 332);
            this.staffGrid.TabIndex = 11;
            this.staffGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffGrid_RowEnter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1127, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(196, 17);
            this.toolStripStatusLabel1.Text = "Eskişehir Bilgi İşlem Müdürlüğü";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::PersonelTakip.Properties.Resources.lock1;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.department);
            this.groupBox2.Controls.Add(this.duty);
            this.groupBox2.Controls.Add(this.dutyDepartmentradioButton);
            this.groupBox2.Controls.Add(this.departmentRadioButton);
            this.groupBox2.Controls.Add(this.dutyRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(649, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 176);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gruplama Kriteri";
            // 
            // departmentRadioButton
            // 
            this.departmentRadioButton.AutoSize = true;
            this.departmentRadioButton.Location = new System.Drawing.Point(6, 55);
            this.departmentRadioButton.Name = "departmentRadioButton";
            this.departmentRadioButton.Size = new System.Drawing.Size(108, 24);
            this.departmentRadioButton.TabIndex = 10;
            this.departmentRadioButton.Text = "Brime Göre";
            this.departmentRadioButton.UseVisualStyleBackColor = true;
            // 
            // dutyRadioButton
            // 
            this.dutyRadioButton.AutoSize = true;
            this.dutyRadioButton.Checked = true;
            this.dutyRadioButton.Location = new System.Drawing.Point(6, 25);
            this.dutyRadioButton.Name = "dutyRadioButton";
            this.dutyRadioButton.Size = new System.Drawing.Size(122, 24);
            this.dutyRadioButton.TabIndex = 11;
            this.dutyRadioButton.TabStop = true;
            this.dutyRadioButton.Text = "Ünvana Göre";
            this.dutyRadioButton.UseVisualStyleBackColor = true;
            // 
            // department
            // 
            this.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(143, 58);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(144, 28);
            this.department.TabIndex = 13;
            // 
            // duty
            // 
            this.duty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.duty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duty.FormattingEnabled = true;
            this.duty.Location = new System.Drawing.Point(143, 24);
            this.duty.Name = "duty";
            this.duty.Size = new System.Drawing.Size(144, 28);
            this.duty.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dutyDepartmentradioButton
            // 
            this.dutyDepartmentradioButton.AutoSize = true;
            this.dutyDepartmentradioButton.Location = new System.Drawing.Point(6, 85);
            this.dutyDepartmentradioButton.Name = "dutyDepartmentradioButton";
            this.dutyDepartmentradioButton.Size = new System.Drawing.Size(114, 24);
            this.dutyDepartmentradioButton.TabIndex = 10;
            this.dutyDepartmentradioButton.Text = "Ünvan+Brim";
            this.dutyDepartmentradioButton.UseVisualStyleBackColor = true;
            // 
            // userMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 679);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.staffGroupBox);
            this.Controls.Add(this.staffGroup);
            this.Name = "userMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userMod";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userMod_FormClosed);
            this.Load += new System.EventHandler(this.userMod_Load);
            this.staffGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffPicture)).EndInit();
            this.staffGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox staffGroup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox staffGroupBox;
        private System.Windows.Forms.DataGridView staffGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton groupRadioButton3;
        private System.Windows.Forms.RadioButton groupRadioButton2;
        private System.Windows.Forms.RadioButton groupRadioButton1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.RadioButton searchRadioButton4;
        private System.Windows.Forms.RadioButton searchRadioButton3;
        private System.Windows.Forms.RadioButton searchRadioButton2;
        private System.Windows.Forms.RadioButton searchRadioButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RadioButton groupRadioButton5;
        private System.Windows.Forms.RadioButton groupRadioButton4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.PictureBox staffPicture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton departmentRadioButton;
        private System.Windows.Forms.RadioButton dutyRadioButton;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.ComboBox duty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton dutyDepartmentradioButton;
    }
}