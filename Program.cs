// See https://aka.ms/new-console-template for more information
//Estado conviene más hacerlo enum ya que quizás en un futuro además de realizado y no realizado, quizas agregar en camino no sería posible si asignara bool
//Hacer un campo publico no esta bien visto, siempre se trabaja con campos y atributos privados, mientras que las propiedades y los metodos pueden ser publicos
AccesoAdatos datos = new AccesoAdatos();
Cadeteria cadeteria = new Cadeteria();

datos.cargarCadetes("cadetes.csv", cadeteria);
datos.cargarCadeteria("cadeteria.csv", cadeteria);

int opcion = 2;
Pedido pedido = null;

while(opcion <=4  && opcion >= 1)
{
    System.Console.WriteLine("1 - Dar de alta un pedido");
    System.Console.WriteLine("2 - Asignar pedido a un cadete");
    System.Console.WriteLine("3 - Cambiar estado de un pedido");
    System.Console.WriteLine("4 - Reasignar pedido a otro cadete");
    System.Console.WriteLine("5 - Salir");


    System.Console.WriteLine("Ingrese una opcion:");
    int.TryParse(Console.ReadLine(), out opcion);
    switch(opcion)
    {
        case 1:
            pedido = new Pedido();
            break;
        case 2:
            int nroCadete;
            if(pedido != null)
            {
                cadeteria.mostrarCadetes();
                System.Console.WriteLine("Ingrese el id del cadete que asignara el pedido:");
                int.TryParse(Console.ReadLine(), out nroCadete);
                cadeteria.ListadoCadetes[nroCadete].agregarPedido(pedido);
                pedido = null;
            }else
            {
                System.Console.WriteLine("No se dio de alta ningun pedido, no fue posible asignar");
            }
            break;
        case 3:
            cadeteria.mostrarCadetes();
            System.Console.WriteLine("Ingrese el nro de cadete del cual cambiara el estado del pedido:");
            int.TryParse(Console.ReadLine(), out nroCadete);

            Cadete cadete = cadeteria.ListadoCadetes[nroCadete-1]; 
            cadete.mostrarPedidos();
            
            System.Console.WriteLine("Ingrese el nro del pedido a cambiar:");
            int.TryParse(Console.ReadLine(), out int nroPedido);
            pedido = cadete.ListadoPedidos.FirstOrDefault(p => p.Nro == nroPedido);
            pedido.cambiarEstado();
            break;
        case 4:
            cadeteria.reasignarPedido();
            break;
    }
}