using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JessAssignment
{
    public partial class DisplayItemsForm : Form
    {
        public DisplayItemsForm()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jessAssignmentDataSet);

        }

        private void DisplayItemsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jessAssignmentDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.jessAssignmentDataSet.Items);
            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            itemsDataGridView.Columns.Add(editBtn);
            editBtn.HeaderText = "Actions";
            editBtn.Text = "Edit";
            editBtn.Name = "btn";
            editBtn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            itemsDataGridView.Columns.Add(deleteBtn);
            deleteBtn.HeaderText = "Actions";
            deleteBtn.Text = "Delete";
            deleteBtn.Name = "btn";
            deleteBtn.UseColumnTextForButtonValue = true;

            usernameLbl.Text = LoginForm.Username;

        }

        private void itemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayItemsForm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void itemsDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Edit button is clicked
            if (e.ColumnIndex == 8)
            {
                MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
            }
            //Delete Button is cliecked
            if(e.ColumnIndex == 9)
            {

            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.Show();
           
        }
    }
}
