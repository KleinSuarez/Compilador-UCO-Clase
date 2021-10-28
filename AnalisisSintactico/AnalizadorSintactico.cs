using Compilador_clase.AnalisisLexico;
using Compilador_clase.ManejandorErrores;
using Compilador_clase.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador_clase.AnalisisSintactico
{
    internal class AnalizadorSintactico
    {
        private AnalizadorLexico analizadorLexico = new AnalizadorLexico();
        private ComponenteLexico Componente;
        private StringBuilder Traza;

        private void Expresion(int Nivel)
        {
            FormarEntrada(Nivel, "<Expresion>");
            Termino(Nivel + 1);
            ExpresionPrima(Nivel + 1);
            FormarSalida(Nivel, "<Expresion>");
        }
        private void ExpresionPrima(int Nivel)
        {
            FormarEntrada(Nivel, "<ExpresionPrima>");
            if (Categoria.SUMA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Expresion(Nivel + 1);
            }
            else if (Categoria.RESTA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Expresion(Nivel + 1);
            }
            FormarSalida(Nivel, "<ExpresionPrima>");
        }
        private void Termino(int Nivel)
        {
            FormarEntrada(Nivel, "<Termino>");
            Factor(Nivel + 1);
            TerminoPrima(Nivel + 1);
            FormarSalida(Nivel, "<Termino>");
        }
        private void TerminoPrima(int Nivel)
        {
            FormarEntrada(Nivel, "<TerminoPrima>");
            if (Categoria.MULTIPLICACION.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Termino(Nivel + 1);
            }
            else if (Categoria.DIVISION.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Termino(Nivel + 1);
            }
            FormarSalida(Nivel, "<TerminoPrima>");
        }
        private void Factor(int Nivel)
        {
            if (Categoria.NUMERO_ENTERO.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_DECIMAL.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PARENTESIS_ABRE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
                Expresion(Nivel +1);

                if (Categoria.PARENTESIS_CIERRA.Equals(Componente.ObtenerCategoria()))
                {
                    Avanzar();
                }
                else
                {
                    String Falla = "Encontre Componente no válido" + Componente.ObtenerLexema();
                    String Causa = "recibí " + Componente.ObtenerCategoria() + "esperaba )";
                    String Solucion = "Asegurese de cerrar el parentesis correspondiente";

                    Error Error = Error.Crear(Componente.ObtenerNumeroLinea(), Componente.ObtenerPosicionInicial(), Componente.ObtenerPosicionFinal(), Falla, Causa, Solucion, TipoError.SINTACTICO);
                    GestorErrores.ObtenerInstancia().Agregar(Error);
                }
            }
            else
            {
                String Falla = "Encontre Componente no válido" + Componente.ObtenerLexema();
                String Causa = "recibí " + Componente.ObtenerCategoria();
                String Solucion = "Asegurese que el Componente en esta posición sea némero entero, número decimal o parentesis abre";

                Error Error = Error.Crear(Componente.ObtenerNumeroLinea(), Componente.ObtenerPosicionInicial(), Componente.ObtenerPosicionFinal(), Falla, Causa, Solucion, TipoError.SINTACTICO);
                GestorErrores.ObtenerInstancia().Agregar(Error);
                throw new Exception("Error tipo stopper durante el análisis sintactico, observe la terminal para la mas información sobre el error");
            }
        }


        public void Analizar(bool Depurar)
        {
            Avanzar();
            Traza = new StringBuilder();
            Expresion(1);


            if (Depurar)
            {
                MessageBox.Show(Traza.ToString());
            }

            if (GestorErrores.ObtenerInstancia().HayErrores())
            {
                MessageBox.Show("La compilación ha finalizado, pero hay errores en el programa de Entrada, por favor verifique la consola de errores");
            }
            else if (Categoria.FIN_DE_ARCHIVO.Equals(Componente.ObtenerCategoria()))
            {
                MessageBox.Show("Compilación finalizada correctamente");
            }
            else
            {
                MessageBox.Show("Aunque la compilación ha finalizado, faltarón componentes por evaluar");
            }
        }


        private void Avanzar()
        {
            Componente = analizadorLexico.DevolverComponenteLexico();
        }

        private void FormarEntrada(int Nivel, string regla)
        {
            for (int contador = 1; contador <= Nivel * 5; contador++)
            {
                Traza.Append("-");
            }
            Traza.Append(">");
            Traza.Append("INICIO" + regla);
            Traza.Append("\n");
            FormarComponente(Nivel);

        }
        private void FormarSalida(int Nivel, string regla)
        {
            Traza.Append("<");
            for (int contador = 1; contador <= Nivel * 5; contador++)
            {
                Traza.Append("-");

            }
            Traza.Append("FIN" + regla);
            Traza.Append("\n");
        }

        private void FormarComponente(int Nivel)
        {
            Traza.Append("-");
            for (int contador = 1; contador <= (Nivel + 1) * 5; contador++)
            {
                Traza.Append("-");

            }
            Traza.Append("componente actual").Append(this.Componente.ObtenerLexema()).Append("/").Append(this.Componente.ObtenerCategoria());
            Traza.Append("\n");
        }
    }
}
