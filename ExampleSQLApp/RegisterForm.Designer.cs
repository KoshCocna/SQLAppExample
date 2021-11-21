
namespace ExampleSQLApp
{
    partial class RegisterForm
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
            this.button_Resister = new System.Windows.Forms.Button();
            this.login_field = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_surname = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwd_field = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gotoLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resister";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Resister
            // 
            this.button_Resister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(134)))));
            this.button_Resister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.button_Resister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Resister.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.button_Resister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Resister.Location = new System.Drawing.Point(138, 451);
            this.button_Resister.Name = "button_Resister";
            this.button_Resister.Size = new System.Drawing.Size(181, 60);
            this.button_Resister.TabIndex = 5;
            this.button_Resister.Text = "Rigister";
            this.button_Resister.UseVisualStyleBackColor = false;
            this.button_Resister.Click += new System.EventHandler(this.button_Resister_Click);
            // 
            // login_field
            // 
            this.login_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.login_field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_field.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_field.ForeColor = System.Drawing.SystemColors.Window;
            this.login_field.Location = new System.Drawing.Point(91, 297);
            this.login_field.Name = "login_field";
            this.login_field.Size = new System.Drawing.Size(290, 38);
            this.login_field.TabIndex = 6;
            this.login_field.Enter += new System.EventHandler(this.login_field_Enter);
            this.login_field.Leave += new System.EventHandler(this.login_field_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.gotoLogin);
            this.panel1.Controls.Add(this.user_surname);
            this.panel1.Controls.Add(this.user_name);
            this.panel1.Controls.Add(this.button_Resister);
            this.panel1.Controls.Add(this.passwd_field);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.login_field);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 593);
            this.panel1.TabIndex = 1;
            // 
            // user_surname
            // 
            this.user_surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.user_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_surname.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_surname.ForeColor = System.Drawing.SystemColors.Window;
            this.user_surname.Location = new System.Drawing.Point(91, 220);
            this.user_surname.Name = "user_surname";
            this.user_surname.Size = new System.Drawing.Size(290, 38);
            this.user_surname.TabIndex = 7;
            this.user_surname.Enter += new System.EventHandler(this.user_surname_Enter);
            this.user_surname.Leave += new System.EventHandler(this.user_surname_Leave);
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.user_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_name.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_name.ForeColor = System.Drawing.SystemColors.Window;
            this.user_name.Location = new System.Drawing.Point(91, 139);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(290, 38);
            this.user_name.TabIndex = 2;
            this.user_name.Enter += new System.EventHandler(this.user_name_Enter);
            this.user_name.Leave += new System.EventHandler(this.user_name_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 100);
            this.panel2.TabIndex = 0;
            // 
            // passwd_field
            // 
            this.passwd_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.passwd_field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwd_field.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwd_field.ForeColor = System.Drawing.SystemColors.Window;
            this.passwd_field.Location = new System.Drawing.Point(91, 378);
            this.passwd_field.Name = "passwd_field";
            this.passwd_field.Size = new System.Drawing.Size(290, 38);
            this.passwd_field.TabIndex = 4;
            this.passwd_field.UseSystemPasswordChar = true;
            this.passwd_field.Enter += new System.EventHandler(this.passwd_field_Enter);
            this.passwd_field.Leave += new System.EventHandler(this.passwd_field_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExampleSQLApp.Properties.Resources.passwd;
            this.pictureBox2.Location = new System.Drawing.Point(25, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExampleSQLApp.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(25, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gotoLogin
            // 
            this.gotoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gotoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gotoLogin.ForeColor = System.Drawing.Color.Green;
            this.gotoLogin.Location = new System.Drawing.Point(158, 535);
            this.gotoLogin.Name = "gotoLogin";
            this.gotoLogin.Size = new System.Drawing.Size(140, 36);
            this.gotoLogin.TabIndex = 8;
            this.gotoLogin.Text = "Go to Login";
            this.gotoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gotoLogin.Click += new System.EventHandler(this.gotoLogin_Click);
            this.gotoLogin.MouseLeave += new System.EventHandler(this.gotoLogin_MouseLeave);
            this.gotoLogin.MouseHover += new System.EventHandler(this.gotoLogin_MouseHover);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 593);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Resister;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox login_field;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox user_surname;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox passwd_field;
        private System.Windows.Forms.Label gotoLogin;
    }
}