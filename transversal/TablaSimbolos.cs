
public class TablaSimbolos
{
    private Dictionary<string, list<ComponenteLexico>> tabla = new Dictionary<string, List<ComponenteLexico>>();

    private static TablaSimbolos INSTANCIA = new TablaSimbolos();

    private TablaSimbolos(){

    }

    public static TablaSimbolos obtenerInstancia(){
        return INSTANCIA;
    }

    public void limpiar(){
        tabla.clear();
    }

    private List<ComponenteLexico> obtenerSimbolo(string simbolo){
        if(!tabla.containsKey(simbolo)){
            tabla.add(simbolo, new List<ComponenteLexico>());
        }

        return tabla[simbolo];
    }

    public void agregar(ComponenteLexico componenteLexico){
        if(componenteLexico != null && tipo.SIMBOLOS.Equals(ComponenteLexico.obtenerTipo())){
            obtenerSimbolo(componenteLexico.obtenerLexema()).Add(componenteLexico);
        }

    }

    public List<ComponenteLexico> obtenerComponentes(){
        List<ComponenteLexico> componentes = new List<ComponenteLexico>();

        foreach(List<ComponenteLexico> lista in tabla.Values){
            componentes.Add(lista);
        }
        return componentes;
    }
}