public class ComponenteLexico
{
    private string lexema;
    private Categoria categorias;
    private int numeroLinea;
    private int PosicionInicial;
    private int finDeLinea;
    private Tipo tipo;

    private ComponenteLexico(string lexema, int numeroLinea, int PosicionInicial, int finDeLinea, Categoria categorias, Tipo tipo)
    {
        this.lexema = lexema;
        this.numeroLinea = numeroLine;
        this.PosicionInicial = PosicionInicial;
        this.finDeLinea = finDeLinea;
        this.categorias = categorias;
        this.tipo = tipo;
    }

    public static ComponenteLexico crear (string lexema,  Categoria categorias, Tipo tipo){
        return new ComponenteLexico(lexema, numeroLinea, 0, categorias, tipo, 0, 0);
    }

     public static ComponenteLexico crear (string lexema, int numeroLinea, Categoria categorias, Tipo tipo, int PosicionInicial, int finDeLinea){
        return new ComponenteLexico(lexema, numeroLinea, inicio, categorias, tipo, PosicionInicial, finDeLinea);
    }
    public Tipo obtenerTipo()
    {
        return this.tipo;
    }

    public string ObtenerLexema(){
        return this.lexema;
    }

    public Tipo ObtenerTipo(){
        return this.tipo;
    }

    public Categoria ObtenerCategoria(){
        return this.categorias;
    }

    public int ObtenerNumeroDeLinea(){
        return this.numeroLinea;
    }

    public int ObtenerPosicioInicial(){
        return this.PosicionInicial;
    }

    public int ObtenerPosicionFinal(){
        return this.PosicionFinal;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        string SaltoLinea = "\n";

        sb.Append("Categoria: ").Append(ObtenerCategory()).Append(SaltoLinea);
        sb.Append("Lexema: ").Append(ObtenerLexema()).Append(SaltoLinea);
        sb.Append("Tipo: ").Append(ObtenerTipo()).Append(SaltoLinea);
        sb.Append("Numero Linea: ").Append(ObtenerNumeroLinea()).Append(SaltoLinea);
        sb.Append("Inicio Linea: ").Append(ObtenerPosicioInicial()).Append(SaltoLinea);
        sb.Append("Fin Linea: ").Append(ObtenerFinLinea()).Append(SaltoLinea);

        return sb.ToString();
    }
}