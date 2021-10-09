using Compilador_clase.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador_clase.TablaSimbolos
{
    public class TablaSimbolos
    {
        private Dictionary<String, List<ComponenteLexico>> Tabla = new Dictionary<String, List<ComponenteLexico>>();

        public static TablaSimbolos INSTANCIA = new TablaSimbolos();
        private TablaSimbolos()
        {

        }

        public static TablaSimbolos ObtenerInstancia()
        {
            return INSTANCIA;
        }

        public void Limpiar()
        {
            Tabla.Clear();
        }

        private List<ComponenteLexico> ObtenerSimbolo(string Simbolo)
        {
            if (!Tabla.ContainsKey(Simbolo))
            {
                Tabla.Add(Simbolo, new List<ComponenteLexico>());
            }

            return Tabla[Simbolo];
        }

        public void Agregar(ComponenteLexico Componente)
        {
            if (Componente != null && Tipo.SIMBOLO.Equals(Componente.ObtenerTipo()))
            {
                ObtenerSimbolo(Componente.ObtenerLexema()).Add(Componente);
            }
        } 

        public List<ComponenteLexico> ObtenerComponentes()
        {
            List<ComponenteLexico> Componentes = new List<ComponenteLexico>();

            foreach (List<ComponenteLexico> Lista in Tabla.Values)
            {
                Componentes.AddRange(Lista);    
            }

            return Componentes;
        }
    }
}
