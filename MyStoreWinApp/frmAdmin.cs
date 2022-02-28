using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmAdmin : Form
    {
        string connectionSTR = @"Data Source=KIETHACE140669\SQLEXPRESS;Initial Catalog=QuanLiQuanBar;Integrated Security=True";
        SqlConnection connection = null; 
        public frmAdmin()
        {
            InitializeComponent();
        }

        void loadAccountList()
        {
             new SqlConnection(connectionSTR);
        }
    }
}
