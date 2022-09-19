using MySql.Data.MySqlClient;
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
    public partial class frmCadMatricula : Form
    {
        public frmCadMatricula()
        {
            InitializeComponent();
        }

        private void frmCadMatricula_Load(object sender, EventArgs e)
        {
            pnlClass.Location = new Point(this.Width /2 - pnlClass.Width / 2, this.Height /2 - pnlClass.Height / 2);
            if(Variables.function == "CADASTRAR")
            {
                ListUser();
                ListCursos();
                cmbStatus.SelectedIndex = 0;
                Variables.statusMatricula = 1;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void ListUser()
        {
            Database.StartConn();
            string query = "SELECT idUsuario, nomeUsuario FROM usuario WHERE statusUsuario = 1 AND catUsuario = 0";
            MySqlCommand cmd = new MySqlCommand(query, Database.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmbUsers.DataSource = dt;
            cmbUsers.DisplayMember = "nomeUsuario";
            cmbUsers.ValueMember = "idUsuario";
            cmbUsers.SelectedIndex = -1;
            Database.CloseConn();
        }

        private void ListCursos()
        {
            Database.StartConn();
            string query = "SELECT idCurso, curso FROM curso WHERE statusCurso = 1";
            MySqlCommand cmd = new MySqlCommand(query, Database.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmbCursos.DataSource = dt;
            cmbCursos.DisplayMember = "curso";
            cmbCursos.ValueMember = "idCurso";
            cmbCursos.SelectedIndex = -1;
            Database.CloseConn();
        }

        private void InsertMatricula()
        {
            try
            {
                Database.StartConn();
                string query = "INSERT INTO matricula(idCurso, idUsuario, statusMatricula) VALUES (@idcurso, @iduser, @status)";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@idcurso", Variables.idCurso);
                cmd.Parameters.AddWithValue("@iduser", Variables.idUser);
                cmd.Parameters.AddWithValue("@status", Variables.statusMatricula);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Matricula adicionada a lista de espera");
                new frmMenu().Show();
                Close();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if(cmbUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um usuario");
            }else if(cmbCursos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um curso");
            }else if(cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um status");
            }
            else
            {
                Variables.idUser = Convert.ToInt32(cmbUsers.SelectedValue);
                Variables.idCurso = Convert.ToInt32(cmbCursos.SelectedValue);
                InsertMatricula();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
