using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AplikasiPenjualanBarang.kelas
{
    class Koneksi
    {
        public MySqlConnection getconn()
        {
            string host = "localhost";
            string user = "root";
            string password = "";
            string database = "buku";
            string connStr = "server=" + host + ";user=" + user + ";database=" +
                database + ";password=" + password + ";";
            MySqlConnection conn = new MySqlConnection(connStr);
            return conn;
        }
    }
}
