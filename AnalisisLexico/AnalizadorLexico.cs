using Compilador_clase.ManejandorErrores;
using Compilador_clase.TablaSimbolos;
using Compilador_clase.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador_clase.AnalisisLexico
{
    class AnalizadorLexico
    {
        private int Puntero;
        private int NumeroLineaActual;
        private Linea LineaActual;
        private String CaracterActual;
        private String Lexema;
        private int EstadoActual;
        private bool ContinuarAnalisis;
        private ComponenteLexico Componente;


        public AnalizadorLexico()
        {
            CargarNuevaLinea();
        }

        private void CargarNuevaLinea()
        {
            NumeroLineaActual = NumeroLineaActual + 1;
            LineaActual = Cache.ObtenerCache().ObtenerLinea(NumeroLineaActual);
            NumeroLineaActual = LineaActual.ObtenerNumero(); //Asegura que se quede en el fin de archivo
            Puntero = 0;

        }

        private void DevolverPuntero()
        {
            if (Puntero > 1)
            {
                Puntero = Puntero - 1;
            }
        }

        private void AvanzarPuntero()
        {
            Puntero = Puntero + 1;
        }

        private void LeerSiguienteCaracter()
        {
            if (LineaActual.esFinArchivo())
            {
                CaracterActual = LineaActual.ObtenerContenido();
            }
            else if (Puntero >= LineaActual.ObtenerLongitud())
            {
                Puntero = LineaActual.ObtenerLongitud() + 1;
                CaracterActual = "@FL@";
            }
            else
            {
                CaracterActual = LineaActual.ObtenerContenido().Substring(Puntero, 1); //oBTIENE LA PARTE DE LA CADENA DEL PUNTERO Y OBTIENE UN CARACTER
                AvanzarPuntero();
            }
        }

        public void Reiniciar()
        {
            Lexema = "";
            CaracterActual = "";
            EstadoActual = 0;
            ContinuarAnalisis = true;
        }

        public void ReiniciarPuntero()
        {
            Puntero = 0;
            EstadoActual = 0;
            ContinuarAnalisis = true;
        }

        private void DevorarEspacioBlanco()
        {
            String BLANCO = " ";

            while (BLANCO.Equals(CaracterActual))
            {
                LeerSiguienteCaracter();
            }
        }

        private void FormarComponente(String Lexema, Categoria Categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal, Tipo Tipo)
        {
            Componente = ComponenteLexico.Crear(Lexema, Categoria, NumeroLinea, PosicionInicial, PosicionFinal, Tipo);
            Tabla.ObtenerInstancia().Agregar(Componente);
        }
        public ComponenteLexico DevolverComponenteLexico()
        {
            Reiniciar();
            while (ContinuarAnalisis)
            {
                switch (EstadoActual)
                {
                    case 0:
                        ProcesarEstado0();
                        break;
                    case 1:
                        ProcesarEstado1();
                        break;
                    case 2:
                        ProcesarEstado2();
                        break;
                    case 3:
                        ProcesarEstado3();
                        break;
                    case 4:
                        ProcesarEstado4();
                        break;
                    case 5:
                        ProcesarEstado5();
                        break;
                    case 6:
                        ProcesarEstado6();
                        break;
                    case 7:
                        ProcesarEstado7();
                        break;
                    case 8:
                        ProcesarEstado8();
                        break;
                    case 9:
                        ProcesarEstado9();
                        break;
                    case 10:
                        ProcesarEstado10();
                        break;
                    case 11:
                        ProcesarEstado11();
                        break;
                    case 12:
                        ProcesarEstado12();
                        break;
                    case 13:
                        ProcesarEstado13();
                        break;
                    case 14:
                        ProcesarEstado14();
                        break;
                    case 15:
                        ProcesarEstado15();
                        break;
                    case 16:
                        ProcesarEstado16();
                        break;
                    case 17:
                        ProcesarEstado17();
                        break;
                    case 18:
                        ProcesarEstado18();
                        break;
                    case 19:
                        ProcesarEstado19();
                        break;
                    case 20:
                        ProcesarEstado20();
                        break;
                    case 21:
                        ProcesarEstado21();
                        break;
                    case 22:
                        ProcesarEstado22();
                        break;
                    case 23:
                        ProcesarEstado23();
                        break;
                    case 24:
                        ProcesarEstado24();
                        break;
                    case 25:
                        ProcesarEstado25();
                        break;
                    case 26:
                        ProcesarEstado26();
                        break;
                    case 27:
                        ProcesarEstado27();
                        break;
                    case 28:
                        ProcesarEstado28();
                        break;
                    case 29:
                        ProcesarEstado29();
                        break;
                    case 30:
                        ProcesarEstado30();
                        break;
                    case 31:
                        ProcesarEstado31();
                        break;
                    case 32:
                        ProcesarEstado32();
                        break;
                    case 33:
                        ProcesarEstado33();
                        break;
                    case 34:
                        ProcesarEstado34();
                        break;
                    case 35:
                        ProcesarEstado35();
                        break;
                    case 36:
                        ProcesarEstado36();
                        break;
                    case 37:
                        ProcesarEstado37();
                        break;
                }

            }
            return Componente   ;
        }

        private void ProcesarEstado0()
        {
            LeerSiguienteCaracter();
            DevorarEspacioBlanco();

            if (EsLetra() || EsGuionBajo() || EsSimboloPesos())
            {
                EstadoActual = 4;
                FormarLexema();
            }
            else if (EsDigito())
            {
                EstadoActual = 1;
                FormarLexema();
            }
            else if (EsSignoSuma())
            {
                EstadoActual = 5;
                FormarLexema();
            }
            else if (EsSignoResta())
            {
                EstadoActual = 6;
                FormarLexema();
            }
            else if (EsAsterisco())
            {
                EstadoActual = 7;
                FormarLexema();
            }
            else if (EsSlash())
            {
                EstadoActual = 8;
                FormarLexema();
            }
            else if (EsSignoModulo())
            {
                EstadoActual = 9;
                FormarLexema();
            }
            else if (EsParentesisAbre())
            {
                EstadoActual = 10;
                FormarLexema();
            }
            else if (EsParentesisCierra())
            {
                EstadoActual = 11;
                FormarLexema();
            }
            else if (LineaActual.esFinArchivo())
            {
                EstadoActual = 12;
                FormarLexema();
            }
            else if (EsIgualQue())
            {
                EstadoActual = 19;
                FormarLexema();
            }
            else if (EsMenorQue())
            {
                EstadoActual = 20;
                FormarLexema();
            }
            else if (EsMayorQue())
            {
                EstadoActual = 21;
                FormarLexema();
            }
            else if (EsDosPuntos())
            {
                EstadoActual = 22;
                FormarLexema();
            }
            else if (EsSignoAdmiracion())
            {
                EstadoActual = 30;
                FormarLexema();
            }
            else if (EsFinLinea())
            {
                EstadoActual = 13;
            }
            else
            {
                EstadoActual = 18;
            }

        }

        private void ProcesarEstado1()
        {
            LeerSiguienteCaracter();

            if (EsDigito())
            {
                EstadoActual = 1;
                FormarLexema();
            }else if (EsComa())
            {
                EstadoActual = 2;
                FormarLexema();
            }
            else
            {
                EstadoActual = 14;
            }
        }

        private void ProcesarEstado2()
        {
            LeerSiguienteCaracter();
            if (EsDigito())
            {
                EstadoActual = 3;
                FormarLexema();
            }
            else
            {
                EstadoActual = 17;
            }
        }

        private void ProcesarEstado3()
        {
            LeerSiguienteCaracter();
            if (EsDigito())
            {
                EstadoActual = 3;
                FormarLexema();
            }
            else
            {
                EstadoActual = 15;
            }
        }

        private void ProcesarEstado4()
        {
            LeerSiguienteCaracter();
            if (EsLetra() || EsGuionBajo() || EsSimboloPesos() || EsDigito())
            {
                EstadoActual = 4;
                FormarLexema();
            }
            else
            {
                EstadoActual = 16;
            }
        }

        private void ProcesarEstado5()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.SUMA, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado6()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.RESTA, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado7()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.MULTIPLICACION, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado8()
        {
            LeerSiguienteCaracter();
            if (EsAsterisco())
            {
                EstadoActual = 34;
            } else if (EsSlash())
            {
                EstadoActual = 36;
            } else
            {
                EstadoActual = 33;
            }
        }

        private void ProcesarEstado9()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.MODULO, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado10()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.PARENTESIS_ABRE, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado11()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.PARENTESIS_CIERRA, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado12()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.FIN_ARCHIVO, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado13()
        {
            Reiniciar();
            CargarNuevaLinea();
        }

        private void ProcesarEstado14()
        {
            DevolverPuntero();
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.NUMERO_ENTERO, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.LITERAL);
            ContinuarAnalisis = false;

        }

        private void ProcesarEstado15()
        {
            DevolverPuntero();
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.NUMERO_DECIMAL, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.LITERAL);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado16()
        { 
            DevolverPuntero();

            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.IDENTIFICADOR, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.LITERAL);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado17()
        {
            DevolverPuntero();

            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero;
            FormarComponente(Lexema + "0", Categoria.NUMERO_DECIMAL, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.DUMMY);
            
            Tabla.ObtenerInstancia().Agregar(Componente);

            string Falla = "Número decimal no válido: " + Lexema + CaracterActual;
            string Causa = "Recibí " + CaracterActual + " y  se esperaba un dígito de 0 al 9";
            string Solucion = "Asegúrese que luego de la parte decimal, aparezca un dígito del 0 al 9";

            Error Error = Error.Crear(NumeroLineaActual, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);

            GestorErrores.ObtenerInstancia().Agregar(Error);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado18()
        {
            int PosicionInicial = Puntero - 1;
            int PosicionFinal = Puntero - 1;
            FormarComponente(Lexema + "0", Categoria.NUMERO_DECIMAL, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.DUMMY);

            Tabla.ObtenerInstancia().Agregar(Componente);

            string Falla = "Símbolo no válido: " + CaracterActual;
            string Causa = "Recibí " + CaracterActual + " el cuál no es soportado.";
            string Solucion = "Asegúrese que el símbolo sea aceptado por el lenguaje";

            Error Error = Error.Crear(NumeroLineaActual, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);

            GestorErrores.ObtenerInstancia().Agregar(Error);

            throw new Exception("Se ha presentado un error que impide continuar con el análisis sintáctico.");
        }

        private void ProcesarEstado19()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.IGUAL_QUE, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado20()
        {
            LeerSiguienteCaracter();
            if (EsMayorQue())
            {
                EstadoActual = 23;
                FormarLexema();
            } else if (EsIgualQue())
            {
                EstadoActual = 24;
                FormarLexema();
            }
            else
            {
                EstadoActual = 25;
            }
        }

        private void ProcesarEstado21()
        {
            LeerSiguienteCaracter();
            if (EsIgualQue())
            {
                EstadoActual = 26;
                FormarLexema();
            }else
            {
                EstadoActual = 27;
            }
        }

        private void ProcesarEstado22()
        {
            LeerSiguienteCaracter();
            if (EsIgualQue())
            {
                EstadoActual = 28;
                FormarLexema();
            } else
            {
                EstadoActual = 29;
            }
        }

        private void ProcesarEstado23()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.DIFERENTE_QUE, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado24()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.MENOR_IGUAL_QUE, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado25()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.MENOR_QUE, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado26()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.MAYOR_IGUAL_QUE, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado27()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.MAYOR_QUE, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado28()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.ASIGNACION, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado29()
        {
            DevolverPuntero();
            throw new Exception("El carácter : " + CaracterActual + "no es válido para una asignación.");
        }

        private void ProcesarEstado30()
        {
            LeerSiguienteCaracter();
            if (EsIgualQue())
            {
                EstadoActual = 31;
                FormarLexema();
            }
            else
            {
                EstadoActual = 32;
            }
        }

        private void ProcesarEstado31()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.DIFERENTE_QUE, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado32()
        {
            DevolverPuntero();
            throw new Exception("El carácter : " + CaracterActual + "no es válido para una comparación.");
        }

        private void ProcesarEstado33()
        {
            DevolverPuntero();
            int PosicionInicial = Puntero - Lexema.Length;
            int posicionaFinal = Puntero - 1;

            FormarComponente(Lexema, Categoria.DIVISION, NumeroLineaActual, PosicionInicial, posicionaFinal, Tipo.SIMBOLO);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado34()
        {
            LeerSiguienteCaracter();
            if (!EsAsterisco())
            {
                EstadoActual = 34;
                FormarLexema();
            }
            else
            {
                EstadoActual = 35;
            }
        }

        private void ProcesarEstado35()
        {
            LeerSiguienteCaracter();
            if (!EsAsterisco() || !EsSlash())
            {
                EstadoActual = 34;
                FormarLexema();
            }
            else if(EsAsterisco())
            {
                EstadoActual = 35;
                FormarLexema();
            }
            else
            {
                Reiniciar();
            }
        }

        private void ProcesarEstado36()
        {
            LeerSiguienteCaracter();
            if (!EsFinLinea())
            {
                EstadoActual = 36;
                FormarLexema();
            }
            else
            {
                EstadoActual = 13;
            }
        }

        private void ProcesarEstado37()
        {
            CargarNuevaLinea();
            ReiniciarPuntero();
        }

        private bool EsLetra()
        {
            return Char.IsLetter(CaracterActual.ToCharArray()[0]);

        }

        private bool EsGuionBajo()
        {
            return "_".Equals(CaracterActual);
        }

        private bool EsSimboloPesos()
        {
            return "$".Equals(CaracterActual);
        }

        private void FormarLexema()
        {
            Lexema = Lexema + CaracterActual;
        }

        private bool EsDigito()
        {
            return Char.IsDigit(CaracterActual.ToCharArray()[0]);

        }

        private bool EsSignoSuma()
        {
            return "+".Equals(CaracterActual);
        }

        private bool EsSignoResta()
        {
            return "-".Equals(CaracterActual);
        }

        private bool EsAsterisco()
        {
            return "*".Equals(CaracterActual);
        }

        private bool EsSlash()
        {
            return "/".Equals(CaracterActual);
        }

        private bool EsSignoModulo()
        {
            return "%".Equals(CaracterActual);
        }

        private bool EsParentesisAbre()
        {
            return "(".Equals(CaracterActual);
        }

        private bool EsParentesisCierra()
        {
            return ")".Equals(CaracterActual);
        }

        private bool EsMayorQue()
        {
            return ">".Equals(CaracterActual);
        }

        private bool EsMenorQue()
        {
            return "<".Equals(CaracterActual);
        }

        private bool EsIgualQue()
        {
            return "=".Equals(CaracterActual);
        }

        private bool EsDosPuntos()
        {
            return ":".Equals(CaracterActual);
        }

        private bool EsSignoAdmiracion()
        {
            return "!".Equals(CaracterActual);
        }

        private bool EsComa()
        {
            return ",".Equals(CaracterActual);
        }

        private bool EsFinLinea()
        {
            return "@FL@".Equals(CaracterActual) || "\r".Equals(CaracterActual);
        }
    }
}
