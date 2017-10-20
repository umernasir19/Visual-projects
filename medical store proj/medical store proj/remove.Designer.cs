namespace medical_store_proj
{
    partial class remove
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
            this.datagridmedicine = new System.Windows.Forms.DataGridView();
            this.dletmedicinelabel = new System.Windows.Forms.Label();
            this.medicinetodeletetextbox = new System.Windows.Forms.TextBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.totaldatabutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridmedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridmedicine
            // 
            this.datagridmedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridmedicine.Location = new System.Drawing.Point(0, 0);
            this.datagridmedicine.Name = "datagridmedicine";
            this.datagridmedicine.Size = new System.Drawing.Size(334, 150);
            this.datagridmedicine.TabIndex = 0;
            this.datagridmedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridmedicine_CellContentClick);
            // 
            // dletmedicinelabel
            // 
            this.dletmedicinelabel.AutoSize = true;
            this.dletmedicinelabel.Location = new System.Drawing.Point(-3, 166);
            this.dletmedicinelabel.Name = "dletmedicinelabel";
            this.dletmedicinelabel.Size = new System.Drawing.Size(134, 13);
            this.dletmedicinelabel.TabIndex = 1;
            this.dletmedicinelabel.Text = "name of medicine to delete";
            // 
            // medicinetodeletetextbox
            // 
            this.medicinetodeletetextbox.Location = new System.Drawing.Point(0, 193);
            this.medicinetodeletetextbox.Name = "medicinetodeletetextbox";
            this.medicinetodeletetextbox.Size = new System.Drawing.Size(100, 20);
            this.medicinetodeletetextbox.TabIndex = 2;
            this.medicinetodeletetextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(247, 236);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 3;
            this.deletebutton.Text = "delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // totaldatabutton
            // 
            this.totaldatabutton.Location = new System.Drawing.Point(247, 156);
            this.totaldatabutton.Name = "totaldatabutton";
            this.totaldatabutton.Size = new System.Drawing.Size(75, 23);
            this.totaldatabutton.TabIndex = 4;
            this.totaldatabutton.Text = "show total data";
            this.totaldatabutton.UseVisualStyleBackColor = true;
            this.totaldatabutton.Click += new System.EventHandler(this.totaldatabutton_Click);
            // 
            // remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.totaldatabutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.medicinetodeletetextbox);
            this.Controls.Add(this.dletmedicinelabel);
            this.Controls.Add(this.datagridmedicine);
            this.Name = "remove";
            this.Text = "remove";
            ((System.ComponentModel.ISupportInitialize)(this.datagridmedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridmedicine;
        private System.Windows.Forms.Label dletmedicinelabel;
        private System.Windows.Forms.TextBox medicinetodeletetextbox;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button totaldatabutton;
    }
}