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
    public partial class ProcessFlowerForm : Form
    {
        DataContext dataContext;
        OperationType operationType;
        Flower flower;

        public ProcessFlowerForm(OperationType operationType)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            this.operationType = operationType;
            dataContext = new();
        }

        public ProcessFlowerForm(OperationType operationType, Flower flower)
        {
            InitializeComponent();
            this.operationType = operationType;
            dataContext = new();
            this.flower = flower;
            textBoxProcessFlowerName.Text = flower.Name;
            textBoxProcessFlowerCount.Text = flower.Count.ToString();
            textBoxProcessFlowerPrice.Text = flower.Price.ToString();
        }

        private void buttonFlowerSave_Click(object sender, EventArgs e)
        {
            if (operationType == OperationType.Add)
            {
                var newFlower = new Flower();
                newFlower.Name = textBoxProcessFlowerName.Text;
                newFlower.Count = int.Parse(textBoxProcessFlowerCount.Text);
                newFlower.Price = decimal.Parse(textBoxProcessFlowerPrice.Text);

                dataContext.Flowers.Add(newFlower);
                dataContext.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (operationType == OperationType.Edit)
            {
                var id = flower.Id;
                var editFlower = dataContext.Flowers.Where(x => x.Id == id).FirstOrDefault();
                editFlower.Name = textBoxProcessFlowerName.Text;
                editFlower.Count = int.Parse(textBoxProcessFlowerCount.Text);
                editFlower.Price = decimal.Parse(textBoxProcessFlowerPrice.Text);
                dataContext.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
