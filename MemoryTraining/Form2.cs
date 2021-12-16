using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace MemoryTraining
{
    public partial class Form2 : Form
    {

        

        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        private void button_Clicked(object sender, EventArgs e)
        {
           
            string take = (sender as Button).Text;
            bool flag = false;
            foreach (var item in Class1.true_buttons)
            {
               if(item.Text == take)
               {
                    item.BackColor = Color.Yellow;
                    flag = true;
                    Class1.true_buttons.Remove(item);
                    break;

                }
               
               
            }
            if(!flag)
            {

                Class1.wins = 0;
                label1.Text = "Level: "+ Class1.wins.ToString();
                MessageBox.Show("YOU LOSE");
            }


            
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //CLEAR MASSIVES
            Class1.point.Y = 0;
            Class1.point.X = 0;
           
            
            
            foreach (var item in Class1.all_controls)
            {
                this.Controls.Remove(item);
            }

            Class1.all_controls.Clear();
            Class1.true_buttons.Clear();








            //ADD MASSIVES
            Class1.matric_size = Convert.ToInt32(comboBox1.Text);
            int counter = 0;
            if(Class1.matric_size > 5)
            {
                for (int i = 0; i < Class1.matric_size; i++)
                {


                    for (int j = 0; j < Class1.matric_size; j++)
                    {
                        Button button = new Button();
                        button.Text = counter.ToString();
                        button.ForeColor = Color.Gray;
                        button.Click += new System.EventHandler(this.button_Clicked);
                        button.Width = 50;
                        button.Height = 50;
                        button.BackColor = Color.Gray;
                        button.Location = Class1.point;
                        this.Controls.Add(button);
                        
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
                        Button button = new Button();
                        button.ForeColor = Color.Gray;
                        button.Text = counter.ToString();
                        button.Click += new System.EventHandler(this.button_Clicked);
                        button.Width = 100;
                        button.Height = 100;
                        button.BackColor = Color.Gray;
                        button.Location = Class1.point;
                        this.Controls.Add(button);
                        Class1.all_controls.Add(button);
                        Class1.point.X += 100;
                        counter++;
                    }
                    Class1.point.Y += 100;
                    Class1.point.X = 0;
                }
            }



            //RANDOM YELLOW
            Random random = new Random();
            List<int> statics_nums = new List<int>();
            statics_nums.Add(0);
            bool flag = false;
            for (int j = 0; j < Class1.matric_size * 2; j++)
            {
                int r_num = random.Next(1, Class1.matric_size * Class1.matric_size);
                foreach(var item in statics_nums)
                {
                    if(item == r_num)
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                   
                }
                if(flag)
                {
                    statics_nums.Add(r_num);
                    Class1.all_controls[r_num].BackColor = Color.Yellow;
                    Class1.true_buttons.Add(Class1.all_controls[r_num]);
                }
              

            }

           

            timer1.Start();
            timer2.Start();



            //ALL GRAY












        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            for (int j = 0; j < Class1.matric_size * Class1.matric_size; j++)
            {

                Class1.all_controls[j].BackColor = Color.Gray;

            }
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(Class1.true_buttons.Count == 0)
            {
               
                timer2.Stop();
                Class1.wins++;
                label1.Text = "Level: " + Class1.wins.ToString();
                MessageBox.Show("YOU WIN");
            }
        }
    }
}
