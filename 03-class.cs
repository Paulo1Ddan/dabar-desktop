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
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            pnlClass.Location = new Point(this.Width/2 - pnlClass.Width/2, this.Height/2 - pnlClass.Height/2);
            ListAll();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir esse registro?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes && Variables.selectedRow >= 0)
            {
                Delete();
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            new frmRegClass().Show();
            Hide();
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.selectedRow = int.Parse(e.RowIndex.ToString());
            if(Variables.selectedRow >= 0)
            {
                Variables.idClass = Convert.ToInt32(dgvClass[0, Variables.selectedRow].Value);
            }
        }

        private void dgvClass_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvClass.Sort(dgvClass.Columns[0], ListSortDirection.Ascending);
            dgvClass.ClearSelection();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Variables.function = "EDITAR";
            if(Variables.selectedRow >= 0)
            {
                new frmRegClass().Show();
                Hide();
            }
        }

        //Filter
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length > 0){
                Variables.nameClass = txtSearch.Text;
                if (chkActive.Checked)
                {
                    chkInactived.Checked = false;
                    chkInactived.Enabled = false;
                    ListActiveNameClass();
                }
                else if (chkInactived.Checked)
                {
                    chkActive.Checked = false;
                    chkActive.Enabled = false;
                    ListInactiveNameClass();
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
                    chkInactived.Checked = false;
                    chkInactived.Enabled = false;
                    ListActiveClass();
                }
                else if (chkInactived.Checked)
                {
                    chkActive.Checked = false;
                    chkActive.Enabled = false;
                    ListInactiveClass();
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
                chkInactived.Checked = false;
                chkInactived.Enabled = false;
                if(txtSearch.Text.Length > 0)
                {
                    ListActiveNameClass();
                }
                else
                {
                    ListActiveClass();
                }
            }
            else
            {
                chkInactived.Enabled = true;
                if (txtSearch.Text.Length > 0)
                {
                    Variables.nameClass = txtSearch.Text;
                    ListAllName();
                }
                else
                {
                    ListAll();
                }
            }
        }
        private void chkInactived_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInactived.Checked)
            {
                chkActive.Checked = false;
                chkActive.Enabled = false;
                if (txtSearch.Text.Length > 0)
                {
                    ListInactiveNameClass();
                }
                else
                {
                    ListInactiveClass();
                }
            }
            else
            {
                chkActive.Enabled = true;
                if (txtSearch.Text.Length > 0)
                {
                    Variables.nameClass = txtSearch.Text;
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
            chkInactived.Checked = false;
            chkActive.Checked = false;
            cmbAndamento.SelectedIndex = -1;
            Variables.andamentoClass = null;
            ListAll();
        }

        private void cmbAndamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAndamento.SelectedIndex > -1)
            {
                Variables.andamentoClass = cmbAndamento.Text;

                ListAndamentoClass();
            }
        }

        //DB Methods
        //ListAll
        private void ListAll()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM turmascompleto";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvClass.DataSource = dt;
                dgvClass.Columns[0].Width = 205;
                dgvClass.Columns[1].Width = 205;
                dgvClass.Columns[2].Width = 206;
                dgvClass.Columns[3].Width = 206;
                dgvClass.Columns[4].Width = 206;
                dgvClass.ClearSelection();
                Database.CloseConn();
            }catch (Exception ex)
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
                string query = "DELETE FROM turma WHERE idTurma = @id";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@id", Variables.idClass);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MessageBox.Show("Turma excluida com sucesso");

                dgvClass.DataSource = dt;
                dgvClass.ClearSelection();

                Database.CloseConn();
                ListAll();

            }catch (Exception ex)
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
                string query = "SELECT * FROM turmascompleto WHERE `TURMA` LIKE '%"+ Variables.nameClass+"%'";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvClass.DataSource = dt;
                dgvClass.Columns[0].Width = 205;
                dgvClass.Columns[1].Width = 205;
                dgvClass.Columns[2].Width = 206;
                dgvClass.Columns[3].Width = 206;
                dgvClass.Columns[4].Width = 206;

                dgvClass.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //ListActiveClass
        private void ListActiveClass()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM turmasativo";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvClass.DataSource = dt;
                dgvClass.Columns[0].Width = 205;
                dgvClass.Columns[1].Width = 205;
                dgvClass.Columns[2].Width = 206;
                dgvClass.Columns[3].Width = 206;
                dgvClass.Columns[4].Width = 206;

                dgvClass.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //ListActiveNameClass
        private void ListActiveNameClass()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM turmasativo WHERE `TURMA` LIKE '%" + Variables.nameClass + "%'";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvClass.DataSource = dt;
                dgvClass.Columns[0].Width = 205;
                dgvClass.Columns[1].Width = 205;
                dgvClass.Columns[2].Width = 206;
                dgvClass.Columns[3].Width = 206;
                dgvClass.Columns[4].Width = 206;

                dgvClass.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //ListInactiveClass
        private void ListInactiveClass()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM turmasinativo";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvClass.DataSource = dt;
                dgvClass.Columns[0].Width = 205;
                dgvClass.Columns[1].Width = 205;
                dgvClass.Columns[2].Width = 206;
                dgvClass.Columns[3].Width = 206;
                dgvClass.Columns[4].Width = 206;

                dgvClass.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //ListInactiveNameClass
        private void ListInactiveNameClass()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM turmasinativo WHERE `TURMA` LIKE '%"+Variables.nameClass+"%'";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvClass.DataSource = dt;
                dgvClass.Columns[0].Width = 205;
                dgvClass.Columns[1].Width = 205;
                dgvClass.Columns[2].Width = 206;
                dgvClass.Columns[3].Width = 206;
                dgvClass.Columns[4].Width = 206;

                dgvClass.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ListAndamentoClass()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM turmascompleto WHERE `ANDAMENTO` = @andamento COLLATE  utf8mb4_unicode_ci";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@andamento", Variables.andamentoClass);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvClass.DataSource = dt;
                dgvClass.Columns[0].Width = 205;
                dgvClass.Columns[1].Width = 205;
                dgvClass.Columns[2].Width = 206;
                dgvClass.Columns[3].Width = 206;
                dgvClass.Columns[4].Width = 206;

                dgvClass.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
