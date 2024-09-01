class Pedido
{
    //Variables
    private static int contador = 0;  //Al usar esta variable en static, se convierte una variable propia de la clase y no de la instancia, quiere decir que al incrementarlo en el constructor se incrementara para todas las demas clases cada vez que se instancia
    private int nro;
    private string obs;
    private Cliente cliente;
    private Estados estado;

    //Propiedades
    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public Estados Estado { get => estado; set => estado = value; }

    //Metodos
    public enum Estados
    {
        EnCurso,
        Completado
    }
    public Pedido()
    {
        cliente = new Cliente();
        nro = ++contador;
        estado = Estados.EnCurso;
    }

    public void cargarPedido()
    {
        System.Console.WriteLine("Ingrese alguna observacion del pedido:");
        obs = Console.ReadLine();
    }

    public void cambiarEstado()
    {
        System.Console.WriteLine("Cambiar a estado:");
        System.Console.WriteLine("1 - Completado");
        estado = Estados.Completado;
    }

    public void mostrarPedido()
    {
        System.Console.WriteLine($"---------------------------\nPedido {Nro}\nEstado: {Estado}\nObservaciones: {obs}\n---------------------------");
    }

}