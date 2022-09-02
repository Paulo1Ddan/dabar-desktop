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
    public partial class frmRegClass : Form
    {
        public frmRegClass()
        {
            InitializeComponent();
        }

        private void frmRegClass_Load(object sender, EventArgs e)
        {
            pnlClass.Location = new Point(this.Width / 2 - pnlClass.Width / 2, this.Height / 2 - pnlClass.Height / 2);
            txtName.Focus();
            mskDateReg.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if(Variables.function == "EDITAR")
            {
                ListSelectedTurma();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmClass().Show();
            Close();
        }

        private void mskDateReg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Variables.function != "EDITAR")
            {
                if(cmbStatus.Text == "Ativa")
                {
                    Variables.statusClass = "1";
                }
                else
                {
                    Variables.statusClass = "0";
                }

                if (cmbStatus.SelectedIndex >= 0)
                {
                    cmbAndamento.SelectedIndex = 0;
                }
            }
            else
            {
                if (cmbStatus.Text == "Ativa")
                {
                    Variables.statusClass = "1";
                }
                else
                {
                    Variables.statusClass = "0";
                }
            }
        }

        private void cmbAndamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Variables.function == "EDITAR")
            {
                cmbAndamento.Enabled = true;
            }

            if (cmbAndamento.Text == "Incompleta")
            {
                Variables.andamentoClass = "0";
            }
            else if(cmbAndamento.Text == "Completa")
            {
                Variables.statusClass = "1";
            }
            else
            {
                Variables.andamentoClass = "2";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblName.ForeColor = Color.Black;
            lblStatus.ForeColor = Color.Black;

            txtName.Clear();
            cmbStatus.SelectedIndex = -1;
            cmbAndamento.SelectedIndex = -1;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if(Variables.function != "EDITAR")
            {
                lblName.ForeColor = Color.Black;
                lblStatus.ForeColor = Color.Black;
                if (txtName.Text.Length < 1)
                {
                    lblName.ForeColor = Color.Red;
                    MessageBox.Show("Preencha o campo Nome da Turma");
                    txtName.Focus();
                }
                else if (cmbStatus.SelectedIndex == -1)
                {
                    lblStatus.ForeColor = Color.Red;
                    MessageBox.Show("Selecione um status válido");
                    cmbStatus.Focus();
                }
                else
                {
                    Variables.nameClass = txtName.Text;
                    Variables.dateRegClass = DateTime.Parse(mskDateReg.Text);

                    Insert();
                }
            }
            else
            {
                lblName.ForeColor = Color.Black;
                lblStatus.ForeColor = Color.Black;
                lblAndamento.ForeColor = Color.Black;
                if (txtName.Text.Length < 1)
                {
                    lblName.ForeColor = Color.Red;
                    MessageBox.Show("Preencha o campo Nome da Turma");
                    txtName.Focus();
                }
                else if (cmbStatus.SelectedIndex == -1)
                {
                    lblStatus.ForeColor = Color.Red;
                    MessageBox.Show("Selecione um status válido");
                    cmbStatus.Focus();
                }else if(cmbAndamento.SelectedIndex == -1)
                {
                    lblAndamento.ForeColor = Color.Red;
                    MessageBox.Show("Selecione um andamento de curso válido");
                    cmbAndamento.Focus();
                }
                else
                {
                    Variables.nameClass = txtName.Text;
                    Variables.dateRegClass = DateTime.Parse(mskDateReg.Text);

                    UpdateTurma();
                }
            }
            
        }

        //Insert
        private void Insert()
        {
            try
            {
                Database.StartConn();
                string query = "INSERT INTO turma (nomeTurma, statusTurma, andamentoTurma, dataCadTurma) VALUES(@name, @status, @andamento, @data)";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@name", Variables.nameClass);
                cmd.Parameters.AddWithValue("@status", Variables.statusClass);
                cmd.Parameters.AddWithValue("@andamento", Variables.andamentoClass);
                cmd.Parameters.AddWithValue("@data", Variables.dateRegClass.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Turma cadastrada com sucesso");
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados! \n\n Descrição: " + ex.Message);
            }


        }

        private void UpdateTurma()
        {
            try
            {
                Database.StartConn();
                string query = "UPDATE turma SET nomeTurma = @name, statusTurma = @status, andamentoTurma = @andamento WHERE idTurma = @id";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@name", Variables.nameClass);
                cmd.Parameters.AddWithValue("@status", Variables.statusClass);
                cmd.Parameters.AddWithValue("@andamento", Variables.andamentoClass);
                cmd.Parameters.AddWithValue("@id", Variables.idClass);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Turma Atuaizada com sucesso");
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados! \n\n Descrição: " + ex.Message);
            }


        }

        private void ListSelectedTurma()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM turma WHERE idTurma = @id";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@id", Variables.idClass);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Variables.nameClass = reader.GetString(1);
                    Variables.statusClass = reader.GetString(2);
                    Variables.andamentoClass = reader.GetString(3);
                    Variables.dateRegClass = DateTime.Parse(reader.GetString(4));

                    txtCod.Text = Variables.idClass.ToString();
                    txtName.Text = Variables.nameClass;
                    switch (Variables.statusClass)
                    {
                        case "1":
                            cmbStatus.Text = "Ativa";
                            break;
                        case "0":
                            cmbStatus.Text = "Inativa";
                            break;
                    }

                    switch (Variables.andamentoClass)
                    {
                        case "0":
                            cmbAndamento.Text = "Incompleta";
                            break;
                        case "1":
                            cmbAndamento.Text = "Completa";
                            break;
                        case "2":
                            cmbAndamento.Text = "Finalizada";
                            break;
                    }

                    mskDateReg.Text = Variables.dateRegClass.ToString("dd/MM/yyyy");
                }
                Database.CloseConn();

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao exibir dados da turma \n\n Descrição - " + ex.Message);
            }
        }
    }
}
