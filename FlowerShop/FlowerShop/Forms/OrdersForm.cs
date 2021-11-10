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
    public partial class OrdersForm : Form
    {
        private static OrdersForm uniqInstance;
        public static OrdersForm GetInstance()
        {
            if (uniqInstance == null || uniqInstance.IsDisposed)
            {
                uniqInstance = new();
            }
            return uniqInstance;
        }

        DataContext dataContext;

        public OrdersForm()
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
            dataGridViewOrders.DataSource = dataContext.Orders.ToList();
        }

        private void buttonOrderAdd_Click(object sender, EventArgs e)
        {
            ProcessOrderForm processOrderForm = new(OperationType.Add);
            processOrderForm.ShowDialog();
            if (processOrderForm.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }

        }

        private void buttonOrderEdit_Click(object sender, EventArgs e)
        {
            var orderId = (int)dataGridViewOrders.SelectedRows[0].Cells[0].Value;
            var order = dataContext.Orders.Where(x => x.Id == orderId).FirstOrDefault();
            ProcessOrderForm processOrderForm = new(OperationType.Add, order);
            processOrderForm.ShowDialog();
            if (processOrderForm.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void buttonOrderDel_Click(object sender, EventArgs e)
        {
            var orderId = (int)dataGridViewOrders.SelectedRows[0].Cells[0].Value;
            var order = dataContext.Orders.Where(x => x.Id == orderId).FirstOrDefault();
            var orderDetails = dataContext.OrderDetails.Where(x => x.OrderId == orderId).ToArray();
            dataContext.OrderDetails.RemoveRange(orderDetails);
            dataContext.Orders.Remove(order);
            dataContext.SaveChanges();
            RefreshData();
            MessageBox.Show("Successfully deleted.");
        }

        private void buttonOrderBack_Click(object sender, EventArgs e)
        {
            Main main = new();
            main.Show();
            this.Hide();
        }
    }
}
