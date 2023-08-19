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
    
    public partial class AnaPanel : Form
    {
        public AnaPanel()
        {
            InitializeComponent();
        }
       
        SqlConnection bgl = new SqlConnection(@"Data Source=Furkanerd\SQLEXPRESS;Initial Catalog=TBLPETROLOFİS;Integrated Security=True");
        double tutar,tutar1;
        public void kasa()
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("Select * from TBLKASA ", bgl);
            SqlDataReader rdr = kmt.ExecuteReader();
            while (rdr.Read())
            {
                lblkasa.Text = rdr[0].ToString();
            }
            bgl.Close();
            
        }
        
        public void satısyap()
        {
           if(numericUpDown1.Value != 0)
            {
                bgl.Open();
                SqlCommand kmt = new SqlCommand("insert into TBLHAREKETLER (TARİH,PLAKA,YAKITTÜRÜ,LİTRE,TUTAR) values (@P1,@P2,@P3,@P4,@P5)", bgl);
                kmt.Parameters.AddWithValue("@P1",dateTimePicker1.Value);
                kmt.Parameters.AddWithValue("@P2", txtplaka.Text);
                kmt.Parameters.AddWithValue("@P3", "Kurşunsuz 95");
                kmt.Parameters.AddWithValue("@P4", int.Parse(numericUpDown1.Value.ToString()));
                kmt.Parameters.AddWithValue("@P5", decimal.Parse(txt1.Text));
                kmt.ExecuteNonQuery();
                bgl.Close();
                /////////////////////////////////////
                bgl.Open();
                SqlCommand kmt1 = new SqlCommand("Update TBLKASA set kasa=kasa+@q1", bgl);
                kmt1.Parameters.AddWithValue("@q1",decimal.Parse( txt1.Text));
                kmt1.ExecuteNonQuery();
                bgl.Close();
                ////////////////////////////////////
                bgl.Open();
                SqlCommand kmt2 = new SqlCommand("Update TBLYAKIT set STOK=STOK-@q2 where YAKITTÜRÜ='Kurşunsuz 95'", bgl);
                kmt2.Parameters.AddWithValue("@q2",int.Parse( numericUpDown1.Value.ToString()));
                kmt2.ExecuteNonQuery();
                MessageBox.Show("Satış Gerçekleşti", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.Close();
            }
           if(numericUpDown2.Value != 0)
            {
                bgl.Open();
                SqlCommand kmt = new SqlCommand("insert into TBLHAREKETLER (TARİH,PLAKA,YAKITTÜRÜ,LİTRE,TUTAR) values (@P1,@P2,@P3,@P4,@P5)", bgl);
                kmt.Parameters.AddWithValue("@P1", dateTimePicker1.Value);
                kmt.Parameters.AddWithValue("@P2", txtplaka.Text);
                kmt.Parameters.AddWithValue("@P3", "V/Max Diesel");
                kmt.Parameters.AddWithValue("@P4", int.Parse(numericUpDown2.Value.ToString()));
                kmt.Parameters.AddWithValue("@P5", decimal.Parse(txt2.Text));
                kmt.ExecuteNonQuery();
                bgl.Close();
                /////////////////////////////////////
                bgl.Open();
                SqlCommand kmt1 = new SqlCommand("Update TBLKASA set kasa=kasa+@q1", bgl);
                kmt1.Parameters.AddWithValue("@q1", decimal.Parse(txt2.Text));
                kmt1.ExecuteNonQuery();
                bgl.Close();
                ////////////////////////////////////
                bgl.Open();
                SqlCommand kmt2 = new SqlCommand("Update TBLYAKIT set STOK=STOK-@q2 where YAKITTÜRÜ='V/Max Diesel'", bgl);
                kmt2.Parameters.AddWithValue("@q2", int.Parse(numericUpDown2.Value.ToString()));
                kmt2.ExecuteNonQuery();
                MessageBox.Show("Satış Gerçekleşti", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.Close();
            }
           if(numericUpDown3.Value != 0)
            {
                bgl.Open();
                SqlCommand kmt = new SqlCommand("insert into TBLHAREKETLER (TARİH,PLAKA,YAKITTÜRÜ,LİTRE,TUTAR) values (@P1,@P2,@P3,@P4,@P5)", bgl);
                kmt.Parameters.AddWithValue("@P1", dateTimePicker1.Value);
                kmt.Parameters.AddWithValue("@P2", txtplaka.Text);
                kmt.Parameters.AddWithValue("@P3", "V/Pro Diesel");
                kmt.Parameters.AddWithValue("@P4", int.Parse(numericUpDown3.Value.ToString()));
                kmt.Parameters.AddWithValue("@P5", decimal.Parse(txt3.Text));
                kmt.ExecuteNonQuery();
                bgl.Close();
                /////////////////////////////////////
                bgl.Open();
                SqlCommand kmt1 = new SqlCommand("Update TBLKASA set kasa=kasa+@q1", bgl);
                kmt1.Parameters.AddWithValue("@q1", decimal.Parse(txt3.Text));
                kmt1.ExecuteNonQuery();
                bgl.Close();
                ////////////////////////////////////
                bgl.Open();
                SqlCommand kmt2 = new SqlCommand("Update TBLYAKIT set STOK=STOK-@q2 where YAKITTÜRÜ='V/Pro Diesel'", bgl);
                kmt2.Parameters.AddWithValue("@q2", int.Parse(numericUpDown3.Value.ToString()));
                kmt2.ExecuteNonQuery();
                MessageBox.Show("Satış Gerçekleşti", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.Close();
            }
           if(numericUpDown4.Value != 0)
            {
                bgl.Open();
                SqlCommand kmt = new SqlCommand("insert into TBLHAREKETLER (TARİH,PLAKA,YAKITTÜRÜ,LİTRE,TUTAR) values (@P1,@P2,@P3,@P4,@P5)", bgl);
                kmt.Parameters.AddWithValue("@P1", dateTimePicker1.Value);
                kmt.Parameters.AddWithValue("@P2", txtplaka.Text);
                kmt.Parameters.AddWithValue("@P3", "Otogaz");
                kmt.Parameters.AddWithValue("@P4", int.Parse(numericUpDown4.Value.ToString()));
                kmt.Parameters.AddWithValue("@P5", decimal.Parse(txt4.Text));
                kmt.ExecuteNonQuery();
                bgl.Close();
                /////////////////////////////////////
                bgl.Open();
                SqlCommand kmt1 = new SqlCommand("Update TBLKASA set kasa=kasa+@q1", bgl);
                kmt1.Parameters.AddWithValue("@q1", decimal.Parse(txt4.Text));
                kmt1.ExecuteNonQuery();
                bgl.Close();
                ////////////////////////////////////
                bgl.Open();
                SqlCommand kmt2 = new SqlCommand("Update TBLYAKIT set STOK=STOK-@q2 where YAKITTÜRÜ='Otogaz'", bgl);
                kmt2.Parameters.AddWithValue("@q2", int.Parse(numericUpDown4.Value.ToString()));
                kmt2.ExecuteNonQuery();
                MessageBox.Show("Satış Gerçekleşti", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.Close();
            }
           
           
        }
        public void alisyap()
        {
            if (numericUpDown8.Value != 0)
            {
                bgl.Open();
                SqlCommand kmt1 = new SqlCommand("Update TBLKASA set kasa=kasa-@q1", bgl);
                kmt1.Parameters.AddWithValue("@q1", decimal.Parse(txtal1.Text));
                kmt1.ExecuteNonQuery();
                bgl.Close();
                ////////////////////////////////////
                bgl.Open();
                SqlCommand kmt2 = new SqlCommand("Update TBLYAKIT set STOK=STOK+@q2 where YAKITTÜRÜ='Kurşunsuz 95'", bgl);
                kmt2.Parameters.AddWithValue("@q2", int.Parse(numericUpDown8.Value.ToString()));
                kmt2.ExecuteNonQuery();
                MessageBox.Show("Alış Gerçekleşti", "Alış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.Close();
            }
            if (numericUpDown7.Value != 0)
            {
                bgl.Open();
                SqlCommand kmt1 = new SqlCommand("Update TBLKASA set kasa=kasa-@q1", bgl);
                kmt1.Parameters.AddWithValue("@q1", decimal.Parse(txtal2.Text));
                kmt1.ExecuteNonQuery();
                bgl.Close();
                ////////////////////////////////////
                bgl.Open();
                SqlCommand kmt2 = new SqlCommand("Update TBLYAKIT set STOK=STOK+@q2 where YAKITTÜRÜ='V/Max Diesel'", bgl);
                kmt2.Parameters.AddWithValue("@q2", int.Parse(numericUpDown7.Value.ToString()));
                kmt2.ExecuteNonQuery();
                MessageBox.Show("Alış Gerçekleşti", "Alış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.Close();
            }
            if (numericUpDown6.Value != 0)
            {
                bgl.Open();
                SqlCommand kmt1 = new SqlCommand("Update TBLKASA set kasa=kasa-@q1", bgl);
                kmt1.Parameters.AddWithValue("@q1", decimal.Parse(txtal3.Text));
                kmt1.ExecuteNonQuery();
                bgl.Close();
                ////////////////////////////////////
                bgl.Open();
                SqlCommand kmt2 = new SqlCommand("Update TBLYAKIT set STOK=STOK+@q2 where YAKITTÜRÜ='V/Pro Diesel'", bgl);
                kmt2.Parameters.AddWithValue("@q2", int.Parse(numericUpDown6.Value.ToString()));
                kmt2.ExecuteNonQuery();
                MessageBox.Show("Alış Gerçekleşti", "Alış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.Close();
            }
            if (numericUpDown5.Value != 0)
            {
                bgl.Open();
                SqlCommand kmt1 = new SqlCommand("Update TBLKASA set kasa=kasa-@q1", bgl);
                kmt1.Parameters.AddWithValue("@q1", decimal.Parse(txtal4.Text));
                kmt1.ExecuteNonQuery();
                bgl.Close();
                ////////////////////////////////////
                bgl.Open();
                SqlCommand kmt2 = new SqlCommand("Update TBLYAKIT set STOK=STOK+@q2 where YAKITTÜRÜ='Otogaz'", bgl);
                kmt2.Parameters.AddWithValue("@q2", int.Parse(numericUpDown5.Value.ToString()));
                kmt2.ExecuteNonQuery();
                MessageBox.Show("Alış Gerçekleşti", "Alış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.Close();
            }









        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AnaPanel_Load(object sender, EventArgs e)
        {
            kasa();
            //STOKPROGGRESBAR
            //STOK1
            bgl.Open();
            SqlCommand kmt10 = new SqlCommand("Select * from TBLYAKIT Where ID=1", bgl);
            SqlDataReader rdr10 = kmt10.ExecuteReader();
            while (rdr10.Read())
            {
                progressBar1.Value = int.Parse(rdr10[4].ToString());
                lblstok1.Text = rdr10[4].ToString();
            }
            bgl.Close();
            //STOK2
            bgl.Open();
            SqlCommand kmt11 = new SqlCommand("Select * from TBLYAKIT Where ID=2", bgl);
            SqlDataReader rdr11 = kmt11.ExecuteReader();
            while (rdr11.Read())
            {
                progressBar2.Value = int.Parse(rdr11[4].ToString());
                lblstok2.Text = rdr11[4].ToString();
            }
            bgl.Close();
            //STOK3
            bgl.Open();
            SqlCommand kmt12 = new SqlCommand("Select * from TBLYAKIT Where ID=3", bgl);
            SqlDataReader rdr12 = kmt12.ExecuteReader();
            while (rdr12.Read())
            {
                progressBar3.Value = int.Parse(rdr12[4].ToString());
                lblstok3.Text = rdr12[4].ToString();
            }
            bgl.Close();
            //STOK3
            bgl.Open();
            SqlCommand kmt13 = new SqlCommand("Select * from TBLYAKIT Where ID=4", bgl);
            SqlDataReader rdr13 = kmt13.ExecuteReader();
            while (rdr13.Read())
            {
                progressBar4.Value = int.Parse(rdr13[4].ToString());
                lblstok4.Text = rdr13[4].ToString();
            }
            bgl.Close();

            //SATISFİYATCEKME
            //KURSUNSUZ95
            bgl.Open();
            SqlCommand kmt = new SqlCommand("Select * from TBLYAKIT where ID=1", bgl);
            SqlDataReader rdr = kmt.ExecuteReader();
            if (rdr.Read())
            {
                lblf1.Text = rdr[2].ToString();
            }
            bgl.Close();
           //vmax diesel
            bgl.Open();
            SqlCommand kmt1 = new SqlCommand("Select * from TBLYAKIT where ID=2", bgl);
            SqlDataReader rdr1 = kmt1.ExecuteReader();
            if (rdr1.Read())
            {
                lblf2.Text = rdr1[2].ToString();
            }
            bgl.Close();
            //vpro diesel
            bgl.Open();
            SqlCommand kmt2 = new SqlCommand("Select * from TBLYAKIT where ID=3", bgl);
            SqlDataReader rdr2 = kmt2.ExecuteReader();
            if (rdr2.Read())
            {
                lblf3.Text = rdr2[2].ToString();
            }
            bgl.Close();
            //otogaz
            bgl.Open();
            SqlCommand kmt3 = new SqlCommand("Select * from TBLYAKIT where ID=4", bgl);
            SqlDataReader rdr3 = kmt3.ExecuteReader();
            if (rdr3.Read())
            {
                lblf4.Text = rdr3[2].ToString();
            }
            bgl.Close();
            //ALISFIYATCEKME
            //KURSUNSUZ95
            bgl.Open();
            SqlCommand kmt4 = new SqlCommand("Select * from TBLYAKIT where ID=1", bgl);
            SqlDataReader rdr4 = kmt4.ExecuteReader();
            if (rdr4.Read())
            {
                lblalf1.Text = rdr4[3].ToString();
            }
            bgl.Close();
            //vmax diesel
            bgl.Open();
            SqlCommand kmt5 = new SqlCommand("Select * from TBLYAKIT where ID=2", bgl);
            SqlDataReader rdr5 = kmt5.ExecuteReader();
            if (rdr5.Read())
            {
                lblalf2.Text = rdr5[3].ToString();
            }
            bgl.Close();
            //vpro diesel
            bgl.Open();
            SqlCommand kmt6 = new SqlCommand("Select * from TBLYAKIT where ID=3", bgl);
            SqlDataReader rdr6 = kmt6.ExecuteReader();
            if (rdr6.Read())
            {
                lblalf3.Text = rdr6[3].ToString();
            }
            bgl.Close();
            //otogaz
            bgl.Open();
            SqlCommand kmt7 = new SqlCommand("Select * from TBLYAKIT where ID=4", bgl);
            SqlDataReader rdr7 = kmt7.ExecuteReader();
            if (rdr7.Read())
            {
                lblalf4.Text = rdr7[3].ToString();
            }
            bgl.Close();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double fiyat, litre;
            fiyat = Convert.ToDouble(lblf1.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = fiyat * litre;
            txt1.Text=tutar.ToString();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double fiyat, litre;
            fiyat = Convert.ToDouble(lblf2.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = fiyat * litre;
            txt2.Text = tutar.ToString();
            
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double fiyat, litre;
            fiyat = Convert.ToDouble(lblf3.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = fiyat * litre;
            txt3.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double fiyat, litre;
            fiyat = Convert.ToDouble(lblf4.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = fiyat * litre;
            txt4.Text = tutar.ToString();
        }

        private void btnsatısyap_Click(object sender, EventArgs e)
        {
            satısyap();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tppd.com.tr/tr/kurumsal/hakkimizda/1"); 
            
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Satıshareket sh = new Satıshareket();
            sh.Show();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            double fiyat1, litre1;
            fiyat1 = Convert.ToDouble(lblalf2.Text);
            litre1 = Convert.ToDouble(numericUpDown7.Value);
            tutar1 = fiyat1 * litre1;
            txtal2.Text = tutar1.ToString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            double fiyat1, litre1;
            fiyat1 = Convert.ToDouble(lblalf3.Text);
            litre1 = Convert.ToDouble(numericUpDown6.Value);
            tutar1 = fiyat1 * litre1;
            txtal3.Text = tutar1.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double fiyat1, litre1;
            fiyat1 = Convert.ToDouble(lblalf4.Text);
            litre1 = Convert.ToDouble(numericUpDown5.Value);
            tutar1 = fiyat1 * litre1;
            txtal4.Text = tutar1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            alisyap();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fiyat_güncelleme fg = new Fiyat_güncelleme();
            fg.Show();
           
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            double fiyat1, litre1;
           fiyat1= Convert.ToDouble(lblalf1.Text);
           litre1= Convert.ToDouble(numericUpDown8.Value);
           tutar1= fiyat1 * litre1;
           txtal1.Text= tutar1.ToString(); 

        }
    }
    }
    
    
    


