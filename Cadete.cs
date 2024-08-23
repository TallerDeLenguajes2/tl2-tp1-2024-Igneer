class Cadete
{
    //Campos
    private int id;
    private string nombre;
    private string direccion;
    private int telefono;
    private List<Pedido> ListadoPedidos = new List<Pedido>() ;

    //Propiedades
    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    
    //no agregar metodos sin necesidad
    // public Cadete()
    // {
    //     ListadoPedidos = ;
    // }
    // public Cadete(Pedido pedido): this() // this puntero a la propia clase, hace que primero se ejecute el anterior cosntructor y luego este
    // {
        
    //     this.ListadoPedidos.Add(pedido);
    // }

    //Metodos
    public void agregarPedido(Pedido pedido)
    {
        ListadoPedidos.Add(pedido);
    }

    public void finalizarPedido(int ID)
    {
        foreach(var pedido in ListadoPedidos.Where(x => x == ListadoPedidos))
        {

        }
    }

}