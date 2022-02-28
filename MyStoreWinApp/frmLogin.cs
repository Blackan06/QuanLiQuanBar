using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmBarManagement frmBarManagement = new FrmBarManagement();
            this.Hide();
            frmBarManagement.ShowDialog();
            this.Show();
        }
    }
}
