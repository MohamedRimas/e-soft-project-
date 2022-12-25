using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username;
            string pw;
            Username = textBox1.Text;
            pw = textBox2.Text;

            if (Username == "Rimas" && pw == "123")
            {

                MessageBox.Show("login_page successful");
                Form11 f11 = new Form11();
                f11.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User Name or Password Wrong");
            }    

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
    }

