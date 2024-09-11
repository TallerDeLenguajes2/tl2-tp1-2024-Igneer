namespace EspacioCadeteria;

class AccesoAdatos
{
    public virtual string obtenerRutaDatos()
    {
        
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


    public virtual void cargarCadetes(string path, Cadeteria cadeteria)
    {
        
    }

    public virtual void cargarCadeteria(string path, Cadeteria cadeteria)
    {
       
    }
    
}