using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador_clase.Transversal
{
    public class Linea
    {
        private int Numero;
        private String Contenido;

        private Linea(int Numero, String Contenido)
        {
            this.Numero = Numero;
            this.Contenido = Contenido;
        }

        public static Linea Crear(int Numero, String contenido)
        {
            return new Linea(Numero, contenido);
        }

        public int ObtenerNumero()
        {
            if (Numero < 0)
            {
                Numero = 0;
            }
            return Numero;
        }

        public String ObtenerContenido()
        {
            if (Contenido == null)
            {
                Contenido = "";
            }
            return Contenido;
        }

        public bool esFinArchivo()
        {
            return "@EOF@".Equals(ObtenerContenido());
        }

        public int ObtenerLongitud()
        {
            return ObtenerContenido().Length;
        }
    }
}
