public class Error
{
    private String numeroLinea = numeroLine;
    private String PosicionInicial = PosicionInicial;
    private String finDeLinea = finDeLinea;
    private String Falla;
    private String Causa;
    private String Solucion;
    private TipoError Tipo;

    private Error(int numeroLinea, int posicionInicial, int posicionFinal, String falla, string solucion, string causa, TipoError tipo)
    {
        this.numeroLinea = numeroLinea;
        this.posicionInicial = posicionInicial;
        this.posicionFinal = posicionFinal;
        this.Falla = falla;
        this.solucion = solucion;
        this.Tipo = tipo;
        this.Causa= Causa;
    }

    public static Error crear(int numeroLinea, int posicionInicial, int posicionFinal, String falla, string solucion, string causa, TipoError tipo)
    {
        return new Error(numeroLinea, posicionInicial, posicionFinal, falla, solucion, causa, tipo);
    }

    public int ObtenerNumeroDeLinea()
    {
        return this.numeroLinea;
    }

    public int ObtenerPosicioInicial()
    {
        return this.PosicionInicial;
    }

    public int ObtenerPosicionFinal()
    {
        return this.PosicionFinal;
    }

    public String ObtenerFalla()
    {
        return this.Falla;
    }

    public String ObtenerSolucion()
    {
        return this.Solucion;
    }

    public TipoError ObtenerTipoError()
    {
        return this.Tipo;
    }
}