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
    public partial class Form1 : Form
    {

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

        public void HandleCustomEvent()
        {
            
        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Login_Button_Click(object sender, EventArgs e)
        {
            string user = UserName.Text;
            string psswd = Password.Text;
            bool user_excist = false;
            bool psswd_excist = false;
            bool allow = false;
            string allow_message;

            Database dbObj = new Database();
            string user_search_query = "Select * FROM AccountsData WHERE username = '" + UserName.Text + "'";
            string pass_search_query = "Select * FROM AccountsData WHERE password = '" + Password.Text + "'";

            SQLiteCommand userCMD = new SQLiteCommand(user_search_query, dbObj.myConnection);
            SQLiteCommand passCMD = new SQLiteCommand(pass_search_query, dbObj.myConnection);

            dbObj.OpenConnection();

            SQLiteDataReader user_result = userCMD.ExecuteReader();
            SQLiteDataReader pass_result = passCMD.ExecuteReader();

            if (user_result.Read().ToString() == "True" && pass_result.Read().ToString() == "True" )
            {
                user_excist = true;
                psswd_excist = true;
                allow = true;
            }
            if (!(allow))
            {
                allow_message = $"User {user} dosen't exist Or Password {psswd} incorrect";
                MessageBox.Show(allow_message, "Auth");
            }
            else
            {
                MessageBox.Show("Auth == OK", "Successfull login");
            }

            dbObj.CloseConnection();

        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
