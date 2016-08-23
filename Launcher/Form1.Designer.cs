namespace Launcher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.go = new System.Windows.Forms.Button();
            this.game = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registration = new System.Windows.Forms.Button();
            this.ConnectUser = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.checkBoxlogin = new System.Windows.Forms.CheckBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.go.Location = new System.Drawing.Point(398, 37);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(105, 26);
            this.go.TabIndex = 2;
            this.go.Text = "Войти";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.Transparent;
            this.game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game.Enabled = false;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.game.Location = new System.Drawing.Point(12, 328);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(116, 58);
            this.game.TabIndex = 4;
            this.game.Text = "ИГРАТЬ";
            this.game.UseVisualStyleBackColor = false;
            this.game.Click += new System.EventHandler(this.game_Click);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(205, 46);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 17);
            this.password.TabIndex = 1;
            // 
            // login
            // 
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(80, 46);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 17);
            this.login.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(202, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // registration
            // 
            this.registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration.Location = new System.Drawing.Point(398, 69);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(105, 26);
            this.registration.TabIndex = 3;
            this.registration.Text = "Регистрация";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // ConnectUser
            // 
            this.ConnectUser.AutoSize = true;
            this.ConnectUser.BackColor = System.Drawing.Color.Transparent;
            this.ConnectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ConnectUser.Location = new System.Drawing.Point(30, 36);
            this.ConnectUser.Name = "ConnectUser";
            this.ConnectUser.Size = new System.Drawing.Size(169, 20);
            this.ConnectUser.TabIndex = 8;
            this.ConnectUser.Text = "Добро пожаловать";
            this.ConnectUser.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(77, 66);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 9;
            // 
            // checkBoxlogin
            // 
            this.checkBoxlogin.AutoSize = true;
            this.checkBoxlogin.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxlogin.FlatAppearance.BorderSize = 0;
            this.checkBoxlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.checkBoxlogin.Location = new System.Drawing.Point(311, 46);
            this.checkBoxlogin.Name = "checkBoxlogin";
            this.checkBoxlogin.Size = new System.Drawing.Size(81, 17);
            this.checkBoxlogin.TabIndex = 10;
            this.checkBoxlogin.Text = "запомнить";
            this.checkBoxlogin.UseVisualStyleBackColor = false;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackgroundImage = global::Launcher.Properties.Resources.off;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonClose.Location = new System.Drawing.Point(577, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(45, 48);
            this.ButtonClose.TabIndex = 11;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources._111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 398);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.checkBoxlogin);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.ConnectUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.go);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.password);
            this.Controls.Add(this.game);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Launcher_FormClosing);
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button game;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Label ConnectUser;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.CheckBox checkBoxlogin;
        private System.Windows.Forms.Button ButtonClose;
    }
}

