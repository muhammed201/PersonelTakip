namespace PersonelTakip
{
    partial class AddCourt
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
            this.courtsgroupBox = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.built = new System.Windows.Forms.ComboBox();
            this.note = new System.Windows.Forms.TextBox();
            this.floor = new System.Windows.Forms.TextBox();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.court = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.courtGridGroupBox = new System.Windows.Forms.GroupBox();
            this.courtGrid = new System.Windows.Forms.DataGridView();
            this.courtIdLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.courtsgroupBox.SuspendLayout();
            this.courtGridGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // courtsgroupBox
            // 
            this.courtsgroupBox.Controls.Add(this.button4);
            this.courtsgroupBox.Controls.Add(this.button3);
            this.courtsgroupBox.Controls.Add(this.button2);
            this.courtsgroupBox.Controls.Add(this.button1);
            this.courtsgroupBox.Controls.Add(this.built);
            this.courtsgroupBox.Controls.Add(this.note);
            this.courtsgroupBox.Controls.Add(this.floor);
            this.courtsgroupBox.Controls.Add(this.roomNumber);
            this.courtsgroupBox.Controls.Add(this.court);
            this.courtsgroupBox.Controls.Add(this.label5);
            this.courtsgroupBox.Controls.Add(this.label4);
            this.courtsgroupBox.Controls.Add(this.label3);
            this.courtsgroupBox.Controls.Add(this.label2);
            this.courtsgroupBox.Controls.Add(this.label1);
            this.courtsgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.courtsgroupBox.Location = new System.Drawing.Point(12, 12);
            this.courtsgroupBox.Name = "courtsgroupBox";
            this.courtsgroupBox.Size = new System.Drawing.Size(397, 365);
            this.courtsgroupBox.TabIndex = 0;
            this.courtsgroupBox.TabStop = false;
            this.courtsgroupBox.Text = "Brimler";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // built
            // 
            this.built.FormattingEnabled = true;
            this.built.Items.AddRange(new object[] {
            "Ana Bina",
            "Ek Bina Valilik",
            "Ek Bina SGK"});
            this.built.Location = new System.Drawing.Point(163, 138);
            this.built.Name = "built";
            this.built.Size = new System.Drawing.Size(192, 28);
            this.built.TabIndex = 2;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(163, 172);
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(203, 119);
            this.note.TabIndex = 1;
            // 
            // floor
            // 
            this.floor.Location = new System.Drawing.Point(163, 106);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(192, 26);
            this.floor.TabIndex = 1;
            // 
            // roomNumber
            // 
            this.roomNumber.Location = new System.Drawing.Point(163, 71);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(192, 26);
            this.roomNumber.TabIndex = 1;
            // 
            // court
            // 
            this.court.Location = new System.Drawing.Point(163, 34);
            this.court.Name = "court";
            this.court.Size = new System.Drawing.Size(192, 26);
            this.court.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Not";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bina Konum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oda Nu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brim Adı";
            // 
            // courtGridGroupBox
            // 
            this.courtGridGroupBox.Controls.Add(this.courtGrid);
            this.courtGridGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.courtGridGroupBox.Location = new System.Drawing.Point(425, 12);
            this.courtGridGroupBox.Name = "courtGridGroupBox";
            this.courtGridGroupBox.Size = new System.Drawing.Size(648, 363);
            this.courtGridGroupBox.TabIndex = 1;
            this.courtGridGroupBox.TabStop = false;
            this.courtGridGroupBox.Text = "Brimlerin Listesi";
            // 
            // courtGrid
            // 
            this.courtGrid.AllowUserToAddRows = false;
            this.courtGrid.AllowUserToDeleteRows = false;
            this.courtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.courtGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.courtGrid.Location = new System.Drawing.Point(6, 25);
            this.courtGrid.MultiSelect = false;
            this.courtGrid.Name = "courtGrid";
            this.courtGrid.ReadOnly = true;
            this.courtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courtGrid.Size = new System.Drawing.Size(636, 332);
            this.courtGrid.TabIndex = 12;
            this.courtGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.courtGrid_RowEnter);
            this.courtGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.courtGrid_MouseDown);
            // 
            // courtIdLabel
            // 
            this.courtIdLabel.AutoSize = true;
            this.courtIdLabel.Location = new System.Drawing.Point(1032, 372);
            this.courtIdLabel.Name = "courtIdLabel";
            this.courtIdLabel.Size = new System.Drawing.Size(35, 13);
            this.courtIdLabel.TabIndex = 2;
            this.courtIdLabel.Text = "label6";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddCourt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 409);
            this.Controls.Add(this.courtIdLabel);
            this.Controls.Add(this.courtGridGroupBox);
            this.Controls.Add(this.courtsgroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCourt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCourt_FormClosed);
            this.Load += new System.EventHandler(this.AddCourt_Load);
            this.courtsgroupBox.ResumeLayout(false);
            this.courtsgroupBox.PerformLayout();
            this.courtGridGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox courtsgroupBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox built;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.TextBox floor;
        private System.Windows.Forms.TextBox roomNumber;
        private System.Windows.Forms.TextBox court;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox courtGridGroupBox;
        private System.Windows.Forms.DataGridView courtGrid;
        private System.Windows.Forms.Label courtIdLabel;
        private System.Windows.Forms.Button button4;
    }
}