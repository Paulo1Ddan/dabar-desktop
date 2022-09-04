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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            pnlUsers.Location = new Point(this.Width/2 - pnlUsers.Width/2, this.Height/2 - pnlUsers.Height/2);
            ListAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            new frmRegUsers().Show();
            Hide();
        }

        //Filter
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                Variables.nameUser = txtSearch.Text;
                if (chkActive.Checked)
                {
                    chkInactive.Checked = false;
                    chkInactive.Enabled = false;
                    ListActiveName();
                }
                else if (chkInactive.Checked)
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
                if(txtSearch.Text.Length > 0)
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

        //DB Methods
        //ListAll
        private void ListAll()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM usuariocompleto";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvUsers.DataSource = dt;
                dgvUsers.ClearSelection();
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
                string query = "DELETE FROM usuario WHERE idUsuario = @id";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@id", Variables.idClass);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MessageBox.Show("Usuario excluido com sucesso");

                dgvUsers.DataSource = dt;
                dgvUsers.ClearSelection();

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
                string query = "SELECT * FROM usuariocompleto WHERE `NOME DO USUARIO` LIKE '%" + Variables.nameUser + "%' OR `EMAIL DO USUARIO` LIKE '%" + Variables.nameUser + "%'";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvUsers.DataSource = dt;

                dgvUsers.ClearSelection();
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
                string query = "SELECT * FROM usuarioativo";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvUsers.DataSource = dt;

                dgvUsers.ClearSelection();
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
                string query = "SELECT * FROM usuarioativo WHERE `NOME DO USUARIO` LIKE '%" + Variables.nameUser + "%' OR `EMAIL DO USUARIO` LIKE '%" + Variables.nameUser + "%'";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvUsers.DataSource = dt;

                dgvUsers.ClearSelection();
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
                string query = "SELECT * FROM usuarioinativo";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvUsers.DataSource = dt;

                dgvUsers.ClearSelection();
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
                string query = "SELECT * FROM usuarioinativo WHERE `NOME DO USUARIO` LIKE '%" + Variables.nameUser + "%' OR `EMAIL DO USUARIO` LIKE '%" + Variables.nameUser + "%'";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvUsers.DataSource = dt;

                dgvUsers.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

    }
}
