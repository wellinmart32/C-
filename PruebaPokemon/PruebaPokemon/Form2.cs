using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PruebaPokemon
{
    public partial class Form2 : Form
    {
        public int pi;
        public Form2(int pos_img)
        {
            pi = pos_img + 1;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbpoke_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int cont = 1;
            while (cont != pi)
                cont = cont + 1;
            pbpoke.Image = Image.FromFile("imagenes/img" + cont + ".png");
        }
    }
}
