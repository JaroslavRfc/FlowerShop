
namespace FlowerShop.Forms
{
    partial class OrdersForm
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.buttonOrderBack = new System.Windows.Forms.Button();
            this.buttonOrderDel = new System.Windows.Forms.Button();
            this.buttonOrderEdit = new System.Windows.Forms.Button();
            this.buttonOrderAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.dataGridViewOrders);
            this.panel1.Controls.Add(this.buttonOrderBack);
            this.panel1.Controls.Add(this.buttonOrderDel);
            this.panel1.Controls.Add(this.buttonOrderEdit);
            this.panel1.Controls.Add(this.buttonOrderAdd);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 458);
            this.panel1.TabIndex = 3;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(95, 16);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowTemplate.Height = 25;
            this.dataGridViewOrders.Size = new System.Drawing.Size(695, 426);
            this.dataGridViewOrders.TabIndex = 4;
            // 
            // buttonOrderBack
            // 
            this.buttonOrderBack.BackColor = System.Drawing.SystemColors.Info;
            this.buttonOrderBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrderBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderBack.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOrderBack.Location = new System.Drawing.Point(14, 419);
            this.buttonOrderBack.Name = "buttonOrderBack";
            this.buttonOrderBack.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderBack.TabIndex = 3;
            this.buttonOrderBack.Text = "BACK";
            this.buttonOrderBack.UseVisualStyleBackColor = false;
            this.buttonOrderBack.Click += new System.EventHandler(this.buttonOrderBack_Click);
            // 
            // buttonOrderDel
            // 
            this.buttonOrderDel.BackColor = System.Drawing.SystemColors.Info;
            this.buttonOrderDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrderDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderDel.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOrderDel.Location = new System.Drawing.Point(14, 92);
            this.buttonOrderDel.Name = "buttonOrderDel";
            this.buttonOrderDel.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderDel.TabIndex = 2;
            this.buttonOrderDel.Text = "DELETE";
            this.buttonOrderDel.UseVisualStyleBackColor = false;
            this.buttonOrderDel.Click += new System.EventHandler(this.buttonOrderDel_Click);
            // 
            // buttonOrderEdit
            // 
            this.buttonOrderEdit.BackColor = System.Drawing.SystemColors.Info;
            this.buttonOrderEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrderEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderEdit.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOrderEdit.Location = new System.Drawing.Point(14, 54);
            this.buttonOrderEdit.Name = "buttonOrderEdit";
            this.buttonOrderEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderEdit.TabIndex = 1;
            this.buttonOrderEdit.Text = "EDIT";
            this.buttonOrderEdit.UseVisualStyleBackColor = false;
            this.buttonOrderEdit.Click += new System.EventHandler(this.buttonOrderEdit_Click);
            // 
            // buttonOrderAdd
            // 
            this.buttonOrderAdd.BackColor = System.Drawing.SystemColors.Info;
            this.buttonOrderAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrderAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderAdd.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOrderAdd.Location = new System.Drawing.Point(14, 16);
            this.buttonOrderAdd.Name = "buttonOrderAdd";
            this.buttonOrderAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderAdd.TabIndex = 0;
            this.buttonOrderAdd.Text = "ADD";
            this.buttonOrderAdd.UseVisualStyleBackColor = false;
            this.buttonOrderAdd.Click += new System.EventHandler(this.buttonOrderAdd_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonOrderBack;
        private System.Windows.Forms.Button buttonOrderDel;
        private System.Windows.Forms.Button buttonOrderEdit;
        private System.Windows.Forms.Button buttonOrderAdd;
    }
}