using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cetdabar
{
    class Variables
    {
        //Global
        public static int selectedRow;
        public static string function;

        //Class
        public static int idClass;
        public static string nameClass, statusClass, andamentoClass;
        public static DateTime dateRegClass;

        //Users
        public static int idUser, catUser, statusUser;
        public static string nameUser, emailUser, telUser, passUser, imgUser, pathImgUser, imgUpdateUser;
        public static DateTime dataNascUser, dataCadUser;

        //Blog
        public static int idBlog, statusBlog;
        public static string titleBlog, artigo, imgCapa, imgBanner, upImgapa, upImgBanner, pathImgCapa, pathImgBanner;
        public static DateTime dataCadBlog;

        //FTP
        public static string addrFTP = "ftp://127.0.0.1/admin/";
        public static string userFTP = "cetdabar";
        public static string passFTP = "1234";
    }
}
