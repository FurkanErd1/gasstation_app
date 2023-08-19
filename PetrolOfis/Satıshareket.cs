using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetrolOfis
{
    public partial class Satıshareket : Form
    {
        public Satıshareket()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=Furkanerd\SQLEXPRESS;Initial Catalog=TBLPETROLOFİS;Integrated Security=True");
        private void Satıshareket_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLHAREKETLER", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
