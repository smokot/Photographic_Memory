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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        List<int> bubble_sort(List<int>Array)
        {
            List<int> Array_Return = new List<int>();

            for(int i = 0; i < Array.Count;i++)
            {
                for (int j = 0; j < Array.Count; j++)
                {
                    
                }
            }



            return Array_Return;
        }

        private void button_Clicked(object sender, EventArgs e)
        {

            PictureBox take = (sender as PictureBox);
            take.BackgroundImage = Class1.picture.BackgroundImage;
            Point point = new Point();
            point = take.Location;
            int tag = Convert.ToInt32(Class1.picture.Tag);
            
            for(int i = 0; i < Class1.all_pictures.Count;i++)
            {
                if(point == Class1.all_pictures[i].Location)
                {
                    Class1.all_pictures[i].Tag = Class1.picture.Tag;
                    break;
                }
            }

            int counter = 0;
            for (int i = 0; i < Class1.all_pictures.Count; i++)
            {
                if(Convert.ToInt32(Class1.all_pictures[i].Tag) == Convert.ToInt32(Class1.save_pictures[i].Tag))
                {
                    counter++;
                }
                   
            }


            if (counter == Class1.all_pictures.Count)
            {
                MessageBox.Show("YUO WIN");
            }

            
        }

        void visibile(bool x)
        {
            pictureBox1.Visible = x;
            pictureBox2.Visible = x;
            pictureBox3.Visible = x;
            pictureBox4.Visible = x;
            pictureBox5.Visible = x;
            pictureBox6.Visible = x;
            pictureBox7.Visible = x;
            pictureBox8.Visible = x;
            pictureBox9.Visible = x;
            pictureBox10.Visible = x;
            pictureBox11.Visible = x;
            pictureBox12.Visible = x;
            pictureBox13.Visible = x;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            visibile(false);




            Class1.point.Y = 0;
            Class1.point.X = 0;


            foreach (var item in Class1.all_pictures)
            {
                this.Controls.Remove(item);
            }

            Class1.all_pictures.Clear();
            Class1.save_pictures.Clear();
            Class1.click_pictures.Clear();
            Class1.counter = 0;



            List<Color> colors = new List<Color>() { Color.Gray, Color.Yellow, Color.Black, Color.Blue, Color.Red };



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
                        int r_number = randomize.Next(0, imageList1.Images.Count);

                        PictureBox picture = new PictureBox();
                        picture.BackgroundImage = imageList1.Images[r_number];
                        picture.BackgroundImageLayout = ImageLayout.Stretch;
                        picture.Width = 50;
                        picture.Height = 50;
                        
                        picture.Location = Class1.point;
                        picture.BorderStyle = BorderStyle.FixedSingle;
                        picture.Click += new System.EventHandler(button_Clicked);
                        this.Controls.Add(picture);


                        if (r_number > 11)
                        {
                            picture.Tag = 228;
                        }
                        else
                        {
                            picture.Tag = r_number;
                        }
                        PictureBox picture_to_save = new PictureBox();
                        picture_to_save.BackgroundImage = imageList1.Images[r_number];
                        picture_to_save.BackgroundImageLayout = ImageLayout.Stretch;
                        picture_to_save.Width = 50;
                        picture_to_save.Height = 50;
                        picture_to_save.Location = Class1.point;
                        picture_to_save.BorderStyle = BorderStyle.FixedSingle;
                        picture_to_save.Click += new System.EventHandler(button_Clicked);
                        picture_to_save.BackgroundImage = imageList1.Images[r_number];

                        if (r_number > 11)
                        {
                            picture_to_save.Tag = 228;
                        }
                        else
                        {
                            picture_to_save.Tag = r_number;
                        }
                        Class1.save_pictures.Add(picture_to_save);
                        Class1.all_pictures.Add(picture);
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
                        int r_number = randomize.Next(0, imageList1.Images.Count);

                        PictureBox picture = new PictureBox();
                        picture.BackgroundImage = imageList1.Images[r_number];
                        picture.BackgroundImageLayout = ImageLayout.Stretch;
                        picture.Width = 100;
                        picture.Height = 100;
                        if (r_number > 11)
                        {
                            picture.Tag = 228;
                        }
                        else
                        {
                            picture.Tag = r_number;
                        }
                        picture.Location = Class1.point;
                        picture.BorderStyle = BorderStyle.FixedSingle;
                        picture.Click += new System.EventHandler(button_Clicked);
                        this.Controls.Add(picture);



                        PictureBox picture_to_save = new PictureBox();
                        picture_to_save.BackgroundImage = imageList1.Images[r_number];
                        picture_to_save.BackgroundImageLayout = ImageLayout.Stretch;
                        picture_to_save.Width = 100;
                        picture_to_save.Height = 100;
                        picture_to_save.Location = Class1.point;
                        picture_to_save.BorderStyle = BorderStyle.FixedSingle;
                        picture_to_save.Click += new System.EventHandler(button_Clicked);
                        picture_to_save.BackgroundImage = imageList1.Images[r_number];
                        if (r_number > 11)
                        {
                            picture_to_save.Tag = 228;
                        }
                        else
                        {
                            picture_to_save.Tag = r_number;
                        }

                        Class1.save_pictures.Add(picture_to_save);
                        Class1.all_pictures.Add(picture);
                        Class1.point.X += 100;
                        counter++;
                    }
                    Class1.point.Y += 100;
                    Class1.point.X = 0;
                }
            }






            timer1.Interval = Convert.ToInt32(comboBox2.SelectedItem) * 1000;
            timer1.Start();

           


            //ALL GRAY

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
           

            comboBox2.Enabled = false;
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < Class1.all_pictures.Count; i++)
            {
                Class1.all_pictures[i].BackgroundImage = imageList1.Images[12];
                Class1.all_pictures[i].Tag = 228;
            }


            timer1.Stop();
            visibile(true);
            pictureBox1.BackgroundImage = imageList1.Images[0];
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;

            pictureBox2.BackgroundImage = imageList1.Images[1];
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;

            pictureBox3.BackgroundImage = imageList1.Images[2];
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;


            pictureBox4.BackgroundImage = imageList1.Images[3];
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;


            pictureBox5.BackgroundImage = imageList1.Images[4];
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;

            pictureBox6.BackgroundImage = imageList1.Images[5];
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;

            pictureBox7.BackgroundImage = imageList1.Images[6];
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;

            pictureBox8.BackgroundImage = imageList1.Images[7];
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;


            pictureBox9.BackgroundImage = imageList1.Images[8];
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.BorderStyle = BorderStyle.FixedSingle;

            pictureBox10.BackgroundImage = imageList1.Images[9];
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.BorderStyle = BorderStyle.FixedSingle;

            pictureBox11.BackgroundImage = imageList1.Images[10];
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox11.BorderStyle = BorderStyle.FixedSingle;

            pictureBox12.BackgroundImage = imageList1.Images[11];
            pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox12.BorderStyle = BorderStyle.FixedSingle;

            pictureBox13.BackgroundImage = imageList1.Images[12];
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox13.BorderStyle = BorderStyle.FixedSingle;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Class1.picture.X = imageList1.Images[0].Height;
            //Class1.picture.Y = imageList1.Images[0].Width;
            Class1.picture.BackgroundImage = pictureBox1.BackgroundImage;
            Class1.picture.Tag = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Class1.picture.BackgroundImage = pictureBox2.BackgroundImage;
            Class1.picture.Tag = 1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Class1.picture.BackgroundImage = pictureBox4.BackgroundImage;
            Class1.picture.Tag = 3;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Class1.picture.BackgroundImage = pictureBox3.BackgroundImage;
            Class1.picture.Tag = 2;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Class1.picture.BackgroundImage = pictureBox6.BackgroundImage;
            Class1.picture.Tag = 5;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Class1.picture.BackgroundImage = pictureBox5.BackgroundImage;
            Class1.picture.Tag = 4;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Class1.picture.BackgroundImage = pictureBox10.BackgroundImage;
            Class1.picture.Tag = 9;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Class1.picture.BackgroundImage = pictureBox8.BackgroundImage;
            Class1.picture.Tag = 7;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Class1.picture.BackgroundImage = pictureBox12.BackgroundImage;
            Class1.picture.Tag = 11;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Class1.picture.BackgroundImage = pictureBox11.BackgroundImage;
            Class1.picture.Tag = 10;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Class1.picture.BackgroundImage = pictureBox7.BackgroundImage;
            Class1.picture.Tag = 6;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Class1.picture.BackgroundImage = pictureBox9.BackgroundImage;
            Class1.picture.Tag = 8;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Class1.picture.BackgroundImage = pictureBox13.BackgroundImage;
            Class1.picture.Tag = 228;
        }
    }
}
