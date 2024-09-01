class Cliente
{
    //Campos
    private string nombre;
    private string direccion;
    private string telefono;
    private string datosReferenciaDireccion;

    //Propiedades
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string DatosReferenciaDireccion { get => datosReferenciaDireccion; set => datosReferenciaDireccion = value; }

    //Metodos 

    public Cliente()
    {
        System.Console.WriteLine("----------Carga Del Cliente----------");
        System.Console.WriteLine("Ingrese el nombre del cliente:");
        nombre = Console.ReadLine();
        System.Console.WriteLine("Ingrese la direccion del cliente:");
        direccion = Console.ReadLine();
        System.Console.WriteLine("Ingrese el numero del cliente(sin codigo de area):");
        telefono = Console.ReadLine();
        System.Console.WriteLine("Ingrese algun dato de referencia de la direccion:");
        datosReferenciaDireccion = Console.ReadLine();
        System.Console.WriteLine("-------------------------------------");

    }

}