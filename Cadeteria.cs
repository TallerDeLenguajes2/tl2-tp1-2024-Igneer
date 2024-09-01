using System.Security.Cryptography.X509Certificates;

class Cadeteria
{
    private string nombre;
    private int telefono;
    private List<Cadete> listadoCadetes = new List<Cadete>();

    public string Nombre { get => nombre; set => nombre = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }

    public void agregarCadetes(Cadete cadete)
    {
        ListadoCadetes.Add(cadete);
    }

    public void mostrarCadetes()
    {
        System.Console.WriteLine("Cadetes:");
        foreach(Cadete cadete in ListadoCadetes)
        {
            System.Console.WriteLine($"Cadete {cadete.Id}\nNombre: {cadete.Nombre}\nTelefono: {cadete.Telefono}");
        }
    }

    public void reasignarPedido()
    {
        Pedido pedido;
        mostrarCadetes();
        System.Console.WriteLine("Ingrese el nro de cadete del cual reasignara el pedido:");
        int.TryParse(Console.ReadLine(), out int nroCadete);
        
        Cadete cadete = ListadoCadetes[nroCadete-1]; 
        cadete.mostrarPedidos();
        
        System.Console.WriteLine("Ingrese el nro del pedido a reasignar:");
        int.TryParse(Console.ReadLine(), out int nroPedido);
        pedido = cadete.ListadoPedidos.FirstOrDefault(p => p.Nro == nroPedido);

        cadete.ListadoPedidos.RemoveAll(p => p.Nro == nroPedido);

        mostrarCadetes();
        System.Console.WriteLine("Ingrese el numero de cadete al cual le reasignara el pedido anteriormente seleccionado:");
        int.TryParse(Console.ReadLine(), out nroCadete);
        
        cadete = ListadoCadetes[nroCadete-1];
        cadete.agregarPedido(pedido);
    }
}