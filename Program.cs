using EspacioCadeteria;
//Estado conviene más hacerlo enum ya que quizás en un futuro además de realizado y no realizado, quizas agregar en camino no sería posible si asignara bool
//Hacer un campo publico no esta bien visto, siempre se trabaja con campos y atributos privados, mientras que las propiedades y los metodos pueden ser publicos
AccesoAdatos datos = new AccesoAdatos();
Cadeteria cadeteria = new Cadeteria();

datos.cargarCadetes("cadetes.csv", cadeteria);
datos.cargarCadeteria("cadeteria.csv", cadeteria);

int opcion = 2;

while(opcion <=4  && opcion >= 1)
{
    System.Console.WriteLine("1 - Dar de alta un pedido");
    System.Console.WriteLine("2 - Asignar cadete a un pedido");
    System.Console.WriteLine("3 - Cambiar estado de un pedido");
    System.Console.WriteLine("4 - Reasignar pedido a otro cadete");
    System.Console.WriteLine("5 - Salir");


    System.Console.WriteLine("Ingrese una opcion:");
    int.TryParse(Console.ReadLine(), out opcion);
    switch(opcion)
    {
        case 1:
            darAltaPedido();
            break;
        case 2:
            asignarCadeteAPedido();
            break;
        case 3:
            cambiarEstadoPedido();
            break;
        case 4:
            reasignarPedido();
            break;
    }
}

void darAltaPedido()
{
    System.Console.WriteLine("Ingrese nombre del cliente del pedido: ");
    string nombre = Console.ReadLine();
    System.Console.WriteLine("Ingrese direccion del cliente del pedido: ");
    string direccion = Console.ReadLine();
    System.Console.WriteLine("Ingrese telefono del cliente del pedido: ");
    string telefono = Console.ReadLine();
    System.Console.WriteLine("Ingrese datos de referencia del cliente del pedido: ");
    string datosRefencia = Console.ReadLine();
    cadeteria.darAltaPedido(nombre, direccion, telefono, datosRefencia);
}

void asignarCadeteAPedido()
{
    int opcion = 1;
    while(opcion >= 1 || opcion <=3)
    {
        System.Console.WriteLine("0 - Mostrar Cadetes");
        System.Console.WriteLine("1 - Mostrar Pedidos");
        System.Console.WriteLine("2 - Asignar Cadete a Pedido");
    }

    switch(opcion)
        {
            case 0:
                cadeteria.mostrarPedidos();
                break;
            case 1:
                cadeteria.mostrarCadetes();
                break;
            case 2:
                System.Console.WriteLine("Ingresa el numero de pedido al cual va a asignar un cadete: ");
                int.TryParse(Console.ReadLine(), out int nroPedido);
                System.Console.WriteLine("Ingresa el numero del cadete: ");
                int.TryParse(Console.ReadLine(), out int nroCadete);
                if(cadeteria.asignarCadeteAPedido(nroCadete, nroPedido))
                {
                    System.Console.WriteLine("Asignacion exitosa!");
                }else
                {
                    System.Console.WriteLine("No se pudo asignar!");
                }
                break;
            default:
                break;
        }    
}

void cambiarEstadoPedido()
{
    cadeteria.mostrarPedidos();
    System.Console.WriteLine("Ingrese el nro del pedido a cambiar su estado: ");
    int.TryParse(Console.ReadLine(), out int nroPedido);
    System.Console.WriteLine("Estados:");
    System.Console.WriteLine("1 - Completado");
    System.Console.WriteLine("Ingrese una opcion");
    int.TryParse(Console.ReadLine(), out int opcion);
    cadeteria.cambiarEstadoPedido(nroPedido, opcion);
}

void reasignarPedido()
{
    cadeteria.mostrarPedidos();
    System.Console.WriteLine("Ingrese el nro del pedido a reasignar");
    int.TryParse(Console.ReadLine(), out int nroPedido);
    cadeteria.mostrarCadetes();
    System.Console.WriteLine("Ingrese el nro del cadete a asignar");
    int.TryParse(Console.ReadLine(), out int nroCadete);

    if(cadeteria.asignarCadeteAPedido(nroCadete, nroPedido))
    {
        System.Console.WriteLine("Asignacion exitosa!");
    }else
    {
        System.Console.WriteLine("No se pudo asignar!");
    }
}