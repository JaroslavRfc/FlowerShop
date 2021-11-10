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
    public partial class ProcessOrderForm : Form
    {
        DataContext dataContext;
        OperationType operationType;
        Order order;
        public ProcessOrderForm(OperationType operationType)
        {
            this.operationType = operationType;
            Initialize();
        }

        public ProcessOrderForm(OperationType operationType, Order order)
        {
            this.operationType = operationType;
            this.order = order;
            Initialize();
        }

        private void Initialize()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            dataContext = new();
            comboBoxProcessOrder.DataSource = dataContext.Flowers.ToList();
            comboBoxProcessOrder.DisplayMember = "Name";

            comboBox2ProcessOrder.DataSource = dataContext.Customers.ToList();
            comboBox2ProcessOrder.DisplayMember = "Name";
            RefreshData();
        }

        private void RefreshData()
        {
            if (order != null)
            {
                var id = order.Id;
                dataGridViewProcessOrders.DataSource = dataContext.OrderDetails.Where(x => x.OrderId == id).ToList();
                CalculatePrice();
                var customerId = order.CustomerId;
                comboBox2ProcessOrder.SelectedItem = dataContext.Customers.Where(x => x.Id == customerId).FirstOrDefault();
            }
        }

        private void CalculatePrice()
        {
            var orderId = order.Id;
            var saveOrder = dataContext.Orders.Where(x => x.Id == orderId).FirstOrDefault();
            var orderDetails = dataContext.OrderDetails.Where(x => x.OrderId == orderId).ToArray();
            saveOrder.Price = 0;
            foreach (var detail in orderDetails)
            {
                int flowerId = detail.FlowerId;
                var flower = dataContext.Flowers.Where(x => x.Id == flowerId).FirstOrDefault();
                saveOrder.Price += detail.Count * flower.Price;
            }
            labelProcessOrder.Text = $"Total price: {saveOrder.Price.ToString()}";
        }

        private void buttonProcessOrderAdd_Click(object sender, EventArgs e)
        {
            if (operationType == OperationType.Add)
            {
                if (order == null)
                {
                    order = new();
                    var customer = comboBox2ProcessOrder.SelectedItem as Customer;
                    order.CustomerId = customer.Id;
                    order.Price = 0;
                    dataContext.Orders.Add(order);
                    dataContext.SaveChanges();
                }

                var orderDetail = new OrderDetail();
                orderDetail.OrderId = order.Id;
                var flowerId = (comboBoxProcessOrder.SelectedItem as Flower).Id;
                orderDetail.FlowerId = flowerId;
                orderDetail.Count = int.Parse(textBoxProcessFlowerCount.Text);
                dataContext.OrderDetails.Add(orderDetail);
                dataContext.SaveChanges();
                CalculatePrice();
                RefreshData();
            }
        }

        private void buttonProcessOrderRemove_Click(object sender, EventArgs e)
        {
            var orderDetailId = (int)dataGridViewProcessOrders.SelectedRows[0].Cells[0].Value;
            var orderDetail = dataContext.OrderDetails.Where(x => x.Id == orderDetailId).FirstOrDefault();
            dataContext.OrderDetails.Remove(orderDetail);
            dataContext.SaveChanges();
            RefreshData();
        }

        private void buttonProcessOrderSave_Click(object sender, EventArgs e)
        {
            CalculatePrice();
            dataContext.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
