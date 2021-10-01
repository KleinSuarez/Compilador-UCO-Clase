public class TablaPalabrasReservadas {
    
    private Dictionary<string, ComponenteLexico> tablaPalabrasReservadas = new Dictionary<string, List<ComponenteLexico>>();
    
    private Dictionary<string, list<ComponenteLexico>> tabla = new Dictionary<string, List<ComponenteLexico>>();

    private static TablaPalabrasReservadas INSTANCIA = new TablaPalabrasReservadas();

    private TablaPalabrasReservadas(){

    }

    private void Inicializar(){
        tablaPalabrasReservadas.Add("Palabra", ComponenteLexico.crear("Palabra", Categoria.PALABRA, tipo.PALABRAS_RESERVADAS));
        tablaPalabrasReservadas.Add("OtraPalabra", ComponenteLexico.crear("OtraPalabra", Categoria.PALABRA2, tipo.PALABRAS_RESERVADAS));
    }

    private void ValidarSiComponenteEsPalabraReservada(ComponenteLexico Componente){
        if(componente != null && TablaPalabrasReservadas.ContainsKey(Componente.ObtenerLexema)){
            ComponenteLexico PalabraReservada = tablaPalabrasReservadas[Componente.ObtenerLexema()];
            Componente = ComponenteLexico.crear(Componente.ObtenerLexema(),Componente.ObtenerNumeroDeLinea, PalabraReservada.ObtenerCategoria(), Tipo.PALABRAS_RESERVADAS, Componente.PosicionInicial, Componente.ObtenerPosicionFinal);
        }
    }

    public static TablaPalabrasReservadas obtenerInstancia(){
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

    public void Agregar(ComponenteLexico ComponenteLexico){

        ValidarSiComponenteEsPalabraReservada(ComponenteLexico);
        if(componenteLexico != null && tipo.PALABRAS_RESERVADAS.Equals(ComponenteLexico.obtenerTipo())){
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