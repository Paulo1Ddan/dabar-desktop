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
    public partial class frmBlog : Form
    {
        public frmBlog()
        {
            InitializeComponent();
        }

        private void frmBlog_Load(object sender, EventArgs e)
        {
            pblBlog.Location = new Point(this.Width /2 - pblBlog.Width / 2, this.Height /2 - pblBlog.Height / 2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            new frmRegblog().Show();
            Hide();
        }
    }
}
