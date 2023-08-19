using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolOfis
{
    public partial class Fiyat_güncelleme : Form
    {
        public Fiyat_güncelleme()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=Furkanerd\SQLEXPRESS;Initial Catalog=TBLPETROLOFİS;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("Update TBLYAKIT set SATIS=@p1 , ALIS=@p2 Where ID=@p3",bgl);
            kmt.Parameters.AddWithValue("@p1", textBox2.Text);
            kmt.Parameters.AddWithValue("@p2", textBox3.Text);
            kmt.Parameters.AddWithValue("@p3", textBox1.Text);
            kmt.ExecuteNonQuery();
            MessageBox.Show("Fiyatlar Güncellendi");
            bgl.Close();
        }
    }
}
