
namespace FlowerShop.Forms
{
    partial class ProcessFlowerForm
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
            this.buttonFlowerSave = new System.Windows.Forms.Button();
            this.textBoxProcessFlowerPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProcessFlowerCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProcessFlowerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.buttonFlowerSave);
            this.panel1.Controls.Add(this.textBoxProcessFlowerPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxProcessFlowerCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxProcessFlowerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 287);
            this.panel1.TabIndex = 0;
            // 
            // buttonFlowerSave
            // 
            this.buttonFlowerSave.BackColor = System.Drawing.SystemColors.Info;
            this.buttonFlowerSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlowerSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlowerSave.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFlowerSave.Location = new System.Drawing.Point(160, 229);
            this.buttonFlowerSave.Name = "buttonFlowerSave";
            this.buttonFlowerSave.Size = new System.Drawing.Size(100, 43);
            this.buttonFlowerSave.TabIndex = 13;
            this.buttonFlowerSave.Text = "SAVE";
            this.buttonFlowerSave.UseVisualStyleBackColor = false;
            this.buttonFlowerSave.Click += new System.EventHandler(this.buttonFlowerSave_Click);
            // 
            // textBoxProcessFlowerPrice
            // 
            this.textBoxProcessFlowerPrice.Location = new System.Drawing.Point(14, 171);
            this.textBoxProcessFlowerPrice.Name = "textBoxProcessFlowerPrice";
            this.textBoxProcessFlowerPrice.Size = new System.Drawing.Size(246, 23);
            this.textBoxProcessFlowerPrice.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "PRICE";
            // 
            // textBoxProcessFlowerCount
            // 
            this.textBoxProcessFlowerCount.Location = new System.Drawing.Point(14, 107);
            this.textBoxProcessFlowerCount.Name = "textBoxProcessFlowerCount";
            this.textBoxProcessFlowerCount.Size = new System.Drawing.Size(246, 23);
            this.textBoxProcessFlowerCount.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "COUNT";
            // 
            // textBoxProcessFlowerName
            // 
            this.textBoxProcessFlowerName.Location = new System.Drawing.Point(14, 42);
            this.textBoxProcessFlowerName.Name = "textBoxProcessFlowerName";
            this.textBoxProcessFlowerName.Size = new System.Drawing.Size(246, 23);
            this.textBoxProcessFlowerName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "NAME";
            // 
            // ProcessFlowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 278);
            this.Controls.Add(this.panel1);
            this.Name = "ProcessFlowerForm";
            this.Text = "ProcessFlowerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFlowerSave;
        private System.Windows.Forms.TextBox textBoxProcessFlowerPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProcessFlowerCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProcessFlowerName;
        private System.Windows.Forms.Label label1;
    }
}