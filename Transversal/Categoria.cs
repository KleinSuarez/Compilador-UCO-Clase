using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador_clase.Transversal
{
    public enum Categoria
    {
        IDENTIFICADOR, SUMA, RESTA, MULTIPLICACION, DIVISION, MAYOR_QUE, MENOR_QUE, IGUAL_QUE, DIFERENTE_QUE, MAYOR_IGUAL_QUE, MENOR_IGUAL_QUE, NUMERO_ENTERO, NUMERO_DECIMAL, FIN_ARCHIVO,
        PALABRA, MODULO, PARENTESIS_ABRE, PARENTESIS_CIERRA, ASIGNACION
    }
}
