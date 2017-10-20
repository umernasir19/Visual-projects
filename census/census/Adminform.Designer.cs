namespace census
{
    partial class Adminform
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
            this.textboxadminname = new System.Windows.Forms.TextBox();
            this.textBoxadminpassword = new System.Windows.Forms.TextBox();
            this.buttonloginadmin = new System.Windows.Forms.Button();
            this.labelentername = new System.Windows.Forms.Label();
            this.labeladminpassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxadminname
            // 
            this.textboxadminname.Location = new System.Drawing.Point(90, 34);
            this.textboxadminname.Name = "textboxadminname";
            this.textboxadminname.Size = new System.Drawing.Size(100, 20);
            this.textboxadminname.TabIndex = 0;
            // 
            // textBoxadminpassword
            // 
            this.textBoxadminpassword.Location = new System.Drawing.Point(90, 93);
            this.textBoxadminpassword.Name = "textBoxadminpassword";
            this.textBoxadminpassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxadminpassword.TabIndex = 1;
            // 
            // buttonloginadmin
            // 
            this.buttonloginadmin.Location = new System.Drawing.Point(90, 160);
            this.buttonloginadmin.Name = "buttonloginadmin";
            this.buttonloginadmin.Size = new System.Drawing.Size(75, 23);
            this.buttonloginadmin.TabIndex = 2;
            this.buttonloginadmin.Text = "Login";
            this.buttonloginadmin.UseVisualStyleBackColor = true;
            this.buttonloginadmin.Click += new System.EventHandler(this.buttonloginadmin_Click);
            // 
            // labelentername
            // 
            this.labelentername.AutoSize = true;
            this.labelentername.Location = new System.Drawing.Point(11, 41);
            this.labelentername.Name = "labelentername";
            this.labelentername.Size = new System.Drawing.Size(63, 13);
            this.labelentername.TabIndex = 3;
            this.labelentername.Text = "Enter Name";
            // 
            // labeladminpassword
            // 
            this.labeladminpassword.AutoSize = true;
            this.labeladminpassword.Location = new System.Drawing.Point(3, 100);
            this.labeladminpassword.Name = "labeladminpassword";
            this.labeladminpassword.Size = new System.Drawing.Size(81, 13);
            this.labeladminpassword.TabIndex = 4;
            this.labeladminpassword.Text = "Enter Password";
            // 
            // Adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labeladminpassword);
            this.Controls.Add(this.labelentername);
            this.Controls.Add(this.buttonloginadmin);
            this.Controls.Add(this.textBoxadminpassword);
            this.Controls.Add(this.textboxadminname);
            this.Name = "Adminform";
            this.Text = "Adminform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxadminname;
        private System.Windows.Forms.TextBox textBoxadminpassword;
        private System.Windows.Forms.Button buttonloginadmin;
        private System.Windows.Forms.Label labelentername;
        private System.Windows.Forms.Label labeladminpassword;
    }
}