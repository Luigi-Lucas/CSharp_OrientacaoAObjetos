using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    public class Pedido
    {
        public int idPedido;
        public ItensPedido itemPedido;
        public Cliente cliente;
        public double valorTotalPedido;
    }
}
