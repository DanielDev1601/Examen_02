
namespace Examen02
{
    public class ProveedorElectronica : IProveedor
    {

        public string? tipoElectronico { get; set; }        

        public void EnviarPedido(Pedidos pedidos)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine($"Id del Pedido : {pedidos.IdPedido}");
            Console.WriteLine($"Tipo de Pedido : {pedidos.NombrePedido}");
            Console.WriteLine($"Cantidad Pedido : {pedidos.CantidadPedido}");
            Console.WriteLine($"Tipo Electrónico : {tipoElectronico}");
            Console.WriteLine("==========================================");            
        }
    }
}
