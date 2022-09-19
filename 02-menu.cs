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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        //Form Load
        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlMenu.Location = new Point(this.Width / 2 - pnlMenu.Width / 2, this.Height / 2 - pnlMenu.Height / 2);
            lblUser.Text = User.username;
            timer1.Start();
            cmbMatricula.SelectedIndex = 0;
        }

        //Btn Close
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

        private void lblUser_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void dgvMatricula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.selectedRow = Convert.ToInt32(e.RowIndex.ToString());
            if (Variables.selectedRow >= 0) {
                Variables.idMatricula = Convert.ToInt32(dgvMatricula[0, Variables.selectedRow].Value);
            }
        }

        private void dgvMatricula_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvMatricula.Sort(dgvMatricula.Columns[0], ListSortDirection.Ascending);
            dgvMatricula.ClearSelection();
        }


        private void ListEmEspera()
        {
            Database.StartConn();
            string query = "SELECT idMatricula AS `COD. ESPERA`, curso AS `NOME DO CURSO`, nomeUsuario AS `UASUARIO`, dataMatricula AS `DT. ESPERA`, CASE WHEN statusMatricula = 0 THEN 'Inativa' WHEN statusMatricula = 1 THEN 'Espera' END AS 'STATUS ESPERA' FROM matricula INNER JOIN curso USING (idCurso) INNER JOIN usuario USING (idUsuario) WHERE statusMatricula = 1";
            MySqlCommand cmd = new MySqlCommand(query, Database.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgvMatricula.DataSource = dt;
            dgvMatricula.ClearSelection();
            Database.CloseConn();
        }

        private void ListMatriculados()
        {
            Database.StartConn();
            string query = "SELECT idMatriculado AS `COD. MATRICULA`, curso AS `NOME DO CURSO`, nomeUsuario AS `USUARIO`, nomeTurma AS 'TURMA', dataMatriculado AS `DT. MATRICULA`, CASE WHEN statusMatriculado = 0 THEN 'Cancelada' WHEN statusMatriculado = 1 THEN 'Aprovada' WHEN statusMatriculado = 2 THEN 'Pendente' ELSE 'Finalizada' END AS 'STATUS MATRICULA' FROM matriculado INNER JOIN curso USING (idCurso) INNER JOIN usuario USING (idUsuario) INNER JOIN turma USING(idTurma)";
            MySqlCommand cmd = new MySqlCommand(query, Database.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgvMatricula.DataSource = dt;
            dgvMatricula.ClearSelection();
            Database.CloseConn();
        }

        private void cmbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMatricula.SelectedIndex == 0)
            {
                ListEmEspera();
                btnRegUpd.Text = "Aprovar";
            }else if(cmbMatricula.SelectedIndex == 1)
            {
                ListMatriculados();
                btnRegUpd.Text = "Alterar";
            }
        }

        private void btnRegUpd_Click(object sender, EventArgs e)
        {
            if(cmbMatricula.SelectedIndex == 0 && Variables.selectedRow >= 0)
            {
                Variables.function = "CADASTRAR";
                new frmAprovarEspera().Show();
                Hide();
            }
            else if(cmbMatricula.SelectedIndex == 1 && Variables.selectedRow >= 0)
            {
                Variables.function = "EDITAR";
                new frmAprovarEspera().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }

        private void btnRegCad_Click(object sender, EventArgs e)
        {
            Variables.function = "CADASTRAR";
            new frmCadMatricula().Show();
            Hide();
        }
    }
}
