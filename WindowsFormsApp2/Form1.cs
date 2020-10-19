using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O My GoD YOU CRAZZY");
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            button2.Location = new Point(button2.Location.X + rnd.Next(-15, 15), button2.Location.Y + rnd.Next(-15, 15));
        }
    }
}
