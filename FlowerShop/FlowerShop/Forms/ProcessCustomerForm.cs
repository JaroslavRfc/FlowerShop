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
    public partial class ProcessCustomerForm : Form
    {
        DataContext dataContext;
        OperationType operationType;
        Customer customer;

        public ProcessCustomerForm(OperationType operationType)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            this.operationType = operationType;
            dataContext = new();
        }

        public ProcessCustomerForm(OperationType operationType, Customer customer)
        {
            InitializeComponent();
            this.operationType = operationType;
            dataContext = new();
            this.customer = customer;
            textBoxProcessCustomerName.Text = customer.Name;
            textBoxProcessCustomerMail.Text = customer.Email;
        }

        private void buttonCustomerSave_Click(object sender, EventArgs e)
        {
            if (operationType == OperationType.Add)
            {
                var newCustomer = new Customer();
                newCustomer.Name = textBoxProcessCustomerName.Text;
                newCustomer.Email = textBoxProcessCustomerMail.Text;

                dataContext.Customers.Add(newCustomer);
                dataContext.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (operationType == OperationType.Edit)
            {
                var id = customer.Id;
                var editCustomer = dataContext.Customers.Where(x => x.Id == id).FirstOrDefault();
                editCustomer.Name = textBoxProcessCustomerName.Text;
                editCustomer.Email = textBoxProcessCustomerMail.Text;
                dataContext.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
