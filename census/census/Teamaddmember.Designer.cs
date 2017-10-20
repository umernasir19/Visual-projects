namespace census
{
    partial class Teamaddmember
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
            this.textboxname = new System.Windows.Forms.TextBox();
            this.textBoxcnic = new System.Windows.Forms.TextBox();
            this.textBoxgender = new System.Windows.Forms.TextBox();
            this.textBoxprovince = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxname
            // 
            this.textboxname.Location = new System.Drawing.Point(111, 25);
            this.textboxname.Name = "textboxname";
            this.textboxname.Size = new System.Drawing.Size(100, 20);
            this.textboxname.TabIndex = 0;
            // 
            // textBoxcnic
            // 
            this.textBoxcnic.Location = new System.Drawing.Point(111, 71);
            this.textBoxcnic.Name = "textBoxcnic";
            this.textBoxcnic.Size = new System.Drawing.Size(100, 20);
            this.textBoxcnic.TabIndex = 1;
            // 
            // textBoxgender
            // 
            this.textBoxgender.Location = new System.Drawing.Point(111, 117);
            this.textBoxgender.Name = "textBoxgender";
            this.textBoxgender.Size = new System.Drawing.Size(100, 20);
            this.textBoxgender.TabIndex = 2;
            // 
            // textBoxprovince
            // 
            this.textBoxprovince.Location = new System.Drawing.Point(111, 177);
            this.textBoxprovince.Name = "textBoxprovince";
            this.textBoxprovince.Size = new System.Drawing.Size(100, 20);
            this.textBoxprovince.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "enter cnic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "privince";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(111, 215);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 10;
            this.addbutton.Text = "add ";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Teamaddmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxprovince);
            this.Controls.Add(this.textBoxgender);
            this.Controls.Add(this.textBoxcnic);
            this.Controls.Add(this.textboxname);
            this.Name = "Teamaddmember";
            this.Text = "Teamaddmember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxname;
        private System.Windows.Forms.TextBox textBoxcnic;
        private System.Windows.Forms.TextBox textBoxgender;
        private System.Windows.Forms.TextBox textBoxprovince;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addbutton;
    }
}