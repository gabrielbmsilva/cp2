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

namespace Trabalho_2C
{
    public partial class Form1 : Form
    {
        string diretorioAtual;

        public Form1()
        {
            InitializeComponent();

            // Esse método retornará o diretório de onde o programa está rodando.
            // Geralmente, o programa é um arquivo .exe armazenado na pasta bin do projeto.
            // Armazenar o diretório da pasta de questões dessa forma torna o programa independente do computador,
            // ou seja, não precisamos nos preocupar com o caminho que mudará de máquina para máquina
            diretorioAtual = Directory.GetCurrentDirectory();

            diretorioAtual += @"\Questões\";

            string[] diretorios = Directory.GetDirectories(diretorioAtual);

            foreach(string diretorio in diretorios)
            {
                string nomeDaDisciplina = diretorio.Remove(0, diretorioAtual.Length);
                comboBox1.Items.Add(nomeDaDisciplina);
            }
        }
    }
}
