using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GraphicSandboxLB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MeasureText1(object sender, PaintEventArgs e)
        {
            String text1 = "Lorem ipsum dolor et qvibius hasta manana";
            Font tnr = new Font("Times New Roman", 11.0F);
            Size textSize = TextRenderer.MeasureText(text1, tnr);
            TextRenderer.DrawText(e.Graphics, text1, tnr,
                new Rectangle(new Point(10, 10), textSize), Color.Black);
            Debug.WriteLine("this is width : " + Size.Width);
            Debug.WriteLine("and height : " + Size.Height);
            Debug.WriteLine(e.Graphics.MeasureString(text1, tnr).Width);
            
        }
    }
}
