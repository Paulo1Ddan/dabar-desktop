using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cetdabar
{
    class FTP
    {
        //Enviar Arquiv
        public static void SendFile(string file, string url, string user, string password)
        {
            try
            {
                FileInfo fileinfo = new FileInfo(file);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(url));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(user, password);
                request.UseBinary = true;
                request.ContentLength = fileinfo.Length;
                using (FileStream fs = fileinfo.OpenRead())
                {
                    byte[] buffer = new byte[2048];
                    int bytesSent = 0;
                    int bytes = 0;
                    using(Stream stream = request.GetRequestStream())
                    {
                        while(bytesSent < buffer.Length)
                        {
                            bytes = fs.Read(buffer, 0, buffer.Length);
                            stream.Write(buffer, 0, bytes);
                            bytesSent += bytes;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao enviar arquivo \n\n Descrição - ", ex.Message);
            }
        }
    }
}
