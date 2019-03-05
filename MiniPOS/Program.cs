using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DbLib;
namespace MiniPOS
{
    static class Program
    {
        public static string StaffID { get; set; }
        public static String ENGName { get; set; }
        public static String KHName { get; set; }
        public static string Gender { get; set; }
        public static SqlConnection Connection { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string file_name = ".\\connection_string.con";
            string secret_key = "123456789";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.LoadFromFile(file_name, secret_key);

            Connection = new SqlConnection();
            Connection.ConnectionString = builder.ToString();
            try
            {
                Connection.Open();
            }
            catch (Exception)
            {
                
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogIn());
            try
            {
                Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
