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
using System.Configuration;
namespace HRS
{
    public partial class Form3 : Form
    {

        SqlConnection con =new  SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bsc\Documents\hoteal_new.mdf;Integrated Security=True;Connect Timeout=30");
        public Form3()
        
        {
            //SqlCommand cmd = new SqlCommand();
            InitializeComponent();
        }

       


        private void button2_Click(object sender, EventArgs e)
        { 
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoteal_newDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.hoteal_newDataSet.Table);
            // TODO: This line of code loads data into the 'hotel1DataSet.Table_1' table. You can move, or remove it, as needed.
            //this.table_1TableAdapter.Fill(this.hotel1DataSet.Table_1);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string qur = "insert into table values('" + textBox1.Text + "" + textBox2.Text + "" + textBox6.Text + "" + comboBox1.SelectedItem + "" + textBox4.Text + "" + textBox3.Text + "" + textBox8.Text + "" + textBox7.Text + "" + ")";
                SqlCommand cmd = new SqlCommand(qur, con);
                con.Open();
                cmd.ExecuteNonQuery();
               
                MessageBox.Show("registered successfully");

            }
            



            catch (SqlException s)
            {
              MessageBox.Show("Value alrady entered");
            }
            finally
            {
                con.Close();
            }


        }
    }
}
