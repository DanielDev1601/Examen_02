// See https://aka.ms/new-console-template for more information


using Examen02;

IProveedor proveedorElectronico = new ProveedorElectronica { tipoElectronico = "Percutor" };
IProveedor proveedorRopa = new ProveedorRopa { tipoTela = "Algodon"};

GestorPedidos gestorPedidos = new GestorPedidos();

Pedidos pedidoElectronico = new Pedidos { IdPedido = 1, NombrePedido = "Electronicos", CantidadPedido = 18};
Pedidos pedidoRopa = new Pedidos { IdPedido = 2, NombrePedido = "Ropa", CantidadPedido = 28 };

Console.WriteLine($"Enviando Pedidos");
gestorPedidos.EnviarPedidoSegunTipoProducto(pedidoElectronico, proveedorElectronico);
gestorPedidos.EnviarPedidoSegunTipoProducto(pedidoRopa, proveedorRopa);
Console.ReadLine();