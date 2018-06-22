using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.Models
{
    public class CartaoDados
    {   public Usuario Usuario { get; set; }
        public string Pedido { get; set; } 
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string NumCart { get; set; }
        public string Codseg { get; set; }
        public string Validade { get; set; }
        
        
        
    }     
}