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
    public partial class frmBlog : Form
    {
        public frmBlog()
        {
            InitializeComponent();
        }

        private void frmBlog_Load(object sender, EventArgs e)
        {
            pblBlog.Location = new Point(this.Width /2 - pblBlog.Width / 2, this.Height /2 - pblBlog.Height / 2);
            ListAll();
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

        private void dgvBlog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.selectedRow = Convert.ToInt32(e.RowIndex.ToString());
            if(Variables.selectedRow >= 0)
            {
                Variables.idBlog = Convert.ToInt32(dgvBlog[0, Variables.selectedRow].Value);
            }
        }

        private void dgvBlog_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvBlog.Sort(dgvBlog.Columns[0], ListSortDirection.Ascending);
            dgvBlog.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja mesmo excluir esse registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes && Variables.selectedRow >= 0)
            {
                Delete();
            }
        }
        //Filter
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length > 0)
            {
                Variables.titleBlog = txtSearch.Text;
                if (chkActive.Checked)
                {
                    chkInactive.Checked = false;
                    chkInactive.Enabled = false;
                    ListActiveName();

                }else if (chkInactive.Checked)
                {
                    chkActive.Checked = false;
                    chkActive.Enabled = false;
                    ListInactiveName();
                }
                else
                {
                    ListAllName();
                }
            }
            else
            {
                if (chkActive.Checked)
                {
                    chkInactive.Checked = false;
                    chkInactive.Enabled = false;
                    ListActive();

                }
                else if (chkInactive.Checked)
                {
                    chkActive.Checked = false;
                    chkActive.Enabled = false;
                    ListInactive();
                }
                else
                {
                    ListAll();
                }
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                chkInactive.Checked = false;
                chkInactive.Enabled = false;
                if (txtSearch.Text.Length > 0)
                {

                    ListActiveName();
                }
                else
                {
                    ListActive();
                }
            }
            else
            {
                chkInactive.Enabled = true;
                if (txtSearch.Text.Length > 0)
                {
                    ListAllName();
                }
                else
                {
                    ListAll();
                }
            }
        }

        private void chkInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInactive.Checked)
            {
                chkActive.Checked = false;
                chkActive.Enabled = false;
                if (txtSearch.Text.Length > 0)
                {

                    ListInactiveName();
                }
                else
                {
                    ListInactive();
                }
            }
            else
            {
                chkActive.Enabled = true;
                if (txtSearch.Text.Length > 0)
                {
                    ListAllName();
                }
                else
                {
                    ListAll();
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            chkActive.Checked = false;
            chkInactive.Checked = false;
        }

        //DB Methods
        //List All
        private void ListAll()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM artigocompleto";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBlog.DataSource = dt;

                dgvBlog.Columns[0].Width = 200;
                dgvBlog.Columns[1].Width = 200;
                dgvBlog.Columns[2].Width = 300;
                dgvBlog.Columns[3].Width = 300;
                dgvBlog.Columns[4].Width = 300;
                dgvBlog.Columns[5].Width = 150;

                dgvBlog.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Delete
        private void Delete()
        {
            try
            {
                Database.StartConn();
                string query = "DELETE FROM artigo WHERE idArtigo = @id";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@id", Variables.idBlog);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MessageBox.Show("Artigo excluido com sucesso");

                dgvBlog.DataSource = dt;
                dgvBlog.ClearSelection();

                Database.CloseConn();
                ListAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar turma \n\n Descrição - " + ex.Message);
            }
        }

        //ListAllName
        private void ListAllName()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM artigocompleto WHERE `TITULO` LIKE '%" + Variables.titleBlog + "%'";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBlog.DataSource = dt;

                dgvBlog.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ListActive
        private void ListActive()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM artigoativo";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBlog.DataSource = dt;

                dgvBlog.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //ListInactive
        private void ListInactive()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM artigoinativo";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBlog.DataSource = dt;

                dgvBlog.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //ListActiveName
        private void ListActiveName()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM artigoativo WHERE `TITULO` LIKE '%" + Variables.titleBlog + "%'";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBlog.DataSource = dt;

                dgvBlog.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //ListInactiveName
        private void ListInactiveName()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM artigoinativo WHERE `TITULO` LIKE '%" + Variables.titleBlog + "%'";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBlog.DataSource = dt;

                dgvBlog.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
