namespace census
{
    partial class addmember
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
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.cnictextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxlabel = new System.Windows.Forms.Label();
            this.cniclabel = new System.Windows.Forms.Label();
            this.genderlabel = new System.Windows.Forms.Label();
            this.provincelabel = new System.Windows.Forms.Label();
            this.provincebox = new System.Windows.Forms.TextBox();
            this.genderbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(113, 48);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(120, 20);
            this.nametextbox.TabIndex = 0;
            this.nametextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cnictextbox
            // 
            this.cnictextbox.Location = new System.Drawing.Point(113, 91);
            this.cnictextbox.Name = "cnictextbox";
            this.cnictextbox.Size = new System.Drawing.Size(120, 20);
            this.cnictextbox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxlabel
            // 
            this.textboxlabel.AutoSize = true;
            this.textboxlabel.Location = new System.Drawing.Point(12, 55);
            this.textboxlabel.Name = "textboxlabel";
            this.textboxlabel.Size = new System.Drawing.Size(60, 13);
            this.textboxlabel.TabIndex = 7;
            this.textboxlabel.Text = "enter name";
            // 
            // cniclabel
            // 
            this.cniclabel.AutoSize = true;
            this.cniclabel.Location = new System.Drawing.Point(12, 98);
            this.cniclabel.Name = "cniclabel";
            this.cniclabel.Size = new System.Drawing.Size(54, 13);
            this.cniclabel.TabIndex = 8;
            this.cniclabel.Text = "enter cnic";
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Location = new System.Drawing.Point(11, 125);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(67, 13);
            this.genderlabel.TabIndex = 9;
            this.genderlabel.Text = "enter gender";
            // 
            // provincelabel
            // 
            this.provincelabel.AutoSize = true;
            this.provincelabel.Location = new System.Drawing.Point(11, 170);
            this.provincelabel.Name = "provincelabel";
            this.provincelabel.Size = new System.Drawing.Size(79, 13);
            this.provincelabel.TabIndex = 10;
            this.provincelabel.Text = "select province";
            // 
            // provincebox
            // 
            this.provincebox.Location = new System.Drawing.Point(113, 163);
            this.provincebox.Name = "provincebox";
            this.provincebox.Size = new System.Drawing.Size(100, 20);
            this.provincebox.TabIndex = 11;
            // 
            // genderbox
            // 
            this.genderbox.Location = new System.Drawing.Point(113, 125);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(100, 20);
            this.genderbox.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "<==";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.provincebox);
            this.Controls.Add(this.provincelabel);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.cniclabel);
            this.Controls.Add(this.textboxlabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cnictextbox);
            this.Controls.Add(this.nametextbox);
            this.Name = "addmember";
            this.Text = "addmember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox cnictextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textboxlabel;
        private System.Windows.Forms.Label cniclabel;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.Label provincelabel;
        private System.Windows.Forms.TextBox provincebox;
        private System.Windows.Forms.TextBox genderbox;
        private System.Windows.Forms.Button button2;
    }
}