
namespace FlowerShop.Forms
{
    partial class ProcessCustomerForm
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
            this.buttonCustomerSave = new System.Windows.Forms.Button();
            this.textBoxProcessCustomerMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProcessCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.buttonCustomerSave);
            this.panel1.Controls.Add(this.textBoxProcessCustomerMail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxProcessCustomerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 287);
            this.panel1.TabIndex = 1;
            // 
            // buttonCustomerSave
            // 
            this.buttonCustomerSave.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCustomerSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomerSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerSave.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustomerSave.Location = new System.Drawing.Point(160, 229);
            this.buttonCustomerSave.Name = "buttonCustomerSave";
            this.buttonCustomerSave.Size = new System.Drawing.Size(100, 43);
            this.buttonCustomerSave.TabIndex = 13;
            this.buttonCustomerSave.Text = "SAVE";
            this.buttonCustomerSave.UseVisualStyleBackColor = false;
            this.buttonCustomerSave.Click += new System.EventHandler(this.buttonCustomerSave_Click);
            // 
            // textBoxProcessCustomerMail
            // 
            this.textBoxProcessCustomerMail.Location = new System.Drawing.Point(14, 174);
            this.textBoxProcessCustomerMail.Name = "textBoxProcessCustomerMail";
            this.textBoxProcessCustomerMail.Size = new System.Drawing.Size(246, 23);
            this.textBoxProcessCustomerMail.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "E-MAIL";
            // 
            // textBoxProcessCustomerName
            // 
            this.textBoxProcessCustomerName.Location = new System.Drawing.Point(14, 59);
            this.textBoxProcessCustomerName.Name = "textBoxProcessCustomerName";
            this.textBoxProcessCustomerName.Size = new System.Drawing.Size(246, 23);
            this.textBoxProcessCustomerName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "NAME";
            // 
            // ProcessCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 278);
            this.Controls.Add(this.panel1);
            this.Name = "ProcessCustomerForm";
            this.Text = "ProcessCustomerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCustomerSave;
        private System.Windows.Forms.TextBox textBoxProcessCustomerMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProcessCustomerName;
        private System.Windows.Forms.Label label1;
    }
}