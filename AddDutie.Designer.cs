namespace PersonelTakip
{
    partial class AddDuty
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.duty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dutyGridGroupBox = new System.Windows.Forms.GroupBox();
            this.dutyGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dutyIdLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.dutyGridGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dutyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.duty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ünvanlar";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Düzenle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // duty
            // 
            this.duty.Location = new System.Drawing.Point(78, 34);
            this.duty.Name = "duty";
            this.duty.Size = new System.Drawing.Size(228, 26);
            this.duty.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ünvan";
            // 
            // dutyGridGroupBox
            // 
            this.dutyGridGroupBox.Controls.Add(this.dutyGrid);
            this.dutyGridGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dutyGridGroupBox.Location = new System.Drawing.Point(336, 12);
            this.dutyGridGroupBox.Name = "dutyGridGroupBox";
            this.dutyGridGroupBox.Size = new System.Drawing.Size(272, 363);
            this.dutyGridGroupBox.TabIndex = 3;
            this.dutyGridGroupBox.TabStop = false;
            this.dutyGridGroupBox.Text = "Ünvan Listesi";
            // 
            // dutyGrid
            // 
            this.dutyGrid.AllowUserToAddRows = false;
            this.dutyGrid.AllowUserToDeleteRows = false;
            this.dutyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dutyGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dutyGrid.Location = new System.Drawing.Point(6, 25);
            this.dutyGrid.MultiSelect = false;
            this.dutyGrid.Name = "dutyGrid";
            this.dutyGrid.ReadOnly = true;
            this.dutyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dutyGrid.Size = new System.Drawing.Size(254, 332);
            this.dutyGrid.TabIndex = 12;
            this.dutyGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dutyGrid_RowEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PersonelTakip.Properties.Resources.adaletBakanligiLogo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dutyIdLabel
            // 
            this.dutyIdLabel.AutoSize = true;
            this.dutyIdLabel.Location = new System.Drawing.Point(573, 378);
            this.dutyIdLabel.Name = "dutyIdLabel";
            this.dutyIdLabel.Size = new System.Drawing.Size(35, 13);
            this.dutyIdLabel.TabIndex = 5;
            this.dutyIdLabel.Text = "label6";
            // 
            // AddDuty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 398);
            this.Controls.Add(this.dutyIdLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dutyGridGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDuty";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ünvan Ekle";
            this.Load += new System.EventHandler(this.AddDutie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dutyGridGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dutyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox duty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox dutyGridGroupBox;
        private System.Windows.Forms.DataGridView dutyGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dutyIdLabel;
    }
}