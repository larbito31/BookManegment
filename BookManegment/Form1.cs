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
using System.IO;

namespace BookManegment
{
    public partial class Form1 : Form
    {
        //for move form without border
        int move;
        int movx;
        int movy;
        //var for sqlconnection
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();

        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal) 
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;

            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move==1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.ConnectionString = (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PC\source\BookManegment\BookManegment\BookManegment\DbBook.mdf;Integrated Security=True;User Instance=True");
            var sql = "select  id, Tittel, Auther,Price,Cat from TbBooks";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FRM_ADD frm_add = new FRM_ADD();
            frm_add.btnadd.ButtonText = "ADD ";
            frm_add.state = 0;
            frm_add.Show();
            //bunifuTransition1.ShowSync(frm_add);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            FRM_DETAILS frm_det = new FRM_DETAILS();


            frm_det.Show();

            try
            {
                con.ConnectionString = (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PC\source\BookManegment\BookManegment\BookManegment\DbBook.mdf;Integrated Security=True;User Instance=True");
                cmd.Connection = con;
                con.Open();
               
                cmd.CommandText = " SELECT Tittel, Auther, Price, Cat,Date,Rate FROM TbBooks where ID=@ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show(Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
                con.Close();
                con.Open();
                MessageBox.Show(Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));
                }


                frm_det.txt_name.Text = List[0];
                frm_det.txt_author.Text = List[1];
                frm_det.txt_price.Text = List[2];
                frm_det.txt_cat.Text = List[3];
                frm_det.txt_date.Value= Convert.ToDateTime(List[4]);
                frm_det.txt_rate.Value = Convert.ToInt32(List[5]);

                List.Clear();
                con.Close();
                

                // Read Image from database

                cmd.CommandText = "SELECT COVER FROM TBBOOKS WHERE ID=@IDIMAGE";
                cmd.Parameters.AddWithValue("@IDIMAGE", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                

                con.Open();
                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(img, 0, img.Length);
                frm_det.cover.Image = Image.FromStream(ma);



            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }

            cmd.Parameters.Clear();



        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            //EDIT
            FRM_ADD frm_add = new FRM_ADD();
            frm_add.btnadd.ButtonText = "Edit ";
            frm_add.state =Convert.ToInt16( dataGridView1.CurrentRow.Cells[0].Value);
            
            frm_add.Show();

            try
            {
                con.ConnectionString = (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PC\source\BookManegment\BookManegment\BookManegment\DbBook.mdf;Integrated Security=True;User Instance=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = " SELECT Tittel, Auther, Price, Cat,Date,Rate FROM TbBooks where ID=@ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(frm_add.state));
                


                con.Close();
                con.Open();
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));
                }


                frm_add.txt_name.Text = List[0];
                frm_add.txt_author.Text = List[1];
                frm_add.txt_price.Text = List[2];
                frm_add.txt_cat.Text = List[3];
                frm_add.txt_date.Value = Convert.ToDateTime(List[4]);
                frm_add.txt_rate.Value = Convert.ToInt32(List[5]);
                List.Clear();
                con.Close();

                // Read Image from database

                cmd.CommandText = "SELECT COVER FROM TBBOOKS WHERE ID=@IDIMAGE";
                cmd.Parameters.AddWithValue("@IDIMAGE", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));

                con.Open();
                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(img, 0, img.Length);
                frm_add.cover.Image = Image.FromStream(ma);



            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }

            cmd.Parameters.Clear();

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            con.ConnectionString = (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PC\source\BookManegment\BookManegment\BookManegment\DbBook.mdf;Integrated Security=True;User Instance=True");
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DELETE FROM TbBooks WHERE ID=@ID";
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();
            FRM_DIDELETE frmd = new FRM_DIDELETE();
            frmd.Show();
            cmd.Parameters.Clear();
        }
    }
}
