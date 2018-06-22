using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Livraria.Models
{    
    public class Usuario
    {
        public string usuario { get; set; }
        public string senha { get; set; }
    }
}