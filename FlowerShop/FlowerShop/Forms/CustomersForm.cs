using FlowerShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop.Forms
{
    public partial class CustomersForm : Form
    {
        private static CustomersForm uniqInstance;
        public static CustomersForm GetInstance()
        {
            if (uniqInstance == null || uniqInstance.IsDisposed)
            {
                uniqInstance = new();
            }
            return uniqInstance;
        }

        DataContext dataContext;

        public CustomersForm()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            dataContext = new();
            RefreshData();
        }

        private void RefreshData()
        {
            dataContext = new();
            dataGridViewCustomers.DataSource = dataContext.Customers.ToList();
        }

        private void buttonCustomerAdd_Click(object sender, EventArgs e)
        {
            ProcessCustomerForm processCustomerForm = new(Models.OperationType.Add);
            processCustomerForm.ShowDialog();
            if (processCustomerForm.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void buttonCustomerEdit_Click(object sender, EventArgs e)
        {
            var customerId = (int)dataGridViewCustomers.SelectedRows[0].Cells[0].Value;
            var customer = dataContext.Customers.Where(x => x.Id == customerId).FirstOrDefault();
            ProcessCustomerForm processCustomerForm = new(OperationType.Edit, customer);
            processCustomerForm.ShowDialog();
            if (processCustomerForm.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void buttonCustomerDel_Click(object sender, EventArgs e)
        {
            var customerId = (int)dataGridViewCustomers.SelectedRows[0].Cells[0].Value;
            var customer = dataContext.Customers.Where(x => x.Id == customerId).FirstOrDefault();
            dataContext.Customers.Remove(customer);
            dataContext.SaveChanges();
            RefreshData();
            MessageBox.Show("Customer successfully deleted.");
        }

        private void buttonCustomerBack_Click(object sender, EventArgs e)
        {
            Main main = new();
            main.Show();
            this.Hide();
        }
    }
}
