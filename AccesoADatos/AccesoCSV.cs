using EspacioCadeteria;

class AccesoCSV : AccesoAdatos
{

    public override string obtenerRutaDatosCadeteria()
    {   
        string rutaCadeteria =Directory.GetCurrentDirectory()+ @"\Datos\cadeteria.csv";

        return rutaCadeteria;
    }
        
    public override string obtenerRutaDatosCadete()
    {   
        string rutaCadete =Directory.GetCurrentDirectory()+ @"\Datos\cadetes.csv";

        return rutaCadete;
    }
    public override List<Cadete> cargarCadetes(string path)
    {
        List<Cadete> listadoCadetes = new List<Cadete>();
        if(existeArchivo(path))
        {
            StreamReader x = new StreamReader(path); //Levanto el archivo csv
            string lineas= x.ReadLine(); //en esta linea se lee una linea de un arhivo, y comienzo con la primera linea del csv
            while(lineas != null)//Con el while voy iterando linea por linea hasta que llegue a una vacia
            {
                string [] campos = lineas.Split(','); //lineas.Split(',') devuelve un arreglo cuyos campos son cada elemento entre comas
                int.TryParse(campos[0], out int id);
                Cadete cadete = new Cadete(id, campos[1],campos[2],campos[3]);
                listadoCadetes.Add(cadete);
                lineas = x.ReadLine();
            }
        }
        return listadoCadetes;
    }

    public override Cadeteria cargarCadeteria(string path)
    {
        Cadeteria cadeteria;
        if(existeArchivo(path))
        {
            StreamReader x = new StreamReader(path); //Levanto el archivo csv
            string lineas= x.ReadLine(); //en esta linea se lee una linea de un arhivo, y comienzo con la primera linea del csv
            string [] campos = lineas.Split(','); //lineas.Split(',') devuelve un arreglo cuyos campos son cada elemento entre comas
            cadeteria = new Cadeteria(campos[0], campos[1]);
        }else
        {
            cadeteria = new Cadeteria();
        }

        return cadeteria;
    }
}