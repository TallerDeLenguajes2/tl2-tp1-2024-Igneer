using EspacioCadeteria;

class AccesoCSV : AccesoAdatos
{
    public override void cargarCadetes(string path, Cadeteria cadeteria)
    {
        if(existeArchivo(path))
        {
            StreamReader x = new StreamReader(path); //Levanto el archivo csv
            string lineas= x.ReadLine(); //en esta linea se lee una linea de un arhivo, y comienzo con la primera linea del csv
            while(lineas != null)//Con el while voy iterando linea por linea hasta que llegue a una vacia
            {
                string [] campos = lineas.Split(','); //lineas.Split(',') devuelve un arreglo cuyos campos son cada elemento entre comas
                int.TryParse(campos[0], out int id);
                Cadete cadete = new Cadete(id, campos[1], campos[2], campos[3]);
                cadeteria.agregarCadetes(cadete);
                lineas = x.ReadLine();
            }
        }
    }

    public override void cargarCadeteria(string path, Cadeteria cadeteria)
    {
        if(existeArchivo(path))
        {
        StreamReader x = new StreamReader(path); //Levanto el archivo csv
        string lineas= x.ReadLine(); //en esta linea se lee una linea de un arhivo, y comienzo con la primera linea del csv
            string [] campos = lineas.Split(','); //lineas.Split(',') devuelve un arreglo cuyos campos son cada elemento entre comas
            cadeteria.Nombre = campos[0];
            int.TryParse(campos[1], out int telefono);
            cadeteria.Telefono = telefono;
        }
    }
}