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
    public partial class frmAccountProfile : Form
    {
        public frmAccountProfile()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
