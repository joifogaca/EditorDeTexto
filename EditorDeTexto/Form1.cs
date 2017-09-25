using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string caminho = Path.Combine(pasta, "testando_vs.txt");

            if (File.Exists(caminho))
            {
                using(Stream arquivo = File.Open(caminho, FileMode.Open))
                using ( TextReader leitor = new StreamReader(arquivo))
                {
                    textoConteudo.Text = leitor.ReadToEnd();
                }
               
            }
            
        }

        private void botaoGrava_Click(object sender, EventArgs e)
        {
            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string caminho = Path.Combine(pasta, "testando_vs.txt");
            using(Stream arquivo = File.Open(caminho, FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(arquivo))
            {
                escritor.Write(textoConteudo.Text);
            
            }
            
           
        }
    }
}
