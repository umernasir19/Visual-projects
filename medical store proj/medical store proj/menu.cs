using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_store_proj
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addstock add = new addstock();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewstock view = new viewstock();
            view.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update updte = new update();
            updte.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            remove remove = new remove();
            remove.Show();
        }
    }
}
