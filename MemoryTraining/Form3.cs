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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label1.Enabled = false;
            textBox1.Enabled = false;
            comboBox1.Enabled = false ;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public string reverse_word(string x)
        {
            string exit = "";
            for(int i = x.Length-1; i >= 0; i--)
            {
                exit += x[i];
            }
            return exit;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == reverse_word(Class1.word))
            {
                
                MessageBox.Show("YOU WIN");
                button1.PerformClick();
                textBox1.Text = "";
                textBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Enabled = false;
            label1.Text = "";
            label1.Enabled = true;
            List<char> words_eng = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<char> words_rus = new List<char>() { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', };


            Random random = new Random();
            //int choice = random.Next(0, 2);
            int choice = 0;
            if (comboBox2.SelectedItem == "РУС")
                choice = 1;
            else
                choice = 0;
            
            if(choice == 0)
            {
                int count = Convert.ToInt32(comboBox1.SelectedItem);
                string take_word = "";
                for (int i = 0; i < count; i++)
                {
                    int size = random.Next(0, words_eng.Count);
                    take_word += words_eng[size].ToString();

                }
                label1.Text = take_word;
                Class1.word = take_word;
                timer1.Start();
            }

            if (choice == 1)
            {
                int count = Convert.ToInt32(comboBox1.SelectedItem);
                string take_word = "";
                for (int i = 0; i < count; i++)
                {
                    int size = random.Next(0, words_rus.Count);
                    take_word += words_rus[size].ToString();

                }
                label1.Text = take_word;
                Class1.word = take_word;
                timer1.Start();
            }





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Enabled = true;
            textBox1.Focus();
            label1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }
    }
}
