using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JessAssignment.JessAssignmentDataSet;

namespace JessAssignment
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(priceTB.Text);
            itemsTableAdapter1.Insert(
                titleTB.Text,
                directorTB.Text,
                certTB.Text,
                yorDTP.Value,
                price,
                formatTB.Text
                ); ;
        }
    }
}
