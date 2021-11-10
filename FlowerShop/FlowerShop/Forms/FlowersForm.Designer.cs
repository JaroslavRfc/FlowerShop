
namespace FlowerShop.Forms
{
    partial class FlowersForm
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
            this.dataGridViewFlowers = new System.Windows.Forms.DataGridView();
            this.buttonFlowerBack = new System.Windows.Forms.Button();
            this.buttonFlowerDel = new System.Windows.Forms.Button();
            this.buttonFlowerEdit = new System.Windows.Forms.Button();
            this.buttonFlowerAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlowers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.dataGridViewFlowers);
            this.panel1.Controls.Add(this.buttonFlowerBack);
            this.panel1.Controls.Add(this.buttonFlowerDel);
            this.panel1.Controls.Add(this.buttonFlowerEdit);
            this.panel1.Controls.Add(this.buttonFlowerAdd);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 458);
            this.panel1.TabIndex = 2;
            // 
            // dataGridViewFlowers
            // 
            this.dataGridViewFlowers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewFlowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlowers.Location = new System.Drawing.Point(95, 16);
            this.dataGridViewFlowers.Name = "dataGridViewFlowers";
            this.dataGridViewFlowers.RowTemplate.Height = 25;
            this.dataGridViewFlowers.Size = new System.Drawing.Size(695, 426);
            this.dataGridViewFlowers.TabIndex = 4;
            // 
            // buttonFlowerBack
            // 
            this.buttonFlowerBack.BackColor = System.Drawing.SystemColors.Info;
            this.buttonFlowerBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlowerBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlowerBack.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFlowerBack.Location = new System.Drawing.Point(14, 419);
            this.buttonFlowerBack.Name = "buttonFlowerBack";
            this.buttonFlowerBack.Size = new System.Drawing.Size(75, 23);
            this.buttonFlowerBack.TabIndex = 3;
            this.buttonFlowerBack.Text = "BACK";
            this.buttonFlowerBack.UseVisualStyleBackColor = false;
            this.buttonFlowerBack.Click += new System.EventHandler(this.buttonFlowerBack_Click);
            // 
            // buttonFlowerDel
            // 
            this.buttonFlowerDel.BackColor = System.Drawing.SystemColors.Info;
            this.buttonFlowerDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlowerDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlowerDel.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFlowerDel.Location = new System.Drawing.Point(14, 92);
            this.buttonFlowerDel.Name = "buttonFlowerDel";
            this.buttonFlowerDel.Size = new System.Drawing.Size(75, 23);
            this.buttonFlowerDel.TabIndex = 2;
            this.buttonFlowerDel.Text = "DELETE";
            this.buttonFlowerDel.UseVisualStyleBackColor = false;
            this.buttonFlowerDel.Click += new System.EventHandler(this.buttonFlowerDel_Click);
            // 
            // buttonFlowerEdit
            // 
            this.buttonFlowerEdit.BackColor = System.Drawing.SystemColors.Info;
            this.buttonFlowerEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlowerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlowerEdit.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFlowerEdit.Location = new System.Drawing.Point(14, 54);
            this.buttonFlowerEdit.Name = "buttonFlowerEdit";
            this.buttonFlowerEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonFlowerEdit.TabIndex = 1;
            this.buttonFlowerEdit.Text = "EDIT";
            this.buttonFlowerEdit.UseVisualStyleBackColor = false;
            this.buttonFlowerEdit.Click += new System.EventHandler(this.buttonFlowerEdit_Click);
            // 
            // buttonFlowerAdd
            // 
            this.buttonFlowerAdd.BackColor = System.Drawing.SystemColors.Info;
            this.buttonFlowerAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlowerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlowerAdd.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFlowerAdd.Location = new System.Drawing.Point(14, 16);
            this.buttonFlowerAdd.Name = "buttonFlowerAdd";
            this.buttonFlowerAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonFlowerAdd.TabIndex = 0;
            this.buttonFlowerAdd.Text = "ADD";
            this.buttonFlowerAdd.UseVisualStyleBackColor = false;
            this.buttonFlowerAdd.Click += new System.EventHandler(this.buttonFlowerAdd_Click);
            // 
            // FlowersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FlowersForm";
            this.Text = "FlowersForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlowers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewFlowers;
        private System.Windows.Forms.Button buttonFlowerBack;
        private System.Windows.Forms.Button buttonFlowerDel;
        private System.Windows.Forms.Button buttonFlowerEdit;
        private System.Windows.Forms.Button buttonFlowerAdd;
    }
}