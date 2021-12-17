using System;
using System.Collections.Generic;

namespace RegistroPedidos.Models
{
    public class ItemPedido
    {
        public string descricao {get; set;}
        public double valor_unitario {get; set;}
        public int quantidade {get; set;}
    }
}