using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace SnakeDev
{
    public partial class Gioco : Form
    {
        public Gioco()
        {
       c = new Cibo(rnd, this.ClientSize.Width, this.ClientSize.Height);
            InitializeComponent();
        }
        CorpoS s = new CorpoS();
        Graphics p;
        Random rnd = new Random();
        int x, y;
        Cibo c;
        int punteggio;
        string nome = " ";
        bool Up = false, Left = false, Right = true, Down = false;
        private void Gioco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && Right == false)
            {
                Up = false;
                Right = false;
                Down = false;
                Left = true;
            }
            if (e.KeyCode == Keys.W && Down == false)
            {
                Left = false;
                Right = false;
                Down = false;
                Up = true;
            }
            if (e.KeyCode == Keys.S && Up == false)
            {
                Up = false;
                Left = false;
                Right = false;
                Down = true;
            }
            if (e.KeyCode == Keys.D && Left == false)
            {
                Up = false;
                Left = false;
                Down = false;
                Right = true;
            }

        }
        private void giocaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
           
            timer1.Enabled = true;
            s.giocadinuovo();
            c.cibolocation(rnd, this.ClientSize.Width, this.ClientSize.Height);
            punteggio = 0;
            Up = false;
            Left = false;
            Down = false;
            Right = true;
        }       
        private void facileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void medioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
        }

        private void difficileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 25;
        }

        private void proToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialogo d = new Dialogo();
            d.Show();
        }

        private void pausaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            riprendiToolStripMenuItem.Enabled = true;
            pausaToolStripMenuItem.Enabled = false;
            lblGameOver.Text = "PAUSA";
            lblGameOver.Location = new Point((this.ClientSize.Width / 2) - (lblGameOver.Width / 2), (this.ClientSize.Height / 2) - (lblGameOver.Height / 2));
            lblGameOver.Show();
        }

        private void riprendiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblGameOver.Hide();
            timer1.Enabled = true;
            riprendiToolStripMenuItem.Enabled = false;
            pausaToolStripMenuItem.Enabled = true;
        }

        private void creditiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sharma Sahil, Arcelli Lorenzo","Crediti");
          
        }

        private void maggioriInformazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizzato in c#, Anno 2016, Classe 4 H", "Maggiori Informazioni");
        }

        private void commandiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WASD", "Commandi");
        }

        private void Gioco_Load(object sender, EventArgs e)
        {

        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            nome = Dialogo.global.nome;
            punt.Text = "Score : " + punteggio.ToString();
            Random randonGen = new Random();
            
            i++;
            switch (i)
            {
                case 1:
                    s.b.Color = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
                    c.b.Color = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
                    break;
                case 2:
                    s.b.Color = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
                    c.b.Color = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
                    break;
            }
            if (i == 2)
                i = 0;

                if (Up) { s.Up();
               
            }
                if (Down) { s.Down();
                
            }
                if (Right) { s.Right();
                
            }
                if (Left) { s.Left();
                
            }
          
          
            for (int i = 0; i < s.Snake.Length; i++)
            {
               
                if (s.Snake[i].IntersectsWith(c.cibodamangiare))
                {
                    punteggio++;
                    c.cibolocation(rnd, this.ClientSize.Width, this.ClientSize.Height);
                    s.coda();
                }
            }
           
            this.Invalidate();
            collisione();
           
        }
        private void Gioco_Paint(object sender, PaintEventArgs e)
        {
            p = e.Graphics;
            s.disegnaserpente(p);
            c.disegnacibo(p);
        }
        public void collisione()
        {
         for (int i = 1; i < s.Snake.Length; i++)
            if (s.Snake[0].IntersectsWith(s.Snake[i]))
          {
                    lblGameOver.Text = "GAME OVER";
                   lblGameOver.Location = new Point((this.ClientSize.Width / 2) - (lblGameOver.Width / 2), (this.ClientSize.Height / 2) - (lblGameOver.Height / 2));
                    lblGameOver.Show();
            timer1.Enabled = false;
          }
            if ( s.Snake[0].X >= this.ClientSize.Width)
               s.Snake[0].X = 1;
            if (s.Snake[0].X <=0)
                s.Snake[0].X = this.ClientSize.Width;
            if (s.Snake[0].Y >= this.ClientSize.Height)
                s.Snake[0].Y = menu.Size.Height+1;
            if (s.Snake[0].Y <= menu.Size.Height )
                s.Snake[0].Y = this.ClientSize.Height;
        }





    }
}

