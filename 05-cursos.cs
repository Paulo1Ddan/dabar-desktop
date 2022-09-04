using System;
using MySql.Data.MySqlClient;
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
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }

        private void frmCursos_Load(object sender, EventArgs e)
        {
            pnlCursos.Location = new Point(this.Width / 2 - pnlCursos.Width / 2, this.Height / 2 - pnlCursos.Height / 2);
            ListAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            new frmRegCursos().Show();
            Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
        //DB Methods
        //LoadData
        private void ListAll()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM cursocompleto";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvCursos.DataSource = dt;

                dgvCursos.ClearSelection();
                Database.CloseConn();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
