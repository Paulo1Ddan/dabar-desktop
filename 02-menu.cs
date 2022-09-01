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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void frmMenu_Load(object sender, EventArgs e)
        {
           pnlMenu.Location = new Point(this.Width / 2 - pnlMenu.Width / 2, this.Height / 2 - pnlMenu.Height / 2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var resultClose = MessageBox.Show("Deseja mesmo sair?", "SAIR/LOGOUT", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(resultClose == DialogResult.Yes)
            {
                Application.Exit();
            }else if(resultClose == DialogResult.No){
                new frmLogin().Show();
                Close();
            }
        }

        private void picClass_Click(object sender, EventArgs e)
        {
            new frmClass().Show();
            Hide();
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            new frmUsers().Show();
            Hide();
        }

        private void picCursos_Click(object sender, EventArgs e)
        {
            new frmCursos().Show();
            Hide();
        }

        private void picBlog_Click(object sender, EventArgs e)
        {
            new frmBlog().Show();
            Hide();
        }
    }
}
