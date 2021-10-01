using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador_clase.ManejandorErrores
{
    public class Error
    {
        private int NumeroLinea;
        private int PosicionInicial;
        private int PosicionFinal;
        private string Falla;
        private string Causa;
        private string Solucion;
        private TipoError Tipo;

        private Error(int NumeroLinea, int PosicionInicial, int PosicionFinal, string Falla, string Causa, string Solucion, TipoError Tipo)
        {
            this.NumeroLinea = NumeroLinea;
            this.PosicionInicial = PosicionInicial;
            this.Falla = Falla;
            this.Causa = Causa;
            this.Solucion = Solucion;
        }

        public static Error Crear(int NumeroLinea, int PosicionInicial, int PosicionFinal, string Falla, string Causa, string Solucion, TipoError Tipo)
        {
            return new Error(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, Tipo);
        }

        public int ObtenerNumeroLinea()
        {
            return NumeroLinea;
        }

        public int ObtenerPosicionInicial()
        {
            return PosicionInicial;
        }

        public int ObtenerPosicionFinal()
        {
            return PosicionFinal;
        }

        public string ObtenerFalla()
        {
            return Falla;
        }

        public string ObtenerCausa()
        {
            return Causa;
        }

        public string ObtenerSolucion()
        {
            return Solucion;
        }

        public TipoError ObtenerTipo()
        {
            return Tipo;
        }
    }
}
