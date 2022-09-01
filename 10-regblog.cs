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
    public partial class frmRegblog : Form
    {
        public frmRegblog()
        {
            InitializeComponent();
        }

        private void frmRegblog_Load(object sender, EventArgs e)
        {
            pnlBlog.Location = new Point(this.Width / 2 - pnlBlog.Width / 2, this.Height / 2 - pnlBlog.Height / 2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmBlog().Show();
            Close();
        }
    }
}
