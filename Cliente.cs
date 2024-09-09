namespace EspacioCadeteria;

class Cliente
{
    //Campos
    private string nombre;
    private string direccion;
    private string telefono;
    private string datosReferenciaDireccion;

    //Propiedades
    public string Nombre { get => nombre; }
    public string Direccion { get => direccion; }
    public string Telefono { get => telefono; }
    public string DatosReferenciaDireccion { get => datosReferenciaDireccion; }

    //Metodos 
    public Cliente(string nombre, string direccion, string telefono, string datosReferenciaDireccion)
    {
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        this.datosReferenciaDireccion = datosReferenciaDireccion;
    }

}