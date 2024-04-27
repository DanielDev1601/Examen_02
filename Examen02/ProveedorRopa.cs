
namespace Examen02
{
    public class ProveedorRopa : IProveedor
    {
        public string? tipoTela { get; set; }

        public void EnviarPedido(Pedidos pedidos)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine($"Id del Pedido : {pedidos.IdPedido}");
            Console.WriteLine($"Tipo de Pedido : {pedidos.NombrePedido}");
            Console.WriteLine($"Cantidad Pedido : {pedidos.CantidadPedido}");
            Console.WriteLine($"Tipo tela : {tipoTela}");
            Console.WriteLine("==========================================");
        }

    }
}
