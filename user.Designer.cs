namespace PersonelTakip
{
    partial class user
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
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.enterSystem = new System.Windows.Forms.Button();
            this.cancelSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userName.Location = new System.Drawing.Point(183, 26);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(138, 29);
            this.userName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı Şifresi";
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userPassword.Location = new System.Drawing.Point(183, 61);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '*';
            this.userPassword.Size = new System.Drawing.Size(138, 29);
            this.userPassword.TabIndex = 1;
            this.userPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userPassword_KeyDown);
            // 
            // enterSystem
            // 
            this.enterSystem.Location = new System.Drawing.Point(183, 96);
            this.enterSystem.Name = "enterSystem";
            this.enterSystem.Size = new System.Drawing.Size(67, 36);
            this.enterSystem.TabIndex = 2;
            this.enterSystem.Text = "Giriş";
            this.enterSystem.UseVisualStyleBackColor = true;
            this.enterSystem.Click += new System.EventHandler(this.enterSystem_Click);
            // 
            // cancelSystem
            // 
            this.cancelSystem.Location = new System.Drawing.Point(254, 96);
            this.cancelSystem.Name = "cancelSystem";
            this.cancelSystem.Size = new System.Drawing.Size(67, 36);
            this.cancelSystem.TabIndex = 3;
            this.cancelSystem.Text = "İptal";
            this.cancelSystem.UseVisualStyleBackColor = true;
            this.cancelSystem.Click += new System.EventHandler(this.cancelSystem_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 149);
            this.Controls.Add(this.cancelSystem);
            this.Controls.Add(this.enterSystem);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "user";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Button enterSystem;
        private System.Windows.Forms.Button cancelSystem;
    }
}