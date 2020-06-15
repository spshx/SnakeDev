using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeDev
{
    class CorpoS
    {
        private Rectangle[]snake;
        private int x, y, width, height;
        public SolidBrush b;
        public Rectangle[] Snake
        {
            get { return snake; }
        }
        public CorpoS()
        {
         snake = new Rectangle[2];
         b = new SolidBrush(Color.Black);
            x = 100;
            y = 100;
            width = 10;
            height = 10;
            for (int i = 0; i < snake.Length; i++)
            {
                snake[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }
        public void disegnaserpente(Graphics p)
            {
           foreach (Rectangle rect in snake)   
            p.FillRectangle(b,rect);
            }
        public void disegnaserpente()
        {
            for (int i = snake.Length - 1; i > 0; i--)
            {
                snake[i] = snake[i - 1];
            }
        }
        public void Up()
        {
            disegnaserpente();
            snake[0].Y -= 10;
        }
        public void Down()
        {
            disegnaserpente();
            snake[0].Y += 10;
        }
        public void Right()
        {
            disegnaserpente();
            snake[0].X += 10;
        }
        public void Left()
        {
            disegnaserpente();
            snake[0].X -= 10;
        }
        public void coda()
        {
            List<Rectangle> coda = snake.ToList();
                coda.Add(new Rectangle(snake[snake.Length - 1].X,/*VIVA L'INDIA*/ snake[snake.Length - 1].Y, width, height));
                snake = coda.ToArray();

        }
        public void giocadinuovo() {
            List<Rectangle> coda = snake.ToList();
            coda = snake.ToList();
            for (int i = coda.Count - 1; i > 1; i--)
                coda.RemoveAt(i);
            snake = coda.ToArray();

           snake[0].X = 100;
            snake[0].Y = 100;
        }
    }
}