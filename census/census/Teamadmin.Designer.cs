namespace census
{
    partial class Teamadmin
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
            this.buttonaddteam = new System.Windows.Forms.Button();
            this.buttonview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonaddteam
            // 
            this.buttonaddteam.Location = new System.Drawing.Point(88, 82);
            this.buttonaddteam.Name = "buttonaddteam";
            this.buttonaddteam.Size = new System.Drawing.Size(128, 23);
            this.buttonaddteam.TabIndex = 0;
            this.buttonaddteam.Text = "Add Team";
            this.buttonaddteam.UseVisualStyleBackColor = true;
            // 
            // buttonview
            // 
            this.buttonview.Location = new System.Drawing.Point(88, 174);
            this.buttonview.Name = "buttonview";
            this.buttonview.Size = new System.Drawing.Size(128, 23);
            this.buttonview.TabIndex = 1;
            this.buttonview.Text = "View and delete team";
            this.buttonview.UseVisualStyleBackColor = true;
            // 
            // Teamadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 261);
            this.Controls.Add(this.buttonview);
            this.Controls.Add(this.buttonaddteam);
            this.Name = "Teamadmin";
            this.Text = "Teamadmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonaddteam;
        private System.Windows.Forms.Button buttonview;
    }
}