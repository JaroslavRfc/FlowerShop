
namespace FlowerShop.Forms
{
    partial class ProcessOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProcessOrders = new System.Windows.Forms.DataGridView();
            this.textBoxProcessFlowerCount = new System.Windows.Forms.TextBox();
            this.comboBox2ProcessOrder = new System.Windows.Forms.ComboBox();
            this.comboBoxProcessOrder = new System.Windows.Forms.ComboBox();
            this.buttonProcessOrderRemove = new System.Windows.Forms.Button();
            this.buttonProcessOrderAdd = new System.Windows.Forms.Button();
            this.buttonProcessOrderSave = new System.Windows.Forms.Button();
            this.labelProcessOrder = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.labelProcessOrder);
            this.panel1.Controls.Add(this.buttonProcessOrderSave);
            this.panel1.Controls.Add(this.textBoxProcessFlowerCount);
            this.panel1.Controls.Add(this.comboBox2ProcessOrder);
            this.panel1.Controls.Add(this.comboBoxProcessOrder);
            this.panel1.Controls.Add(this.buttonProcessOrderRemove);
            this.panel1.Controls.Add(this.buttonProcessOrderAdd);
            this.panel1.Controls.Add(this.dataGridViewProcessOrders);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 566);
            this.panel1.TabIndex = 4;
            // 
            // dataGridViewProcessOrders
            // 
            this.dataGridViewProcessOrders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProcessOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcessOrders.Location = new System.Drawing.Point(14, 16);
            this.dataGridViewProcessOrders.Name = "dataGridViewProcessOrders";
            this.dataGridViewProcessOrders.RowTemplate.Height = 25;
            this.dataGridViewProcessOrders.Size = new System.Drawing.Size(555, 536);
            this.dataGridViewProcessOrders.TabIndex = 4;
            // 
            // textBoxProcessFlowerCount
            // 
            this.textBoxProcessFlowerCount.Location = new System.Drawing.Point(722, 94);
            this.textBoxProcessFlowerCount.Name = "textBoxProcessFlowerCount";
            this.textBoxProcessFlowerCount.Size = new System.Drawing.Size(208, 23);
            this.textBoxProcessFlowerCount.TabIndex = 11;
            // 
            // comboBox2ProcessOrder
            // 
            this.comboBox2ProcessOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2ProcessOrder.FormattingEnabled = true;
            this.comboBox2ProcessOrder.Location = new System.Drawing.Point(722, 57);
            this.comboBox2ProcessOrder.Name = "comboBox2ProcessOrder";
            this.comboBox2ProcessOrder.Size = new System.Drawing.Size(208, 23);
            this.comboBox2ProcessOrder.TabIndex = 10;
            // 
            // comboBoxProcessOrder
            // 
            this.comboBoxProcessOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcessOrder.FormattingEnabled = true;
            this.comboBoxProcessOrder.Location = new System.Drawing.Point(722, 16);
            this.comboBoxProcessOrder.Name = "comboBoxProcessOrder";
            this.comboBoxProcessOrder.Size = new System.Drawing.Size(208, 23);
            this.comboBoxProcessOrder.TabIndex = 9;
            // 
            // buttonProcessOrderRemove
            // 
            this.buttonProcessOrderRemove.BackColor = System.Drawing.SystemColors.Info;
            this.buttonProcessOrderRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProcessOrderRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcessOrderRemove.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonProcessOrderRemove.Location = new System.Drawing.Point(585, 94);
            this.buttonProcessOrderRemove.Name = "buttonProcessOrderRemove";
            this.buttonProcessOrderRemove.Size = new System.Drawing.Size(115, 41);
            this.buttonProcessOrderRemove.TabIndex = 8;
            this.buttonProcessOrderRemove.Text = "Remove Flover";
            this.buttonProcessOrderRemove.UseVisualStyleBackColor = false;
            this.buttonProcessOrderRemove.Click += new System.EventHandler(this.buttonProcessOrderRemove_Click);
            // 
            // buttonProcessOrderAdd
            // 
            this.buttonProcessOrderAdd.BackColor = System.Drawing.SystemColors.Info;
            this.buttonProcessOrderAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProcessOrderAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcessOrderAdd.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonProcessOrderAdd.Location = new System.Drawing.Point(585, 16);
            this.buttonProcessOrderAdd.Name = "buttonProcessOrderAdd";
            this.buttonProcessOrderAdd.Size = new System.Drawing.Size(115, 41);
            this.buttonProcessOrderAdd.TabIndex = 7;
            this.buttonProcessOrderAdd.Text = "Add Flower";
            this.buttonProcessOrderAdd.UseVisualStyleBackColor = false;
            this.buttonProcessOrderAdd.Click += new System.EventHandler(this.buttonProcessOrderAdd_Click);
            // 
            // buttonProcessOrderSave
            // 
            this.buttonProcessOrderSave.BackColor = System.Drawing.SystemColors.Info;
            this.buttonProcessOrderSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProcessOrderSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcessOrderSave.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonProcessOrderSave.Location = new System.Drawing.Point(811, 511);
            this.buttonProcessOrderSave.Name = "buttonProcessOrderSave";
            this.buttonProcessOrderSave.Size = new System.Drawing.Size(115, 41);
            this.buttonProcessOrderSave.TabIndex = 12;
            this.buttonProcessOrderSave.Text = "SAVE";
            this.buttonProcessOrderSave.UseVisualStyleBackColor = false;
            this.buttonProcessOrderSave.Click += new System.EventHandler(this.buttonProcessOrderSave_Click);
            // 
            // labelProcessOrder
            // 
            this.labelProcessOrder.AutoSize = true;
            this.labelProcessOrder.Location = new System.Drawing.Point(585, 191);
            this.labelProcessOrder.Name = "labelProcessOrder";
            this.labelProcessOrder.Size = new System.Drawing.Size(38, 15);
            this.labelProcessOrder.TabIndex = 13;
            this.labelProcessOrder.Text = "label1";
            // 
            // ProcessOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 560);
            this.Controls.Add(this.panel1);
            this.Name = "ProcessOrderForm";
            this.Text = "ProcessOrderForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProcessOrders;
        private System.Windows.Forms.Button buttonProcessOrderSave;
        private System.Windows.Forms.TextBox textBoxProcessFlowerCount;
        private System.Windows.Forms.ComboBox comboBox2ProcessOrder;
        private System.Windows.Forms.ComboBox comboBoxProcessOrder;
        private System.Windows.Forms.Button buttonProcessOrderRemove;
        private System.Windows.Forms.Button buttonProcessOrderAdd;
        private System.Windows.Forms.Label labelProcessOrder;
    }
}