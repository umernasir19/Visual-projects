namespace census
{
    partial class Admin_Home
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
            this.buttonGoforCitizen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGoforCitizen
            // 
            this.buttonGoforCitizen.Location = new System.Drawing.Point(75, 105);
            this.buttonGoforCitizen.Name = "buttonGoforCitizen";
            this.buttonGoforCitizen.Size = new System.Drawing.Size(114, 23);
            this.buttonGoforCitizen.TabIndex = 0;
            this.buttonGoforCitizen.Text = "Go for Citizen";
            this.buttonGoforCitizen.UseVisualStyleBackColor = true;
            this.buttonGoforCitizen.Click += new System.EventHandler(this.buttonGoforCitizen_Click);
            // 
            // Admin_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonGoforCitizen);
            this.Name = "Admin_Home";
            this.Text = "Admin_Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoforCitizen;
    }
}