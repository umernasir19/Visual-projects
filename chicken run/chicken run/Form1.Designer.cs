namespace chicken_run
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.chicken = new System.Windows.Forms.PictureBox();
            this.bottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Chartreuse;
            this.score.Location = new System.Drawing.Point(398, 309);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(65, 13);
            this.score.TabIndex = 2;
            this.score.Text = "Score board";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::chicken_run.Properties.Resources.jump2;
            this.obstacle1.Location = new System.Drawing.Point(301, 195);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(100, 92);
            this.obstacle1.TabIndex = 4;
            this.obstacle1.TabStop = false;
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::chicken_run.Properties.Resources.jump2;
            this.obstacle2.Location = new System.Drawing.Point(725, 205);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(100, 92);
            this.obstacle2.TabIndex = 3;
            this.obstacle2.TabStop = false;
            // 
            // chicken
            // 
            this.chicken.Image = global::chicken_run.Properties.Resources.chickenstand2;
            this.chicken.Location = new System.Drawing.Point(12, 187);
            this.chicken.Name = "chicken";
            this.chicken.Size = new System.Drawing.Size(100, 100);
            this.chicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.chicken.TabIndex = 1;
            this.chicken.TabStop = false;
            this.chicken.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.Color.Goldenrod;
            this.bottom.Location = new System.Drawing.Point(2, 293);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(858, 50);
            this.bottom.TabIndex = 0;
            this.bottom.TabStop = false;
            this.bottom.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chicken_run.Properties.Resources.dayback3;
            this.ClientSize = new System.Drawing.Size(857, 345);
            this.Controls.Add(this.chicken);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.score);
            this.Controls.Add(this.bottom);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bottom;
        private System.Windows.Forms.PictureBox chicken;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox obstacle1;
    }
}

