using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            user_name.Text = "Enter your name";
            user_name.ForeColor = Color.Gray;
            user_surname.Text = "Enter your surname";
            user_surname.ForeColor = Color.Gray;
            login_field.Text = "Enter your Login";
            login_field.ForeColor = Color.Gray;
            passwd_field.Text = "Enter your password";
            passwd_field.UseSystemPasswordChar = false;
            passwd_field.ForeColor = Color.Gray;
        }

        private void user_name_Enter(object sender, EventArgs e)
        {
            if(user_name.Text == "Enter your name" && user_name.ForeColor == Color.Gray)
            {
                user_name.Text = "";
                user_name.ForeColor = Color.White;
            }
        }

        private void user_name_Leave(object sender, EventArgs e)
        {
            if(user_name.Text == "")
            {
                user_name.Text = "Enter your name";
                user_name.ForeColor = Color.Gray;
            }
        }

        private void user_surname_Enter(object sender, EventArgs e)
        {
            if (user_surname.Text == "Enter your surname" && user_surname.ForeColor == Color.Gray)
            {
                user_surname.Text = "";
                user_surname.ForeColor = Color.White;
            }
        }

        private void user_surname_Leave(object sender, EventArgs e)
        {
            if (user_surname.Text == "")
            {
                user_surname.Text = "Enter your surname";
                user_surname.ForeColor = Color.Gray;
            }
        }

        private void login_field_Enter(object sender, EventArgs e)
        {
            if (login_field.Text == "Enter your Login" && login_field.ForeColor == Color.Gray)
            {
                login_field.Text = "";
                login_field.ForeColor = Color.White;
            }
        }

        private void login_field_Leave(object sender, EventArgs e)
        {
            if (login_field.Text == "")
            {
                login_field.Text = "Enter your Login";
                login_field.ForeColor = Color.Gray;
            }
        }

        private void passwd_field_Enter(object sender, EventArgs e)
        {
            if (passwd_field.Text == "Enter your password" && passwd_field.ForeColor == Color.Gray)
            {
                passwd_field.Text = "";
                passwd_field.UseSystemPasswordChar = true;
                passwd_field.ForeColor = Color.White;
            }
        }

        private void passwd_field_Leave(object sender, EventArgs e)
        {
            if (passwd_field.Text == "")
            {
                passwd_field.Text = "Enter your password";
                passwd_field.ForeColor = Color.Gray;
                passwd_field.UseSystemPasswordChar = false;
            }
        }

        private void button_Resister_Click(object sender, EventArgs e)
        {
            if(user_name.Text == "Enter your name" && user_name.ForeColor == Color.Gray)
            {
                MessageBox.Show("Enter your name!");
                return;
            }

            if (user_surname.Text == "Enter your surname" && user_surname.ForeColor == Color.Gray)
            {
                MessageBox.Show("Enter your surname!");
                return;
            }

            if (login_field.Text == "Enter your Login" && login_field.ForeColor == Color.Gray)
            {
                MessageBox.Show("Enter your login!");
                return;
            }

            if (passwd_field.Text == "Enter your password" && passwd_field.ForeColor == Color.Gray)
            {
                MessageBox.Show("Enter your password!");
                return;
            }

            if (!isUserNew())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `surname`, `login`, `passwd`) VALUES (@name, @surname, @ul, @up)", db.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = user_name.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = user_surname.Text;
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login_field.Text;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passwd_field.Text;

            db.open_connnection();
            command.ExecuteNonQuery();
            db.close_connnection();
        }

        public Boolean isUserNew()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL AND `passwd`=@uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_field.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwd_field.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("There is already user with same login and password!\nEnter the other login and password!");
                return false;
            }
                
            else
            {
                MessageBox.Show("Rigistered Successfully!");
                return true;
            }
        }

        private void gotoLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void gotoLogin_MouseHover(object sender, EventArgs e)
        {
            gotoLogin.ForeColor = Color.RoyalBlue;
        }

        private void gotoLogin_MouseLeave(object sender, EventArgs e)
        {
            gotoLogin.ForeColor = Color.Green;
        }
    }
}
