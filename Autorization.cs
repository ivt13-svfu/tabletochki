using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buildings
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        string login_status;

        private void button1_Click(object sender, EventArgs e)
        {
            /*//database
             * string myConnection = "localhost; username=admin;password=password"; */
            //b11/SQLExpress - DataBase
        /*ПРИМЕР*/

            if (auth_login.Text == "login" && auth_pass.Text == "parol")
            {
                login_status = "0"; //статус профиля
                new MainMenu().Show();
                
            }
            else
            {
                label3.Visible = true;
            }
        }
    }
}
