using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador_clase.Transversal
{
    public class Cache
    {
        public static Cache INSTANCIA = new Cache();
        private Dictionary<int, Linea> Lineas = new Dictionary<int, Linea>();

        private Cache() { }

        public static Cache ObtenerCache()
        {
            return INSTANCIA;
        }

        public void ReiniciarCache()
        {
            Lineas.Clear();
        }

        public void AgregarLinea(String Contenido)
        {
            if (Contenido != null)
            {
                Linea linea = Linea.Crear(NumeroDeLineasActual() + 1, Contenido);
                Lineas.Add(linea.ObtenerNumero(), linea);

            }
        }

        public Linea ObtenerLinea(int Numero)
        {
            Linea lineaRetorno = Linea.Crear(NumeroDeLineasActual() + 1, "@EOF@");

            if (Lineas.ContainsKey(Numero))
            {
                lineaRetorno = Lineas[Numero];
            }

            return lineaRetorno;
        }

        private int NumeroDeLineasActual()
        {
            return Lineas.Keys.Count; //Retorna la cantidad de elementos del arreglo
        }
    }
}
