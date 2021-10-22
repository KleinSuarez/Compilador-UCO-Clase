public class analizadorSintactico
{

    private AnalizadorLexico analizadorLexico = new AnalizadorLexico();
    private ComponenteLexico Componente;
    private StringBuilder traza;

    private void Expresion(int Nivel)
    {
        FormarEntrada(Nivel, "<Expresion>");
        Termino(Nivel + 1);
        ExpresionPrima(Nivel + 1);
        FormarSalida(Nivel, "<Expresion>");
    }
    private void ExpresionPrim(int Nivel)
    {
        FormarEntrada(Nivel, "<ExpresionPrima>");
        if (Categoria.SUMA.equals(Componente.ObtenerCategotia()))
        {
            Avanzar(Nivel +1);
            Expresion(Nivel +1);
        }
        else if (Categoria.RESTA.equals(Componente.ObtenerCategotia()))
        {
            Avanzar(Nivel +1);
            Expresion(Nivel +1);
        }
        FormarSalida(Nivel, "<ExpresionPrima>");
    }
    private void Termino(int Nivel)
    {
        FormarEntrada(Nivel, "<Termino>");
        Factor(Nivel +1);
        TerminoPrima(Nivel +1);
        FormarSalida(Nivel, "<Termino>");
    }
    private void TerminoPrima(int Nivel)
    {
        FormarEntrada(Nivel, "<TerminoPrima>");
        if (Categoria.MULTIPLICACION.equals(Componente.ObtenerCategotia()))
        {
            Avanzar(Nivel +1);
            Termino(Nivel +1);
        }
        else if (Categoria.DIVISION.equals(Componente.ObtenerCategotia()))
        {
            Avanzar(Nivel +1);
            Termino(Nivel +1);
        }
        FormarSalida(Nivel, "<TerminoPrima>");
    }
    private void Factor(int Nivel)
    {
        if (Categoria.NUMERO_ENTERO.equals(Componente.ObtenerCategoria()))
        {
            Avanzar();
        }
        else if (Categoria.NUMERO_DECIMAL.equals(Componente.ObtenerCategoria()))
        {
            Avanzar();
        }
        else if (Categoria.PARENTESIS_ABRE.equals(Componente.ObtenerCategoria()))
        {
            Avanzar();
            Expresion();

            if (Categoria.PARENTESIS_CIERRA.equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else
            {
                String Falla = "Encontre Componente no válido" + Componente.Lexema();
                String Causa = "recibí " + Componente.ObtenerCategoria() + "esperaba )";
                String Solucion = "Asegurese de cerrar el parentesis correspondiente";

                Error Error = Error.crear(Componente.ObtenerLineaActual(), Componente.ObtenerposicionInicial(), Componente.ObtenerPosicionFinal(), Falla, Causa, Solucion, TipoError.SINTACTICO);
                GestorErrores.obtenerInstancia().Agregar(Error);
            }
        }
        else
        {
            String Falla = "Encontre Componente no válido" + Componente.Lexema();
            String Causa = "recibí " + Componente.ObtenerCategoria();
            String Solucion = "Asegurese que el Componente en esta posición sea némero entero, número decimal o parentesis abre";

            Error Error = Error.crear(Componente.ObtenerLineaActual(), Componente.ObtenerposicionInicial(), Componente.ObtenerPosicionFinal(), Falla, Causa, Solucion, TipoError.SINTACTICO);
            GestorErrores.obtenerInstancia().Agregar(Error);
            throw new Exception("Error tipo stopper durante el análisis sintactico, observe la terminal para la mas información sobre el error");
        }
    }


    public void Analizar( bool Depurar)
    {
        Avanzar();
        traza = new StringBuilder();
        Expresion();


        if(Depurar){
            MessageBox.Show(traza.ToString());
        }

        if (GestorErrores.ObtenerInstancia().HayErrores())
        {
            messageBox.Show("La compolación ha finalizado, pero hay errores en el programa de Entrada, por favor verifique la consola de errores");
        }
        else if (Categoria.FIN_DE_ARCHIVO.equals(Componente.ObtenerCategoria()))
        {
            messageBox.Show("Compilación finalizada correctamente");
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

    }
    private void FormarSalida(int Nivel, string regla)
    {

        for (int contador = 1; contador <= Nivel * 5; contador++)
        {
            Traza.Append("-";

        }
        Traza.Append("FIN" + regla);
        Traza.Append("\n");
    }

    private void FormarComponente(int Nivel, string regla)
    {
        string componente = "-";
        for (int contador = 1; contador <= (Nivel + 1) * 5; contador++)
        {
            Traza.Append("-");

        }
        Traza.Append("componente actual").Append(this.Componente.ObtenerLexema()).Append("/").Append(this.Componente.ObtenerCategoria());
        Traza.Append("\n");
        return componente;
    }
}