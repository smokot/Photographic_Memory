using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace MemoryTraining
{
    public static class Class1
    {
        static public Point point = new Point();
        static public int matric_size = 0;
        static public List<Button> all_controls = new List<Button>();
        static public List<Button> true_buttons = new List<Button>();
        static public List<PictureBox> all_pictures = new List<PictureBox>();
        static public List<PictureBox> save_pictures = new List<PictureBox>();
        static public PictureBox picture = new PictureBox();
        static public List<Color> save_colors= new List<Color>();
        static public int counter = 0;
        static public int wins = 0;
        static public string word = "";
        static public Color color;
        static public List<PictureBox> click_pictures = new List<PictureBox>();
        static public bool flag=true;
    }
}
