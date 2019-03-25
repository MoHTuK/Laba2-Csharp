using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2_Csharp
{
    public partial class Form1 : Form
    {
        MainClass line = new MainClass();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            line.Lineexample(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            line.Lineparallelism(textBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            line.LineInfo(textBox3);
        }
    }
}
