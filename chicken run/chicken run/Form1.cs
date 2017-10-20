using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chicken_run
{
    public partial class Form1 : Form
    {
        game Game = new game();

       


        int TimerCounter = 0;
        byte Player_position = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void score_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer2.Start();
            timer3.Start();
        }

        void playerjump()
        {
            TimerCounter++;
            if (TimerCounter <= 10)
            {
               chicken.Location = new Point(chicken.Location.X +0, chicken.Location.Y - 10); //move right and above

            }
            else if (TimerCounter > 10 && TimerCounter <= 15)
            {
                chicken.Location = new Point(chicken.Location.X +0, chicken.Location.Y + 10);
            }
            else if (TimerCounter > 15 && TimerCounter <= 20)
            {
                chicken.Location = new Point(chicken.Location.X + 0, chicken.Location.Y - 10);
            }
            else if (TimerCounter > 20 && TimerCounter <= 30)
            {
                chicken.Location = new Point(chicken.Location.X + 0, chicken.Location.Y + 10);
            }
            else
            {
                // timer1.Enabled = false;
                timer1.Stop();
                TimerCounter = 0;
                Player_position -= 1;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }


         
    }
}
