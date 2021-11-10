
namespace FlowerShop.Forms
{
    partial class CustomersForm
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
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.buttonCustomerBack = new System.Windows.Forms.Button();
            this.buttonCustomerDel = new System.Windows.Forms.Button();
            this.buttonCustomerEdit = new System.Windows.Forms.Button();
            this.buttonCustomerAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.dataGridViewCustomers);
            this.panel1.Controls.Add(this.buttonCustomerBack);
            this.panel1.Controls.Add(this.buttonCustomerDel);
            this.panel1.Controls.Add(this.buttonCustomerEdit);
            this.panel1.Controls.Add(this.buttonCustomerAdd);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 458);
            this.panel1.TabIndex = 3;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(95, 16);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowTemplate.Height = 25;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(695, 426);
            this.dataGridViewCustomers.TabIndex = 4;
            // 
            // buttonCustomerBack
            // 
            this.buttonCustomerBack.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCustomerBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomerBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerBack.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustomerBack.Location = new System.Drawing.Point(14, 419);
            this.buttonCustomerBack.Name = "buttonCustomerBack";
            this.buttonCustomerBack.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerBack.TabIndex = 3;
            this.buttonCustomerBack.Text = "BACK";
            this.buttonCustomerBack.UseVisualStyleBackColor = false;
            this.buttonCustomerBack.Click += new System.EventHandler(this.buttonCustomerBack_Click);
            // 
            // buttonCustomerDel
            // 
            this.buttonCustomerDel.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCustomerDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomerDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerDel.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustomerDel.Location = new System.Drawing.Point(14, 92);
            this.buttonCustomerDel.Name = "buttonCustomerDel";
            this.buttonCustomerDel.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerDel.TabIndex = 2;
            this.buttonCustomerDel.Text = "DELETE";
            this.buttonCustomerDel.UseVisualStyleBackColor = false;
            this.buttonCustomerDel.Click += new System.EventHandler(this.buttonCustomerDel_Click);
            // 
            // buttonCustomerEdit
            // 
            this.buttonCustomerEdit.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCustomerEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerEdit.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustomerEdit.Location = new System.Drawing.Point(14, 54);
            this.buttonCustomerEdit.Name = "buttonCustomerEdit";
            this.buttonCustomerEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerEdit.TabIndex = 1;
            this.buttonCustomerEdit.Text = "EDIT";
            this.buttonCustomerEdit.UseVisualStyleBackColor = false;
            this.buttonCustomerEdit.Click += new System.EventHandler(this.buttonCustomerEdit_Click);
            // 
            // buttonCustomerAdd
            // 
            this.buttonCustomerAdd.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCustomerAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerAdd.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustomerAdd.Location = new System.Drawing.Point(14, 16);
            this.buttonCustomerAdd.Name = "buttonCustomerAdd";
            this.buttonCustomerAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerAdd.TabIndex = 0;
            this.buttonCustomerAdd.Text = "ADD";
            this.buttonCustomerAdd.UseVisualStyleBackColor = false;
            this.buttonCustomerAdd.Click += new System.EventHandler(this.buttonCustomerAdd_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button buttonCustomerBack;
        private System.Windows.Forms.Button buttonCustomerDel;
        private System.Windows.Forms.Button buttonCustomerEdit;
        private System.Windows.Forms.Button buttonCustomerAdd;
    }
}