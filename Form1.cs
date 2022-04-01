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

namespace database1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public string constring = "Data Source=DESKTOP-UR1SGFT\\SQLEXPRESS;Initial Catalog=Teachers;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
           
            String q = "INSERT INTO Teachers_data(Id,Name,City,Age,Contact)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')";

            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Done....");
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
           
            String q = "UPDATE Teachers_data SET Name='" + textBox2.Text.ToString() + "' , City='" + textBox3.Text.ToString() + "' ,  Age='" + textBox4.Text.ToString() + "' ,   Contact='" + textBox5.Text.ToString() + "' WHERE Id=' " + textBox1.Text.ToString() + "' ";

            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Done....");
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
           
            String q = " DELETE FROM Teachers_data  WHERE Id=' " + textBox1.Text.ToString() + " ' ";

            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Done....");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = " SELECT * from Teachers_data";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridView1.DataSource = data;

            con.Close();
        }
    }

        
    }

