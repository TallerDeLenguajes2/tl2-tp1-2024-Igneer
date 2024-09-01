
class Cadete
{
    //Campos
    private int id;
    private string nombre;
    private string direccion;
    private string telefono;
    private List<Pedido> listadoPedidos = new List<Pedido>() ;

    //Propiedades
    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    internal List<Pedido> ListadoPedidos { get => listadoPedidos; set => listadoPedidos = value; }

    //no agregar metodos sin necesidad, intente hacer una sobrecarga con los constructores
    // public Cadete()
    // {
    //     ListadoPedidos = ;
    // }
    // public Cadete(Pedido pedido): this() // this puntero a la propia clase, hace que primero se ejecute el anterior cosntructor y luego este
    // {

    //     this.ListadoPedidos.Add(pedido);
    // }
    // El problema de hacerlo así en el segundo constructor es que estoy obligado a si o si al cadete pasarle un pedido

    //Metodos
    public bool agregarPedido(Pedido pedido)
    {
        // if(ListadoPedidos.Count <= 4)
        // {
            ListadoPedidos.Add(pedido);
            return true; 
        // }else
        // {
        //     System.Console.WriteLine("El cadete seleccionado no termino los pedidos asignados, seleccione otro");
        //     return false;
        // }
    }

    public void mostrarPedidos()
    {
        foreach(Pedido pedido in ListadoPedidos)
        {
            pedido.mostrarPedido();
        }
    }

    // public void finalizarPedido(int ID)
    // {
    //     foreach(var pedido in ListadoPedidos.Where(x => x == ListadoPedidos))
    //     {

    //     }
    // }

    public int JornalACobrar()
    {
        int total = 0;
        int precioPedido = 500;
        foreach(Pedido pedido in ListadoPedidos)
        {
            if(pedido.Estado == Pedido.Estados.Completado)
            {
                total++;
            }
        }

        return total*precioPedido;
    }

}