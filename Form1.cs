using Compilador_clase.AnalisisLexico;
using Compilador_clase.Transversal;
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

namespace Compilador_clase
{
    public partial class Form1 : Form
    {
        OpenFileDialog OpenFile = new OpenFileDialog();
        string ArchivoReference, ActualLinea;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Disparar análisis Léxico
            AnalizadorLexico analizador = new AnalizadorLexico();
            ComponenteLexico Componente = analizador.DevolverComponenteLexico();
            
            while (!Categoria.FIN_ARCHIVO.Equals(Componente.ObtenerCategoria()))
            {
                MessageBox.Show(Componente.ToString());
                Componente = analizador.DevolverComponenteLexico();
            }

            MessageBox.Show("Análisis finalizado.");

            LlenarTablas();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RbtnArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnArchivo.Checked) // SI EL USUARIO ELIGE ESA OPCIÓN, ENTONCES CAMBIAMOS LA GRAFICA
            {
                BtnCarga.Show();

                // BtnCarga.Location = new Point(656, 14);
                TxtArchivo.Show();
                txtConsola.Hide();
                BtnCarga.Location = new Point(512, 44);
                //this.Width = 845;
                //this.Height = 351;
                this.CenterToScreen();
            }
        }

        private void RbtnConsola_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnConsola.Checked)// SI EL USUARIO ELIGE ESA OPCIÓN, ENTONCES SE MUEVE EL BOTON DE CARGA
            {
                BtnCarga.Show();
                txtConsola.Show();
                TxtArchivo.Hide();
                TxtArchivo.ResetText();
                BtnCarga.Location = new Point(210, 187);

            }
        }

        private void BtnCarga_Click(object sender, EventArgs e)
        {
            Cache.INSTANCIA.ReiniciarCache();
            if (RbtnArchivo.Checked)
            {
                AbrirArchivo();
                TxtArchivo.Text = ArchivoReference;
                if (TxtArchivo.Text.Length > 0)
                {
                    ArchivoReference = "";
                }
                BtnCarga.Hide();
            }
            else if (RbtnConsola.Checked)
            {
                readconsole();
                BtnCarga.Hide();
                this.CenterToScreen();

            }
            else
            {
                MessageBox.Show("Por favor selecciona una opción", "Enginners Code", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void AbrirArchivo()
        {
            try
            {
                OpenFile.Filter = "Text Files(.txt)| *.txt"; // mostrarme solo los archivos .txt

                // OpenFileDialog.ShowDialog() nos ayuda a abrir una ventana para buscar el archivo
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    ArchivoReference = OpenFile.FileName; // obtener la referencia del archivo
                    StreamReader streamReader = new StreamReader(ArchivoReference);  // leer el archivo

                    while (true)
                    {
                        ActualLinea = streamReader.ReadLine(); // retorna la linea actual
                        Cache.INSTANCIA.AgregarLinea(ActualLinea);

                        if (streamReader.EndOfStream) // si termina de leer el archivo completamente, parame el Stream y dale un break al Bucle While
                        {
                            streamReader.Close();
                            break;
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se ocurre un error...\nIntente de nuevo!", "DEV COP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readconsole()
        {

            string[] lineas = txtConsola.Text.Split('\n');
            for (int i = 0; i < lineas.Length; i++)
            {
                Cache.INSTANCIA.AgregarLinea(lineas[i]);
            }

        }

        private void LlenarTablas()
        {
            LlenarTablaSimbolos();
        }

        private void LlenarTablaSimbolos()
        {
            int tamaño = TablaSimbolos.TablaSimbolos.ObtenerInstancia().ObtenerComponentes().Count;
            for (int i = 0; i < tamaño; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();

                fila.Cells[0].Value = TablaSimbolos.TablaSimbolos.INSTANCIA.ObtenerComponentes()[i].ObtenerLexema();
                fila.Cells[1].Value = TablaSimbolos.TablaSimbolos.INSTANCIA.ObtenerComponentes()[i].ObtenerCategoria();
                fila.Cells[2].Value = TablaSimbolos.TablaSimbolos.INSTANCIA.ObtenerComponentes()[i].ObtenerNumeroLinea();
                fila.Cells[3].Value = TablaSimbolos.TablaSimbolos.INSTANCIA.ObtenerComponentes()[i].ObtenerPosicionInicial();
                fila.Cells[4].Value = TablaSimbolos.TablaSimbolos.INSTANCIA.ObtenerComponentes()[i].ObtenerPosicionFinal();

                dataGridView1.Rows.Add(fila);
            }
        }
    }
}
