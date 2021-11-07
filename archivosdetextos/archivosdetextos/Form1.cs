using System;
using System.IO;
using System.Windows.Forms;

namespace archivosdetextos
{
    public partial class FrmPluma : Form
    {
        Pluma[] arreglopl;
        int pl = 0;

        public FrmPluma()
        {
            InitializeComponent();
            arreglopl = new Pluma[3];
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LblColor_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            if (OpenFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string filePath = OpenFileDialog1.FileName;
            pl = 0;

            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(filePath))
            {
                string[] datos;
                datos = line.Split('-');
                Pluma n = new Pluma();
                n.Color = datos[0];
                n.Tipo = datos[0];
                //guardar el libro en la posicion
                arreglopl[pl] = n;
                lst.Items.Add(arreglopl[pl]);
                pl++;

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter archivo = new StreamWriter(dialogo.FileName))
                    for (int i = 0; i < arreglopl.Length; i++)
                    {
                        if (arreglopl[i] != null)
                        {
                            archivo.WriteLineAsync(arreglopl[i].ToString());
                        }

                    }
            }
        }
        private void BtnInsertar_Click(object sender, EventArgs e)


        {
            Pluma n = new Pluma();
            n.Color = TxtColor.Text;
            n.Tipo = TxtTipo.Text;
            //guardar el libro en la posicion
            arreglopl[pl] = n;
            //para verlo en la lista 
            lst.Items.Add(arreglopl[pl]);
            pl++;
        }
                

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmPluma_Load(object sender, EventArgs e)
        {

        }
    }
}
