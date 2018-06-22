using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Livraria.Models
{
    public class Livros
     {
        public string titulo {get; set;}
        public string autor {get; set;}
        public int ano {get; set;}
        public string isbn {get; set;}
        public string comentario {get; set;}
        
        }

    }
