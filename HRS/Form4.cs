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

namespace HRS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoteal_newDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.hoteal_newDataSet.Table);
            // TODO: This line of code loads data into the 'hotel1DataSet.Table_1' table. You can move, or remove it, as needed.
            // this.table_1TableAdapter.Fill(this.hotel1DataSet.Table_1);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            table1BindingSource.AddNew();  
        }
    }
}
