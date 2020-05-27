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
using System.Linq.Expressions;
using System.Diagnostics.Contracts;
using System.IO;

namespace BookManegment
{
    public partial class FRM_ADD : Form
    {
        // var for connection Sql
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<string>();

        public int state; 
        public FRM_ADD()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            con.Close();
            cmd.Parameters.Clear();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm_cat = new FRM_CAT();
            bunifuTransition1.ShowSync(frm_cat);
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_ADD_Activated(object sender, EventArgs e)
        {

        }
    private void FRM_ADD_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PC\source\BookManegment\BookManegment\BookManegment\DbBook.mdf;Integrated Security=True;User Instance=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = " SELECT Cat FROM TbCaT";
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                }

                int i = 0;
                while (i < List.LongCount())
                {
                    txt_cat.Items.Add(List[i]);
                    i = i + 1;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            if (txt_author.Text == "" || txt_name.Text == "" || txt_price.Text == "" )   
            {
                MessageBox.Show("Please fill all informations!");
            }


            else
            {
                if (state ==0)
                {
                     //insert
                    //for convert image to Binary
                    MemoryStream ma = new MemoryStream();
                    cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _cover = ma.ToArray();

                    // sql command
                    con.ConnectionString = (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PC\source\BookManegment\BookManegment\BookManegment\DbBook.mdf;Integrated Security=True;User Instance=True");
                    con.Open();

                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO TbBooks (Tittel, Auther, Price, Cat,Date,Rate,Cover) VALUES (@Tittel, @Auther, @Price, @Cat, @Date, @Rate, @Cover)";
                    cmd.Parameters.AddWithValue("@Tittel", txt_name.Text);
                    cmd.Parameters.AddWithValue("@Auther", txt_author.Text);
                    cmd.Parameters.AddWithValue("@Price", txt_price.Text);
                    cmd.Parameters.AddWithValue("@Cat", txt_cat.Text);
                    cmd.Parameters.AddWithValue("@Date", txt_date.Value);
                    cmd.Parameters.AddWithValue("@Rate", txt_rate.Value);
                    cmd.Parameters.AddWithValue("@Cover", _cover);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form frm_add = new FRM_DIADD();
                    frm_add.Show();
                    this.Close();
                } else
                {
                    // edit

                    //for convert image to Binary
                    MemoryStream ma = new MemoryStream();
                    cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _cover = ma.ToArray();

                    // sql command
                    con.ConnectionString = (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PC\source\BookManegment\BookManegment\BookManegment\DbBook.mdf;Integrated Security=True;User Instance=True");
                    con.Open();

                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE TbBooks SET Tittel=@Tittel, Auther=@Auther, Price=@Price, Cat=@Cat, Date=@Date, Rate=@Rate, Cover=@Cover where ID=@ID";
                    cmd.Parameters.AddWithValue("@Tittel", txt_name.Text);
                    cmd.Parameters.AddWithValue("@Auther", txt_author.Text);
                    cmd.Parameters.AddWithValue("@Price", txt_price.Text);
                    cmd.Parameters.AddWithValue("@Cat", txt_cat.Text);
                    cmd.Parameters.AddWithValue("@Date", txt_date.Value);
                    cmd.Parameters.AddWithValue("@Rate", txt_rate.Value);
                    cmd.Parameters.AddWithValue("@Cover", _cover);
                    cmd.Parameters.AddWithValue("@ID", state); 

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form frm_edit = new FRM_DIEDIT();
                    frm_edit.Show();
                    this.Close();

                }
                    

                

                
            }
           
            cmd.Parameters.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dia = new OpenFileDialog();
            //dia.Filter="png|*.png"    filter
            var result = dia.ShowDialog();
            if (result == DialogResult.OK) ;
            {
                cover.Image = Image.FromFile(dia.FileName);
            }
        }
    }
            
    
}
    

