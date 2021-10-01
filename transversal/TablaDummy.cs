public class TablaDummy{
        private Dictionary<string, list<ComponenteLexico>> tabla = new Dictionary<string, List<ComponenteLexico>>();

    private static TablaDummy INSTANCIA = new TablaDummy();

    private TablaDummy(){

    }

    public static TablaDummy obtenerInstancia(){
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
        if(componenteLexico != null && tipo.DUMMY.Equals(ComponenteLexico.obtenerTipo())){
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