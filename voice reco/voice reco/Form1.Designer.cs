namespace voice_reco
{
    partial class Form1
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
            this.enablevoice = new System.Windows.Forms.Button();
            this.disablevoice = new System.Windows.Forms.Button();
            this.outputbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // enablevoice
            // 
            this.enablevoice.Location = new System.Drawing.Point(12, 226);
            this.enablevoice.Name = "enablevoice";
            this.enablevoice.Size = new System.Drawing.Size(75, 23);
            this.enablevoice.TabIndex = 0;
            this.enablevoice.Text = "enable ";
            this.enablevoice.UseVisualStyleBackColor = true;
            this.enablevoice.Click += new System.EventHandler(this.enablevoice_Click);
            // 
            // disablevoice
            // 
            this.disablevoice.Enabled = false;
            this.disablevoice.Location = new System.Drawing.Point(197, 226);
            this.disablevoice.Name = "disablevoice";
            this.disablevoice.Size = new System.Drawing.Size(75, 23);
            this.disablevoice.TabIndex = 1;
            this.disablevoice.Text = "disable";
            this.disablevoice.UseVisualStyleBackColor = true;
            this.disablevoice.Click += new System.EventHandler(this.disablevoice_Click);
            // 
            // outputbox
            // 
            this.outputbox.Enabled = false;
            this.outputbox.Location = new System.Drawing.Point(0, 8);
            this.outputbox.Name = "outputbox";
            this.outputbox.Size = new System.Drawing.Size(280, 120);
            this.outputbox.TabIndex = 2;
            this.outputbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.outputbox);
            this.Controls.Add(this.disablevoice);
            this.Controls.Add(this.enablevoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enablevoice;
        private System.Windows.Forms.Button disablevoice;
        private System.Windows.Forms.RichTextBox outputbox;
    }
}

