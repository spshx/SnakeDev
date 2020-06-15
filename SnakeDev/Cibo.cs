using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SnakeDev
{
    public class Cibo
    {
        private int x, y, height, width;
        public SolidBrush b;
        public Rectangle cibodamangiare;
        public Cibo(Random rnd,int x1, int y1) {
            x = rnd.Next(30,x1-10);
            y = rnd.Next(30, y1-10);
            b = new SolidBrush(Color.Black);
            width = 10;
            height = 10;
            cibodamangiare = new Rectangle(x,y,width,height);
        }
        public void cibolocation(Random rnd,int x1, int y1)
        {

            x = rnd.Next(30,x1-10);
            y = rnd.Next(30, y1-10);
        }
        public void disegnacibo(Graphics p)
        {
            cibodamangiare.X = x;
            cibodamangiare.Y = y;

            p.FillRectangle(b, cibodamangiare);
        }
        }
    }

