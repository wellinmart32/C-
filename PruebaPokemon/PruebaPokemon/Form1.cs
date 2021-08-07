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
    public partial class Form1 : Form
    {
        ListViewGroup pokemones;
        public int intpos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pokemones = new ListViewGroup("Pokemones", HorizontalAlignment.Center);
            ImageList misImagenes = new ImageList();
            misImagenes.ImageSize = new Size(100, 100);

            string[] archivos = Directory.GetFiles("imagenes");
            try
            {
                foreach (string archivo in archivos)
                    misImagenes.Images.Add(Image.FromFile(archivo));
            }catch
            {
                MessageBox.Show("Algo salio mal al cargar.");
            }
            pokemonlist.SmallImageList = misImagenes;
            pokemonlist.Items.Add(new ListViewItem("Pokemon1", 0, pokemones));
            pokemonlist.Items.Add(new ListViewItem("Pokemon2", 1, pokemones));
            pokemonlist.Items.Add(new ListViewItem("Pokemon3", 2, pokemones));
            pokemonlist.Groups.Add(pokemones);

            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pokemonlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //String seleccion = txtPokemon.Text;
            //pokemonlist = new ListView();
            //pokemonlist.Items.Add(new ListViewItem("Pokemon1", 0, pokemones));
        }

        private void pokemonlist_MouseClick(object sender, MouseEventArgs e)
        {
            intpos = pokemonlist.SelectedItems[0].Index;
            Form2 MiVentana = new Form2(intpos);
            MiVentana.Owner = this;
            MiVentana.ShowDialog();
        }
    }
}
