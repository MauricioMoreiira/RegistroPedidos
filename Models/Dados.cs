using System;
using System.Collections.Generic;

namespace RegistroPedidos.Models
{
    public class Dados
    {
        public static Pedido PedidoAtual;

        static Dados(){
            PedidoAtual = new Pedido();
        }
    }
}