using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        

        private void login_click(object sender, EventArgs e)
        {
            Form form = new frmLogin();
            form.ShowDialog();
        }

        private void login_hover(object sender, EventArgs e)
        {
            pbLogin.Cursor = Cursors.Hand;
            lblLogin.Cursor = Cursors.Hand;
            pbSignIn.Cursor = Cursors.Hand;
            lblSignIn.Cursor = Cursors.Hand;
        }

        private void SignIn_click(object sender, EventArgs e)
        {
            Form form = new frmSignIn();
            form.ShowDialog();
        }
    }
}
