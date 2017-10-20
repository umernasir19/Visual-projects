namespace medical_store_proj
{
    partial class addstock
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
            System.Windows.Forms.Label quantity;
            this.namelabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxitemname = new System.Windows.Forms.TextBox();
            this.textBoxquantity = new System.Windows.Forms.TextBox();
            this.textboxprice = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            quantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(38, 9);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(33, 13);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "name";
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.Location = new System.Drawing.Point(38, 54);
            quantity.Name = "quantity";
            quantity.Size = new System.Drawing.Size(44, 13);
            quantity.TabIndex = 1;
            quantity.Text = "quantity";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(38, 109);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(30, 13);
            this.pricelabel.TabIndex = 2;
            this.pricelabel.Text = "price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textboxitemname
            // 
            this.textboxitemname.Location = new System.Drawing.Point(95, 6);
            this.textboxitemname.Name = "textboxitemname";
            this.textboxitemname.Size = new System.Drawing.Size(100, 20);
            this.textboxitemname.TabIndex = 4;
            this.textboxitemname.TextChanged += new System.EventHandler(this.textboxitemname_TextChanged);
            // 
            // textBoxquantity
            // 
            this.textBoxquantity.Location = new System.Drawing.Point(95, 47);
            this.textBoxquantity.Name = "textBoxquantity";
            this.textBoxquantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxquantity.TabIndex = 5;
            // 
            // textboxprice
            // 
            this.textboxprice.Location = new System.Drawing.Point(95, 106);
            this.textboxprice.Name = "textboxprice";
            this.textboxprice.Size = new System.Drawing.Size(100, 20);
            this.textboxprice.TabIndex = 6;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(95, 166);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 7;
            this.addbutton.Text = "add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // addstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.textboxprice);
            this.Controls.Add(this.textBoxquantity);
            this.Controls.Add(this.textboxitemname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(quantity);
            this.Controls.Add(this.namelabel);
            this.Name = "addstock";
            this.Text = "addstock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxitemname;
        private System.Windows.Forms.TextBox textBoxquantity;
        private System.Windows.Forms.TextBox textboxprice;
        private System.Windows.Forms.Button addbutton;
    }
}