using System.Security.Cryptography.X509Certificates;
namespace EspacioCadeteria;
class Cadeteria
{
    private string nombre;
    private int telefono;
    private List<Cadete> listadoCadetes = new List<Cadete>();
    private List<Pedido> listadoPedidos  = new List<Pedido>();
    public string Nombre { get => nombre; set => nombre = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public void agregarCadetes(Cadete cadete)
    {
        listadoCadetes.Add(cadete);
    }

    public int JornalACobrar(int idCadete)
    {
        int contador = 0;
        var nroPedidos = from p in listadoPedidos where p.Cadete.Id == idCadete && p.Estado == Pedido.Estados.Completado select p;
        foreach (Pedido p in nroPedidos)
        {
            contador++;
        }
        
        return contador*500;
    }

    public bool asignarCadeteAPedido(int idCadete, int idPedido)
    {
        Pedido pedido = listadoPedidos.FirstOrDefault(p => p.Nro == idPedido);
        Cadete cadete = listadoCadetes.FirstOrDefault(c => c.Id == idCadete);

        if(pedido.Estado != Pedido.Estados.Completado)
        {
            pedido.asociarCadete(cadete);
            return true;
        }else
        {
            return false;
        }
    }
    // public bool reasignarPedido(int idCadeteFinal, int idPedido)
    // {
    //     Cadete cadeteFinal = listadoCadetes.FirstOrDefault(c => c.Id == idCadeteFinal);
        
    //     if(asignarCadeteAPedido(idCadeteFinal, idPedido))
    //     {
    //         return true;
    //     }else
    //     {
    //         return false;
    //     }
    // }

    public void darAltaPedido(string nombre, string direccion, string telefono, string datosReferencia)
    {
        Pedido pedido = new Pedido(nombre, direccion, telefono, datosReferencia);
        listadoPedidos.Add(pedido);
    }

    public string mostrarCadetes()
    {
        string Listado = "Listados Cadetes:\n";
        foreach(Cadete cadete in listadoCadetes)
        {
            Listado = Listado + cadete.datosCadete(); 
        }
        return Listado;
    }
    public string mostrarPedidos()
    {
        string Listado = "Listados Cadetes:\n";
        foreach(Pedido pedido in listadoPedidos)
        {
            Listado = Listado + pedido.datosPedido(); 
        }
        return Listado;
    }

    public void cambiarEstadoPedido(int nroPedido, int opcion)
    {
        Pedido pedido = listadoPedidos.FirstOrDefault(p => p.Nro == nroPedido);
        pedido.cambiarEstado(opcion);
    }
}