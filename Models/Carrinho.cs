using System;
using System.Collections.Generic;

namespace Livraria.Models
{
    public class Carrinho
    {   
        public List<Livros> Livro {get; set;}
        public Usuario Usuario {get;set;}
        public string NumCarrinho {get; set;}
       

        
    }
}