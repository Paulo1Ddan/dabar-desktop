using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
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
            if(Variables.function == "EDITAR")
            {
                lblCurso.Text = "Editar Curso";
                LoadData();
            }
        }

        //Img
        private bool ValidateFTP()
        {
            if (string.IsNullOrEmpty(Variables.addrFTP) || string.IsNullOrEmpty(Variables.userFTP) || string.IsNullOrEmpty(Variables.passFTP))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public byte[] GetImgToByte(string filePathFTP)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(Variables.userFTP, Variables.passFTP);
            byte[] imgToByte = ftpClient.DownloadData(filePathFTP);
            return imgToByte;
        }

        public static Bitmap BytesToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bmp = new Bitmap(mStream, false);
            return bmp;
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdImg = new OpenFileDialog();
                ofdImg.Multiselect = false;
                ofdImg.FileName = "";
                ofdImg.InitialDirectory = @"C:";
                ofdImg.Title = "Selecione um arquivo";
                ofdImg.Filter = "JPG ou PNG (*.png, *.jpg)|*.png;*.jpg";
                ofdImg.CheckFileExists = true;
                ofdImg.CheckPathExists = true;
                ofdImg.RestoreDirectory = false;

                DialogResult result = ofdImg.ShowDialog();
                picImg.Image = Image.FromFile(ofdImg.FileName);
                Variables.imgCurso = "assets/cursos/" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".jpg";
                Variables.imgCurso = "assets/cursos/" + Path.GetFileName(Variables.imgCurso);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        Variables.imgUpdateCurso = "S";
                        Variables.pathImgCurso = ofdImg.FileName;
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("Erro de segurança \n\n Descrição" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao selecionar imagem \n\n Descrição" + ex.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar imagem \n\n Descrição - " + ex.Message);
                btnReg.Focus();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "Ativo")
            {
                Variables.statusCurso = 1;
            }
            else
            {
                Variables.statusCurso = 0;
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            if (txtName.Text.Length == 0)
            {
                lblName.ForeColor = Color.Red;
                MessageBox.Show("Preencha o campo Nome do Curso");
                txtName.Focus();
            }
            else if (txtDuracao.Text.Length == 0)
            {
                MessageBox.Show("Preencha o campo Duração do Curso");
                txtDuracao.Focus();
            }
            else if (txtInstrutor.Text.Length == 0)
            {
                MessageBox.Show("Preencha o campo Instrutor");
                txtInstrutor.Focus();
            }
            else if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um status válido");
                cmbStatus.Focus();
            }
            else if (txtMsg.Text.Length == 0)
            {
                MessageBox.Show("Preencha o campo Mensagem");
                txtMsg.Focus();
            }
            else if (txtMsg.Text.Length == 0)
            {
                MessageBox.Show("Preencha o campo Descrição");
                txtMsg.Focus();
            }
            else
            {
                Variables.nomeCurso = txtName.Text;
                Variables.duracaoCurso = txtDuracao.Text;
                Variables.instrutorCurso = txtInstrutor.Text;
                Variables.msgWppCurso = txtMsg.Text;
                Variables.descCurso = txtDesc.Text;
                if (Variables.function != "EDITAR")
                {
                     Insert();
                }
                else
                {
                    UpdateData();
                    if (Variables.imgUpdateCurso == "S")
                    {
                        UpdateImg();
                    }
                }
            }
        }

        //DB MEthods
        private void Insert()
        {
            try
            {
                Database.StartConn();
                string query = "INSERT INTO curso (curso, descCurso, imgCurso, duracaoCurso, instrutorCurso, mensagemCurso, statusCurso, deletedCurso) VALUES(@curso, @desc, @img, @duracao, @instrutor, @msg, @status, @deleted)";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@curso", Variables.nomeCurso);
                cmd.Parameters.AddWithValue("@desc", Variables.descCurso);
                cmd.Parameters.AddWithValue("@img", Variables.imgCurso);
                cmd.Parameters.AddWithValue("@duracao", Variables.duracaoCurso);
                cmd.Parameters.AddWithValue("@instrutor", Variables.instrutorCurso);
                cmd.Parameters.AddWithValue("@msg", Variables.msgWppCurso);
                cmd.Parameters.AddWithValue("@status", Variables.statusCurso);
                cmd.Parameters.AddWithValue("@deleted", 0);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Curso cadastrado com sucesso");

                if (ValidateFTP())
                {
                    if (!string.IsNullOrEmpty(Variables.imgCurso))
                    {
                        string urlEnviarArquivo = Variables.addrFTP + "assets/cursos/" + Path.GetFileName(Variables.imgCurso);
                        try
                        {
                            FTP.SendFile(Variables.pathImgCurso, urlEnviarArquivo, Variables.userFTP, Variables.passFTP);
                            new frmCursos().Show();
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados! \n\n Descrição: " + ex.Message);
            }
        }
        private void LoadData()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM curso WHERE idCurso = @id";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@id", Variables.idCurso);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Variables.nomeCurso = reader.GetString(1);
                    Variables.descCurso = reader.GetString(2);
                    Variables.imgCurso = reader.GetString(4);
                    Variables.duracaoCurso = reader.GetString(5);
                    Variables.instrutorCurso = reader.GetString(6);
                    Variables.msgWppCurso = reader.GetString(7);
                    Variables.statusCurso = reader.GetInt32(8);

                    txtCod.Text = Variables.idCurso.ToString();
                    txtName.Text = Variables.nomeCurso;
                    txtDuracao.Text = Variables.duracaoCurso;
                    txtInstrutor.Text = Variables.instrutorCurso;
                    txtDesc.Text = Variables.descCurso;
                    txtMsg.Text = Variables.msgWppCurso;

                    if (Variables.statusCurso == 1)
                    {
                        cmbStatus.Text = "Ativo";
                    }
                    else
                    {
                        cmbStatus.Text = "Inativo";
                    }

                    picImg.Image = BytesToImage(GetImgToByte(Variables.addrFTP + Variables.imgCurso));

                }
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateImg()
        {
            try
            {

                Database.StartConn();
                string query = "UPDATE curso SET imgCurso = @img WHERE idCurso = @id";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@img", Variables.imgCurso);
                cmd.Parameters.AddWithValue("@id", Variables.idCurso);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Imagem Atualizada com sucesso");
                if (ValidateFTP())
                {
                    if (!string.IsNullOrEmpty(Variables.imgCurso))
                    {
                        string urlEnviarArquivo = Variables.addrFTP + "assets/cursos/" + Path.GetFileName(Variables.imgCurso);
                        try
                        {
                            FTP.SendFile(Variables.pathImgCurso, urlEnviarArquivo, Variables.userFTP, Variables.passFTP);
                            new frmCursos().Show();
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Database.CloseConn();

        }

        private void UpdateData()
        {
            try
            {
                Database.StartConn();
                string query = "UPDATE curso SET curso = @curso, descCurso = @desc, duracaoCurso = @duracao, instrutorCurso = @instrutor, mensagemCurso = @msg, statusCurso = @status WHERE idCurso = @id";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@curso", Variables.nomeCurso);
                cmd.Parameters.AddWithValue("@desc", Variables.descCurso);
                cmd.Parameters.AddWithValue("@duracao", Variables.duracaoCurso);
                cmd.Parameters.AddWithValue("@instrutor", Variables.instrutorCurso);
                cmd.Parameters.AddWithValue("@msg", Variables.msgWppCurso);
                cmd.Parameters.AddWithValue("@status", Variables.statusCurso);
                cmd.Parameters.AddWithValue("@id", Variables.idCurso);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Curso Atualizado com sucesso");
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
