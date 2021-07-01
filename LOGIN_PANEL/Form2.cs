using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LOGIN_PANEL
{
    public partial class Form2 : Form
    {
        
        static void __init__()
        {
            Database databaseObject = new Database();
            String query = "CREATE TABLE IF NOT EXISTS AccountsData (username VARCHAR(255), password VARCHER(255), email VARCHER(255))";

            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            databaseObject.OpenConnection();
            myCommand.ExecuteNonQuery();

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            string Username = UserName.Text;
            string password = Password.Text;
            string Email = User_Email.Text;

            if (password != RePassword.Text)
            {
                MessageBox.Show("Password Not Match !", "Pwd Match Error");
            }

            Database databaseObj = new Database();
            string query = "INSERT INTO AccountsData (`username`, `password`, `email`) VALUES (@username, @password, @email)";

            SQLiteCommand InsertCMD = new SQLiteCommand(query, databaseObj.myConnection);
            databaseObj.OpenConnection();

            InsertCMD.Parameters.AddWithValue("@username", Username);
            InsertCMD.Parameters.AddWithValue("@password", password);
            InsertCMD.Parameters.AddWithValue("@email", Email);
            InsertCMD.ExecuteNonQuery();

            databaseObj.CloseConnection();
            MessageBox.Show("Your Account Created Successfully", "New Member");

            // fields restore
            UserName.Text = "Username";
            Password.Text = "Password";
            User_Email.Text = "Email";
            RePassword.Text = "Repeat Password";

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            __init__();
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if(UserName.Text.Trim() == "" || UserName.Text == null)
            {
                UserName.Text = "Username";
            }
        }

        private void User_Email_Leave(object sender, EventArgs e)
        {
            if (User_Email.Text.Trim() == "" || User_Email.Text == null)
            {
                User_Email.Text = "Email";
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text.Trim() == "" || Password.Text == null)
            {
                Password.Text = "Password";
            }
        }

        private void RePassword_Leave(object sender, EventArgs e)
        {
            if (RePassword.Text.Trim() == "" || RePassword.Text == null)
            {
                RePassword.Text = "Repeat Password";
            }
        }

        private void UserName_Enter(object sender, EventArgs e)
        {
            if (UserName.Text.Trim() != "" || UserName.Text != null)
            {
                UserName.Text = "";
            }
        }

        private void User_Email_Enter(object sender, EventArgs e)
        {
            if (User_Email.Text.Trim() != "" || User_Email.Text != null)
            {
                User_Email.Text = "";
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text.Trim() != "" || Password.Text != null)
            {
                Password.Text = "";
            }
        }

        private void RePassword_Enter(object sender, EventArgs e)
        {
            if (RePassword.Text.Trim() != "" || RePassword.Text != null)
            {
                RePassword.Text = "";
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
