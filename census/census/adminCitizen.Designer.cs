namespace census
{
    partial class adminCitizen
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
            this.buttonaddcitizen = new System.Windows.Forms.Button();
            this.buttonvieanddeltecitizen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonaddcitizen
            // 
            this.buttonaddcitizen.Location = new System.Drawing.Point(86, 60);
            this.buttonaddcitizen.Name = "buttonaddcitizen";
            this.buttonaddcitizen.Size = new System.Drawing.Size(133, 23);
            this.buttonaddcitizen.TabIndex = 0;
            this.buttonaddcitizen.Text = "Add citizen";
            this.buttonaddcitizen.UseVisualStyleBackColor = true;
            this.buttonaddcitizen.Click += new System.EventHandler(this.buttonaddcitizen_Click);
            // 
            // buttonvieanddeltecitizen
            // 
            this.buttonvieanddeltecitizen.Location = new System.Drawing.Point(86, 133);
            this.buttonvieanddeltecitizen.Name = "buttonvieanddeltecitizen";
            this.buttonvieanddeltecitizen.Size = new System.Drawing.Size(133, 23);
            this.buttonvieanddeltecitizen.TabIndex = 1;
            this.buttonvieanddeltecitizen.Text = "View and Delete citizen";
            this.buttonvieanddeltecitizen.UseVisualStyleBackColor = true;
            this.buttonvieanddeltecitizen.Click += new System.EventHandler(this.buttonvieanddeltecitizen_Click);
            // 
            // adminCitizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonvieanddeltecitizen);
            this.Controls.Add(this.buttonaddcitizen);
            this.Name = "adminCitizen";
            this.Text = "adminCitizen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonaddcitizen;
        private System.Windows.Forms.Button buttonvieanddeltecitizen;
    }
}