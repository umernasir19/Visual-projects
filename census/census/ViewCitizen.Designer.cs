namespace census
{
    partial class ViewCitizen
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
            this.showdata = new System.Windows.Forms.DataGridView();
            this.textBoxtodeletecnic = new System.Windows.Forms.TextBox();
            this.labeldletecnic = new System.Windows.Forms.Label();
            this.Viewdata = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).BeginInit();
            this.SuspendLayout();
            // 
            // showdata
            // 
            this.showdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdata.Location = new System.Drawing.Point(0, 0);
            this.showdata.Name = "showdata";
            this.showdata.Size = new System.Drawing.Size(737, 179);
            this.showdata.TabIndex = 0;
            this.showdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdata_CellContentClick);
            // 
            // textBoxtodeletecnic
            // 
            this.textBoxtodeletecnic.Location = new System.Drawing.Point(164, 240);
            this.textBoxtodeletecnic.Name = "textBoxtodeletecnic";
            this.textBoxtodeletecnic.Size = new System.Drawing.Size(219, 20);
            this.textBoxtodeletecnic.TabIndex = 1;
            // 
            // labeldletecnic
            // 
            this.labeldletecnic.AutoSize = true;
            this.labeldletecnic.Location = new System.Drawing.Point(12, 247);
            this.labeldletecnic.Name = "labeldletecnic";
            this.labeldletecnic.Size = new System.Drawing.Size(146, 13);
            this.labeldletecnic.TabIndex = 2;
            this.labeldletecnic.Text = "Enter Cnic Number To Delete";
            // 
            // Viewdata
            // 
            this.Viewdata.Location = new System.Drawing.Point(599, 185);
            this.Viewdata.Name = "Viewdata";
            this.Viewdata.Size = new System.Drawing.Size(75, 23);
            this.Viewdata.TabIndex = 3;
            this.Viewdata.Text = "View all data";
            this.Viewdata.UseVisualStyleBackColor = true;
            this.Viewdata.Click += new System.EventHandler(this.Viewdata_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(164, 293);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(160, 23);
            this.Deletebutton.TabIndex = 4;
            this.Deletebutton.Text = "Delete button";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "<==";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewCitizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Viewdata);
            this.Controls.Add(this.labeldletecnic);
            this.Controls.Add(this.textBoxtodeletecnic);
            this.Controls.Add(this.showdata);
            this.Name = "ViewCitizen";
            this.Text = "ViewCitizen";
            this.Load += new System.EventHandler(this.ViewCitizen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showdata;
        private System.Windows.Forms.TextBox textBoxtodeletecnic;
        private System.Windows.Forms.Label labeldletecnic;
        private System.Windows.Forms.Button Viewdata;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button button1;
    }
}