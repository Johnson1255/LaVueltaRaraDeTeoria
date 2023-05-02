using com.calitha.goldparser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCompilador
{
    public partial class Form1 : Form
    {
        MyParser analizador;
        public Form1()
        {
            analizador = new MyParser(Application.StartupPath + "\\GramaticaFinaly.cgt");
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Boton_analizar
        {
            analizador.Parse(richTextBox1.Text);
        }
    }
}
