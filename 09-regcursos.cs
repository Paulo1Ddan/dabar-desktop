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
    public partial class frmRegCursos : Form
    {
        public frmRegCursos()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmCursos().Show();
            Close();
        }

        private void frmRegCursos_Load(object sender, EventArgs e)
        {
            pnlCursos.Location = new Point(this.Width /2 - pnlCursos.Width /2, this.Height /2 - pnlCursos.Height /2);
        }
    }
}
