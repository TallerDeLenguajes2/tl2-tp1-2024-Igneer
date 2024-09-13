namespace EspacioCadeteria;

class AccesoAdatos
{
    public virtual string obtenerRutaDatosCadeteria()
    {
        return "";
    }

    public virtual string obtenerRutaDatosCadete()
    {
        return "";
    }
    public bool existeArchivo(string path)
    {
        FileInfo file = new FileInfo(path); //crep un objeto archivo y path es la ruta donde esta el archivo
        if(file.Exists && file.Length > 0)
        {
            return true;
        }else{
            return false;
        }
    }


    public virtual List<Cadete> cargarCadetes(string path)
    {
        return new List<Cadete>();
    }

    public virtual Cadeteria cargarCadeteria(string path)
    {
       return new Cadeteria();
    }
    
}