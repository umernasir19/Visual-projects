namespace census
{
    partial class CitizenAdmin
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
            this.buttonAddCitizen = new System.Windows.Forms.Button();
            this.buttonViewCitizen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddCitizen
            // 
            this.buttonAddCitizen.Location = new System.Drawing.Point(64, 92);
            this.buttonAddCitizen.Name = "buttonAddCitizen";
            this.buttonAddCitizen.Size = new System.Drawing.Size(136, 23);
            this.buttonAddCitizen.TabIndex = 0;
            this.buttonAddCitizen.Text = "Add Citizen";
            this.buttonAddCitizen.UseVisualStyleBackColor = true;
            this.buttonAddCitizen.Click += new System.EventHandler(this.buttonAddCitizen_Click);
            // 
            // buttonViewCitizen
            // 
            this.buttonViewCitizen.Location = new System.Drawing.Point(64, 171);
            this.buttonViewCitizen.Name = "buttonViewCitizen";
            this.buttonViewCitizen.Size = new System.Drawing.Size(130, 23);
            this.buttonViewCitizen.TabIndex = 1;
            this.buttonViewCitizen.Text = "View and delete  Citizen";
            this.buttonViewCitizen.UseVisualStyleBackColor = true;
            this.buttonViewCitizen.Click += new System.EventHandler(this.buttonViewCitizen_Click);
            // 
            // CitizenAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonViewCitizen);
            this.Controls.Add(this.buttonAddCitizen);
            this.Name = "CitizenAdmin";
            this.Text = "CitizenAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCitizen;
        private System.Windows.Forms.Button buttonViewCitizen;
    }
}