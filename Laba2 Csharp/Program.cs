using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2_Csharp
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }


    }


    class MainClass
    {

        Line line1 = new Line((float)2, (float)4, (float)1, (float)6);
        Line line2 = new Line((float)3, (float)1, (float)2, (float)4);

        public void Lineexample(TextBox field)
        {


            field.Text = "Line example : " + line1.LineEquation() + "Line example 2 : " + line2.LineEquation();
        }    
        
        public void Lineparallelism(TextBox field)
        {
            double k1, k2,cos,angl;
            


           

            k1 = (line1.y2 - line1.y1) / (line1.x2 - line1.x1);

            k2 = (line2.y2 - line2.y1) / (line2.x2 - line2.x1);

            cos = ((((( k1 * k2) + 1) / ((Math.Sqrt(( k1* k1) + 1)) * (Math.Sqrt((k2 * k2) + 1))))));
            angl = cos;

            if (k1 == k2)
                field.Text = "Угл.коеф 1 = " + k1 + " |  Угл.коеф 2 = " + k2 + " | Прямые паралельны";
            else
                field.Text = "Угл.коеф 1 = " + k1 + " |  Угл.коеф 2 = " + k2 + " | Прямые не паралельны" + " Угол между прямыми = "+angl;



        }

        public void LineInfo(TextBox field)
        {
            field.Text = "Прямая AB : " + "A(" + line1.x1 + ";" + line1.y1 + ")" + "B(" + line1.x2 + ";" + line1.y2 + ")" + "  Прямая CD : " + "C(" + line2.x1 + ";" + line2.y1 + ")" + "D(" + line2.x2 + ";" + line2.y2 + ")";
        }

        class Line
        {
            public float x1, y1, x2, y2;

            public Line(float X1,float Y1,float X2,float Y2)
            {
                this.x1 = X1;
                this.y1 = Y1;
                this.x2 = X2;
                this.y2 = Y2;

            }



            public string LineEquation()
            {
                float x, y,xy;
                string symbol;

                y = (float)(this.y1 - this.y2);
                x = (float)(this.x2 - this.x1);
                xy = (float)(this.x1 * this.y2 - this.x2 * this.y1);

                if (xy > 0)
                    symbol = "+";
                else
                    symbol = "-";
                

                return y + "x " + x + "y " + symbol + xy+" = 0 ";

            }


        }

    }
}
