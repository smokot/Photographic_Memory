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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button_Clicked(object sender, EventArgs e)
        {

            string take = (sender as Button).Text;
            int count_true = 0;
            for (int i = 0; i < Class1.all_controls.Count;i++)
            {
                if (Class1.all_controls[i].Text == take)
                {
                    
                    Class1.all_controls[i].ForeColor = Class1.color;
                    Class1.all_controls[i].BackColor = Class1.color;
                    break;
                }
               
            }

            

            for (int i = 0; i < Class1.all_controls.Count; i++)
            {
                if (Class1.all_controls[i].BackColor == Class1.save_colors[i])
                {
                    count_true++;
                    
                }
                if (count_true == Class1.all_controls.Count)
                {
                    Class1.wins++;
                    label1.Text = Class1.wins.ToString();
                    MessageBox.Show("YOU WIN");
                    break;
                }
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            Class1.point.Y = 0;
            Class1.point.X = 0;


            foreach (var item in Class1.all_controls)
            {
                this.Controls.Remove(item);
            }

            Class1.all_controls.Clear();
            Class1.true_buttons.Clear();
            Class1.save_colors.Clear();



            List<Color> colors = new List<Color>() { Color.Gray,Color.Yellow,Color.Black, Color.Blue,Color.Red };



            //ADD MASSIVES
            Class1.matric_size = Convert.ToInt32(comboBox1.Text);
            int counter = 0;
            Random randomize = new Random();

            if (Class1.matric_size > 5)
            {
                for (int i = 0; i < Class1.matric_size; i++)
                {


                    for (int j = 0; j < Class1.matric_size; j++)
                    {
                        int r_number= randomize.Next(0, 5);

                        Button button = new Button();
                        button.Text = counter.ToString();
                        button.ForeColor = colors[r_number];
                        button.Click += new System.EventHandler(this.button_Clicked);
                        button.Width = 50;
                        button.Height = 50;
                        button.BackColor = colors[r_number];
                        button.Location = Class1.point;
                        this.Controls.Add(button);
                        Class1.save_colors.Add(colors[r_number]);
                        Class1.all_controls.Add(button);
                        Class1.point.X += 50;
                        counter++;
                    }
                    Class1.point.Y += 50;
                    Class1.point.X = 0;
                }
            }
            else
            {
                for (int i = 0; i < Class1.matric_size; i++)
                {


                    for (int j = 0; j < Class1.matric_size; j++)
                    {
                        int r_number = randomize.Next(0, 5);
                        Button button = new Button();
                        button.ForeColor = colors[r_number];
                        button.Text = counter.ToString();
                        button.Click += new System.EventHandler(this.button_Clicked);
                        button.Width = 100;
                        button.Height = 100;
                        button.BackColor = colors[r_number];
                        button.Location = Class1.point;
                        this.Controls.Add(button);
                        Class1.save_colors.Add(colors[r_number]);
                        Class1.all_controls.Add(button);
                        Class1.point.X += 100;
                        counter++;
                    }
                    Class1.point.Y += 100;
                    Class1.point.X = 0;
                }
            }



         


            timer1.Interval = Convert.ToInt32(comboBox2.SelectedItem)*1000;
            timer1.Start();

        
           

            //ALL GRAY




        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            for (int j = 0; j < Class1.all_controls.Count; j++)
            {
                
                Class1.all_controls[j].BackColor = Color.GhostWhite;
                Class1.all_controls[j].ForeColor = Color.GhostWhite;
               
            }
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            button1.Enabled = false;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Yellow;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Blue;
            button6.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.color = Color.Gray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1.color = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.color = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class1.color = Color.Blue;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Class1.color = Color.Red;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
