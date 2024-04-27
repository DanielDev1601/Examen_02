using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02
{
    public class GestorPedidos
    {

        public void EnviarPedidoSegunTipoProducto(Pedidos pedidos, IProveedor _iproveedor)
        {
            _iproveedor.EnviarPedido(pedidos);
        }

    }
}
