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
    public partial class frmAprovarEspera : Form
    {
        public frmAprovarEspera()
        {
            InitializeComponent();
        }

        private void frmAprovarEspera_Load(object sender, EventArgs e)
        {
            pnlClass.Location = new Point(this.Width / 2 - pnlClass.Width / 2, this.Height / 2 - pnlClass.Height / 2);
            SelectUser();
            SelectCurso();
            LoadTurma();

            if(Variables.function == "EDITAR")
            {
                lblClass.Text = "Atualizar matricula";
                LoadTurma();
                LoadData();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void SelectUser()
        {
            Database.StartConn();
            string query = "SELECT nomeUsuario, b.idUsuario FROM matricula INNER JOIN usuario b USING (idUsuario) WHERE idMatricula = @id";
            MySqlCommand cmd = new MySqlCommand(query, Database.conn);
            cmd.Parameters.AddWithValue("@id", Variables.idMatricula);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Variables.nameUser = reader.GetString(0);
                Variables.idUser = reader.GetInt32(1);

                txtNameUser.Text = Variables.nameUser;
            }
        }

        private void SelectCurso()
        {
            Database.StartConn();
            string query = "SELECT curso, b.idCurso FROM matricula INNER JOIN curso b USING (idCurso) WHERE idMatricula = @id";
            MySqlCommand cmd = new MySqlCommand(query, Database.conn);
            cmd.Parameters.AddWithValue("@id", Variables.idMatricula);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Variables.nomeCurso = reader.GetString(0);
                Variables.idCurso = reader.GetInt32(1);

                txtCurso.Text = Variables.nomeCurso;
            }
        }

        private void LoadTurma()
        {
            Database.StartConn();
            string query = "SELECT idTurma, nomeTurma FROM turma";
            MySqlCommand cmd = new MySqlCommand(query, Database.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmbTurma.DataSource = dt;
            cmbTurma.DisplayMember = "nomeTurma";
            cmbTurma.ValueMember = "idTurma";
            cmbTurma.SelectedIndex = -1;
            Database.CloseConn();
        }

        private void LoadData()
        {
            Database.StartConn();
            string query = "SELECT nomeTurma, statusMatriculado, d.nomeUsuario, c.curso, c.idCurso, d.idUsuario FROM matriculado INNER JOIN turma USING(idTurma) INNER JOIN curso c USING (idCurso) INNER JOIN usuario d USING (idUsuario) WHERE idMatriculado = @id";
            MySqlCommand cmd = new MySqlCommand(query, Database.conn);
            cmd.Parameters.AddWithValue("@id", Variables.idMatricula);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Variables.nameClass = reader.GetString(0);
                Variables.statusMatricula = reader.GetInt32(1);
                Variables.nameUser = reader.GetString(2);
                Variables.nomeCurso = reader.GetString(3);

                Variables.idCurso = reader.GetInt32(4);
                Variables.idUser = reader.GetInt32(5);

                cmbTurma.Text = Variables.nameClass;
                txtNameUser.Text = Variables.nameUser;
                txtCurso.Text = Variables.nomeCurso;
                txtCod.Text = Variables.idMatricula.ToString();

                switch (Variables.statusMatricula)
                {
                    case 0:
                        cmbStatus.Text = "Cancelada";
                        break;
                    case 1:
                        cmbStatus.Text = "Aprovada";
                        break ;
                    case 2:
                        cmbStatus.Text = "Pendente";
                        break;
                    case 3:
                        cmbStatus.Text = "Finalizada";
                        break;
                }
            }

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbStatus.Text == "Aprovada")
            {
                Variables.statusMatricula = 1;
            }
            else if(cmbStatus.Text == "Pendente")
            {
                Variables.statusMatricula = 2;
            }else if(cmbStatus.Text == "Finalizada")
            {
                Variables.statusMatricula = 3;
            }
            else
            {
                Variables.statusMatricula = 0;
            }
        }

        private void cmbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Variables.idClass = Convert.ToInt32(cmbTurma.SelectedValue);
            if(Variables.function != "EDITAR")
            {
                InsertNewMatricula();
                new frmMenu().Show();
                Close();

            }
            else
            {
                UpdateMatricula();
            }
        }

        private void InsertNewMatricula()
        {
            try
            {
                Database.StartConn();
                string query = "INSERT INTO matriculado (idCurso, idTurma, idUsuario, idMatricula, statusMatriculado) VALUES (@idcurso, @idturma, @idusuario, @idmatricula, @status)";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@idcurso", Variables.idCurso);
                cmd.Parameters.AddWithValue("@idturma", Variables.idClass);
                cmd.Parameters.AddWithValue("@idusuario", Variables.idUser);
                cmd.Parameters.AddWithValue("@idmatricula", Variables.idMatricula);
                cmd.Parameters.AddWithValue("@status", Variables.statusMatricula);
                cmd.ExecuteNonQuery();
                UpdateOldMatricula();
                MessageBox.Show("Matricula aprovada com sucesso");
                Database.CloseConn();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateOldMatricula()
        {
            try
            {
                Database.StartConn();
                string query = "UPDATE matricula SET statusMatricula = @status WHERE idMatricula = @id";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@id", Variables.idMatricula);
                cmd.Parameters.AddWithValue("@status", 0);
                cmd.ExecuteNonQuery();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateMatricula()
        {
            try
            {
                Database.StartConn();
                string query = "UPDATE matriculado SET statusMatriculado = @status, idTurma = @idturma WHERE idMatriculado = @id";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@status", Variables.statusMatricula);
                cmd.Parameters.AddWithValue("@idturma", Variables.idClass);
                cmd.Parameters.AddWithValue("@id", Variables.idMatricula);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Matricula atualizada com sucesso");
                new frmMenu().Show();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNameUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
