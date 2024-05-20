using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uni_Companion
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();
        }

        private void pictureSignIn_Click(object sender, EventArgs e)
        {
            Sign_In signin = new Sign_In();
            this.Hide();
            signin.Show();
        }

        private void pictureSignUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.Show();
        }
    }
}
