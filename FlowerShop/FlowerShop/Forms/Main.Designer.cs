
namespace FlowerShop
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMainOrder = new System.Windows.Forms.Button();
            this.buttonMainFlower = new System.Windows.Forms.Button();
            this.buttonMainCustomer = new System.Windows.Forms.Button();
            this.buttonMainExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.buttonMainOrder);
            this.panel1.Controls.Add(this.buttonMainFlower);
            this.panel1.Controls.Add(this.buttonMainCustomer);
            this.panel1.Controls.Add(this.buttonMainExit);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 211);
            this.panel1.TabIndex = 0;
            // 
            // buttonMainOrder
            // 
            this.buttonMainOrder.BackColor = System.Drawing.SystemColors.Info;
            this.buttonMainOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMainOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainOrder.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMainOrder.Location = new System.Drawing.Point(37, 33);
            this.buttonMainOrder.Name = "buttonMainOrder";
            this.buttonMainOrder.Size = new System.Drawing.Size(115, 41);
            this.buttonMainOrder.TabIndex = 16;
            this.buttonMainOrder.Text = "ORDER";
            this.buttonMainOrder.UseVisualStyleBackColor = false;
            this.buttonMainOrder.Click += new System.EventHandler(this.buttonMainOrder_Click);
            // 
            // buttonMainFlower
            // 
            this.buttonMainFlower.BackColor = System.Drawing.SystemColors.Info;
            this.buttonMainFlower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMainFlower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainFlower.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMainFlower.Location = new System.Drawing.Point(237, 33);
            this.buttonMainFlower.Name = "buttonMainFlower";
            this.buttonMainFlower.Size = new System.Drawing.Size(115, 41);
            this.buttonMainFlower.TabIndex = 15;
            this.buttonMainFlower.Text = "FLOWER";
            this.buttonMainFlower.UseVisualStyleBackColor = false;
            this.buttonMainFlower.Click += new System.EventHandler(this.buttonMainFlower_Click);
            // 
            // buttonMainCustomer
            // 
            this.buttonMainCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.buttonMainCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMainCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainCustomer.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMainCustomer.Location = new System.Drawing.Point(237, 136);
            this.buttonMainCustomer.Name = "buttonMainCustomer";
            this.buttonMainCustomer.Size = new System.Drawing.Size(115, 41);
            this.buttonMainCustomer.TabIndex = 14;
            this.buttonMainCustomer.Text = "CUSTOMER";
            this.buttonMainCustomer.UseVisualStyleBackColor = false;
            this.buttonMainCustomer.Click += new System.EventHandler(this.buttonMainCustomer_Click);
            // 
            // buttonMainExit
            // 
            this.buttonMainExit.BackColor = System.Drawing.SystemColors.Info;
            this.buttonMainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMainExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainExit.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMainExit.Location = new System.Drawing.Point(37, 136);
            this.buttonMainExit.Name = "buttonMainExit";
            this.buttonMainExit.Size = new System.Drawing.Size(115, 41);
            this.buttonMainExit.TabIndex = 13;
            this.buttonMainExit.Text = "EXIT";
            this.buttonMainExit.UseVisualStyleBackColor = false;
            this.buttonMainExit.Click += new System.EventHandler(this.buttonMainExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 206);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMainOrder;
        private System.Windows.Forms.Button buttonMainFlower;
        private System.Windows.Forms.Button buttonMainCustomer;
        private System.Windows.Forms.Button buttonMainExit;
    }
}

