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
    public partial class FlowersForm : Form
    {
        private static FlowersForm uniqInstance;
        public static FlowersForm GetInstance()
        {
            if (uniqInstance == null || uniqInstance.IsDisposed)
            {
                uniqInstance = new();
            }
            return uniqInstance;
        }

        DataContext dataContext;

        public FlowersForm()
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
            dataGridViewFlowers.DataSource = dataContext.Flowers.ToList();
        }

        private void buttonFlowerAdd_Click(object sender, EventArgs e)
        {
            ProcessFlowerForm processFlowerForm = new ProcessFlowerForm(Models.OperationType.Add);
            processFlowerForm.ShowDialog();
            if (processFlowerForm.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void buttonFlowerEdit_Click(object sender, EventArgs e)
        {
            var flowerId = (int)dataGridViewFlowers.SelectedRows[0].Cells[0].Value;
            var flower = dataContext.Flowers.Where(x => x.Id == flowerId).FirstOrDefault();
            ProcessFlowerForm processFlowerForm = new ProcessFlowerForm(Models.OperationType.Edit, flower);
            processFlowerForm.ShowDialog();
            if (processFlowerForm.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void buttonFlowerDel_Click(object sender, EventArgs e)
        {
            var flowerId = (int)dataGridViewFlowers.SelectedRows[0].Cells[0].Value;
            var flower = dataContext.Flowers.Where(x => x.Id == flowerId).FirstOrDefault();
            dataContext.Flowers.Remove(flower);
            dataContext.SaveChanges();
            RefreshData();
            MessageBox.Show("Flower successfully deleted.");
        }

        private void buttonFlowerBack_Click(object sender, EventArgs e)
        {
            Main main = new();
            main.Show();
            this.Hide();
        }
    }
}
