class Pedido
{
    private int nro;
    private string obs;

    private Cliente cliente;

    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }

    private enum Estado
    {
        EnCurso,
        Completado
    }

    public Pedido()
    {
        cliente = new Cliente();
    }
}