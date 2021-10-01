public class GestorErrores
{
    private Dictionary<TipoError, list<Error>> tabla = new Dictionary<TipoError, List<Error>>();

    private static GestorErrores INSTANCIA = new GestorErrores();

    private GestorErrores(){
        iniciar();
    }

    private void iniciar(){
        Tabla.Clear();
        Tabla.add(TipoError.LEXICO, new List<Error>());
        Tabla.add(TipoError.SINTACTICO, new List<Error>());
        Tabla.add(TipoError.SEMANTICO, new List<Error>());
    }
    public static GestorErrores obtenerInstancia()
    {
        return INSTANCIA;
    }

    public void limpiar()
    {
        iniciar();
    }

    public void agregar(Error Error){
        if (componenteLexico != null ){
            Tabla[Error.ObtenerTipoError()].Add(Error);
        }
    }

    public bool HayErrores(TipoError Tipo){
        return Tabla[Tipo].Count > 0;
    }

    public bool HayErrores(TipoError Tipo){
        return Tabla[Tipo.LEXICO || Tipo.SEMANTICO || Tipo.SINTACTICO].Count > 0;
    }

    public List<Error> ObtenerErrores(TipoError Tipo){
        return Tabla[Tipo];
    }
}
