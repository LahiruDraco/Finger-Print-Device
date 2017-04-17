using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            error.Text = "";
        }

        public void LoginButton_Click(object sender, EventArgs e)
        {
            if (accessCode.Text.Equals("123"))
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
                error.Text = "";
            }
            else if (accessCode.Text.Equals(string.Empty))
            {
                error.Text = "* Enter access code";
            }
            else
            {
                error.Text = "* Login Error check access code";
            }
        }

    }
}
