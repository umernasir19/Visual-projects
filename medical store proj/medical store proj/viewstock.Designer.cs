namespace medical_store_proj
{
    partial class viewstock
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
            this.viewbutton = new System.Windows.Forms.Button();
            this.showdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).BeginInit();
            this.SuspendLayout();
            // 
            // viewbutton
            // 
            this.viewbutton.Location = new System.Drawing.Point(178, 226);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(75, 23);
            this.viewbutton.TabIndex = 2;
            this.viewbutton.Text = "View";
            this.viewbutton.UseVisualStyleBackColor = true;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // showdata
            // 
            this.showdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdata.Location = new System.Drawing.Point(23, 12);
            this.showdata.Name = "showdata";
            this.showdata.Size = new System.Drawing.Size(438, 150);
            this.showdata.TabIndex = 3;
            // 
            // viewstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 261);
            this.Controls.Add(this.showdata);
            this.Controls.Add(this.viewbutton);
            this.Name = "viewstock";
            this.Text = "viewstock";
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewbutton;
        private System.Windows.Forms.DataGridView showdata;
    }
}