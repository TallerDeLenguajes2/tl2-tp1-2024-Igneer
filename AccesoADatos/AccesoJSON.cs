using System.Text;
using System.Text.Json;
using EspacioCadeteria;

class AccesoJSON : AccesoAdatos
{
    public override string obtenerRutaDatosCadeteria()
    {
        string rutaCadeteria = Directory.GetCurrentDirectory()+ @"\Datos\cadeteria.json";
        
        return rutaCadeteria;
    }
        
    public override string obtenerRutaDatosCadete()
    {
        string rutaCadete = Directory.GetCurrentDirectory()+@"\Datos\cadetes.json";
        
        return rutaCadete;
    }
    public override List<Cadete> cargarCadetes(string path)
    {
        if(existeArchivo(path))
        {
            string jsonLeido = File.ReadAllText(path);
            // string jsonLeido =  "[{\"Id\":1,\"Nombre\":\"Andres\",\"Direccion\":\"San Lorenzo 4000\",\"Telefono\":\"3818357816\"}]";


            List<Cadete> cadetes = JsonSerializer.Deserialize<List<Cadete>>(jsonLeido);
            return cadetes;
        }else
        {
            return new List<Cadete>(); 
        }
    }

    public override Cadeteria cargarCadeteria(string path)
    {
        Cadeteria cadeteria;
        if(existeArchivo(path))
        {
            string jsonLeido = File.ReadAllText(path);

            List<Cadeteria> cadeterias = JsonSerializer.Deserialize<List<Cadeteria>>(jsonLeido);

            cadeteria = cadeterias[0];
        }else
        {
            cadeteria = new Cadeteria();
        }
        return cadeteria;
    }
}