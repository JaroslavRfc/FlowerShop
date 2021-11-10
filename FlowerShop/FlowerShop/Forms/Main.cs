using FlowerShop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        private void buttonMainOrder_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new();
            ordersForm.Show();
            this.Hide();
        }

        private void buttonMainFlower_Click(object sender, EventArgs e)
        {
            FlowersForm flowersForm = new();
            flowersForm.Show();
            this.Hide();
        }

        private void buttonMainCustomer_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new();
            customersForm.Show();
            this.Hide();
        }

        private void buttonMainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
