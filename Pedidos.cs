class Pedido
{
    private int nro;
    private string obs;

    private Cliente cliente;

    private Estados estado;
    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    private Estados Estado { get => estado; set => estado = value; }

    private enum Estados
    {
        EnCurso,
        Completado
    }


    public Pedido()
    {
        cliente = new Cliente();
    }
}