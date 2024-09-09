namespace EspacioCadeteria;

class Pedido
{
    //Variables
    private static int contador = 0;  //Al usar esta variable en static, se convierte una variable propia de la clase y no de la instancia, quiere decir que al incrementarlo en el constructor se incrementara para todas las demas clases cada vez que se instancia
    private int nro;
    private string obs;
    private Cliente cliente;
    private Cadete cadete;
    private Estados estado;

    //Propiedades
    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public Estados Estado { get => estado; }
    internal Cadete Cadete { get => cadete; }

    //Metodos
    public enum Estados
    {
        EnCurso,
        Completado
    }
    public Pedido(string nombre, string direccion, string telefono, string datosReferencia)
    {
        cliente = new Cliente(nombre, direccion, telefono, datosReferencia);
        nro = ++contador;
        estado = Estados.EnCurso;
    }

    public void asociarCadete(Cadete cadete)
    {
        this.cadete = cadete;
    }
    public void cambiarEstado(int nro)
    {
        switch (nro)
        {
            case 1:
                estado = Estados.Completado;
                break;
            default:
                break;
        }
    }
    public string datosPedido()
    {
        string nombreCadete;
        if(cadete == null)
        {
            nombreCadete = "Sin cadete asignado";
        }else
        {
            nombreCadete = cadete.Nombre;
        }
        return $"Nro: {nro} | Observaciones: {obs} | Estado: {estado} | Cadete: {nombreCadete}";
    }
}