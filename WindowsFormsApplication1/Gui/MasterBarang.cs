using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AplikasiPenjualanBarang.Gui
{
    public partial class MasterBarang : Form
    {
        kelas.Koneksi koneksi = new kelas.Koneksi();

        public MasterBarang()
        {
            InitializeComponent();
            loadDaftar();
        }

        public DataSet getData()
        {
            DataSet dts = new DataSet();
            try
            {
                string sql = "SELECT * FROM tbl_buku";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getconn();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                data.Fill(dts, "tbl_buku");
            }
            catch (Exception e)
            {
                MessageBox.Show("get\n" + e.ToString());
            }
            return dts;
        }

        void header()
        {
            

            gridBarang.Columns[0].Visible = false;
            gridBarang.Columns[1].HeaderText = "Kode Buku";
            gridBarang.Columns[2].HeaderText = "Judul";
            gridBarang.Columns[3].HeaderText = "Pengarang";
            gridBarang.Columns[4].HeaderText = "Penerbit";
            gridBarang.Columns[5].HeaderText = "Jumlah";
            gridBarang.Columns[6].HeaderText = "Harga";
        }

        public void loadDaftar()
        {
            DataSet data = getData();
            gridBarang.DataSource = data;
            gridBarang.DataMember = "tbl_buku";
            header();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void gridBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
