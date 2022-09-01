using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cetdabar
{
    public partial class frmRegUsers : Form
    {
        public frmRegUsers()
        {
            InitializeComponent();
        }

        private void frmRegUsers_Load(object sender, EventArgs e)
        {
            pnlUsers.Location = new Point(this.Width/2 - pnlUsers.Width/2, this.Height/2 - pnlUsers.Height/2);
            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmUsers().Show();
            Close();
        }
    }
}
