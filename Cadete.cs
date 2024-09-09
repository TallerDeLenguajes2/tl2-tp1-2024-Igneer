namespace EspacioCadeteria;

class Cadete
{
    //Campos
    private int id;
    private string nombre;
    private string direccion;
    private string telefono;
    //Propiedades
    public int Id { get => id; }
    public string Nombre { get => nombre; }
    public string Direccion { get => direccion; }
    public string Telefono { get => telefono; }

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
    public Cadete(int id, string nombre, string direccion, string telefono)
    {
        this.id = id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
    }
    public string datosCadete()
    {
        return $"ID: {id} | Nombre: {nombre} | Direccion: {direccion} | Telefono: {telefono}\n";
    }

}