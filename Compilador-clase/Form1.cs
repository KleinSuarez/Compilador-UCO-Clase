using Compilador_clase.AnalisisLexico;
using Compilador_clase.Transversal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador_clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cargar la caché

            //Disparar análisis Léxico
            AnalizadorLexico analizador = new AnalizadorLexico();
            ComponenteLexico Componente = analizador.DevolverComponenteLexico();
            
            while (!Categoria.FIN_ARCHIVO.Equals(Componente.ObtenerCategoria()))
            {
                MessageBox.Show(Componente.ToString());
                Componente = analizador.DevolverComponenteLexico();
            }

            MessageBox.Show("Análisis finalizado.");
        }
    }
}
