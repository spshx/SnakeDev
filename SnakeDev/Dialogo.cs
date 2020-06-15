using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeDev
{
    public partial class Dialogo : Form
    {
        public Dialogo()
        {
            InitializeComponent();
        }
        public class global
        {
            public static string nome;

        }
        private void Dialogo_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            global.nome = txt.Text;
            this.Close();

    }
    }
}
