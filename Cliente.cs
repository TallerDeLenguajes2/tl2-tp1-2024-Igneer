class Cliente
{
    //Campos
    private string nombre;
    private string direccion;
    private int telefono;
    private string DatosReferenciaDireccion;

    //Propiedades
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public string DatosReferenciaDireccion1 { get => DatosReferenciaDireccion; set => DatosReferenciaDireccion = value; }

    //Constructores
    public Cliente()
    {
        System.Console.WriteLine("-------------Carga de Cliente-------------");
        System.Console.WriteLine("Ingrese el nombre del cliente: ");
        nombre = Console.ReadLine();
    }

}