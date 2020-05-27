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

namespace BookManegment
{
    public partial class FRM_CAT : Form
    {

        //var for sqlconnection
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public FRM_CAT()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
            if (TXT_CAT.Text != "")
            {

                con.ConnectionString = (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PC\source\BookManegment\BookManegment\BookManegment\DbBook.mdf;Integrated Security=True;User Instance=True");
                con.Open();
             
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO TbCat (Cat) VALUES (@Cat)";
                cmd.Parameters.AddWithValue("@Cat", TXT_CAT.Text);            
                cmd.ExecuteNonQuery();
                con.Close();
                Form frm_add = new FRM_DIADD();
                frm_add.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter the catagory name");
            }
          
        }
    }
}
