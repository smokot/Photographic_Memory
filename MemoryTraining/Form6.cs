using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryTraining
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Point point = new Point();
            point.X = 50;
            point.Y = 500;

            Point point2 = new Point();
            point2.X = 50;
            point2.Y = 50;

            Pen pen = new Pen(Color.Black, 5f);

            graphics.DrawLine(pen, point, point2);
        }
    }
}
