public class AnalisadorSemantico
{
    bool continuarAnalisis = true;
    String caracterActual = "";
    int estadoActual = 0;

    public analisador()
    {
        while (continuarAnalisis)
        {
            switch (estadoActual)
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
            }
        }
    }

    public void esModulo()
    {
        estadoActual = ("%".Equals(caracterActual.toCharArray()[0])) ? 9 : 0;
    }

    public void esSuma()
    {
        estadoActual = ("+".Equals(caracterActual.toCharArray()[0])) ? 5 : 0;
    }
    public void esResta()
    {
        estadoActual = ("+".Equals(caracterActual.toCharArray()[0])) ? 5 : 0;
    }
    public void esMultiplicacion()
    {
        estadoActual = ("+".Equals(caracterActual.toCharArray()[0])) ? 5 : 0;
    }
    public void esSuma()
    {
        estadoActual = ("+".Equals(caracterActual.toCharArray()[0])) ? 5 : 0;
    }

    private void ProcesarEstado16()
    {
        DevolverPuntero();

        int PosicionInicial = Puntero - Lexema.Length;
        int PosicioFinal = Puntero - 1;

        FormarComponent(lexema, Categorias.IDENTIFICADOR, PosicionInicial, PosicioFinal, Tipo.SIMBOLOS);
    }

    private void ProcesarEstado17()
    {
        DevolverPuntero();

        int PosicionInicial = Puntero - Lexema.Length;
        int PosicioFinal = Puntero;

        FormarComponent(lexema + "0", Categorias.NUMERO_DECIMAL, PosicionInicial, PosicioFinal, Tipo.DUMMY);
        Tabla.ObtenerInstancia().Agregar(Componente);

        String Falla = "Numero decimal no válido" + lexema + caracterActual;
        String Causa = "recibí " + caracterActual + "esperaba digito 0.9";
        String Solucion = "Asegurese que luego del separador decimal halla undigito del 0-9";

        Error Error = Error.crear(numeroLinea, posicionInicial, posicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);
        GestorErrores.obtenerInstancia().Agregar(Error);

    }

    private void ProcesarEstado18()
    {
        int PosicionInicial = Puntero - 1;
        int PosicioFinal = Puntero - 1;

        String Falla = "Simbolo no válido" + caracterActual;
        String Causa = "recibí " + caracterActual + "el cual no es soportado";
        String Solucion = "Asegurese de que el simbolo sea aceptado por el lenguaje";

        Error Error = Error.crear(numeroLinea, posicionInicial, posicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);
        GestorErrores.obtenerInstancia().Agregar(Error);
        throw new Exception("Se ha presentado un error, no es posible continuar el analisis lexico...");
    }


    private void btn_1 (){
        try{
            analizadorSintactico analizadorSintactico = new AnalisadorSintactico();
            analizadorSintactico.analizar(CheckBox1.Checked);
        }catch(Exception exception) {
            MessageBox.Show(exception.Message);
        }
    }
}





