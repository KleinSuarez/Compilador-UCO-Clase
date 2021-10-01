public class Tabla
{
    private static Tabla INSTANCIA = new Tabla();

    private Tabla()
    {

    }

    public static Tabla obtenerTabla()
    {
        return INSTANCIA;
    }

    public void agregar(ComponenteLexico Componente)
    {
        TablaPalabrasReservadas.obtenerInstancia().Agregar(Componente);
        TablaSimbolos.obtenerInstancia().Agregar(Componente);
        TablasLiterales.obtenerInstancia().Agregar(Componente);
        TablaDummy.obtenerInstancia().Agregar(Componente);
    }

    public void limpiar(Tipo tipo)
    {
        if (tipo.SIMBOLO.Equals(tipo))
        {
            TablaSimbolos.obtenerInstancia().limpiar();
        }
    }

    public List<ComponenteLexico> obtenerComponentes(Tipo tipo){
        list<ComponenteLexico> Componentes = new List<ComponenteLexico>();
        if (tipo.SIMBOLO.Equals(tipo)){
        Componentes = TablaSimbolos.obtenerInstancia().obtenerComponentes();
        }
    }

}

