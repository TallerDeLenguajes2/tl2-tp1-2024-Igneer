class Pedido
{
    private int nro;
    private string obs;

    private Cliente cliente;

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