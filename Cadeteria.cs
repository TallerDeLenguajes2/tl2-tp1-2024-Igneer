class Cadeteria
{
    private string nombre;
    private int telefono;
    private List<Cadete> ListadoCadetes;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Telefono { get => telefono; set => telefono = value; }

    public Cadeteria()
    {
        ListadoCadetes = new List<Cadete>();
    }
}