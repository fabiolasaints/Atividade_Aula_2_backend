using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AulaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(string titulo, string autor, int ano)
        {
            return new string[] { " As Brumas de Avalon","Marion Zimmer Bradley","1983"};
        }

        // GET api/values/5
        [HttpGet("{isbn}")]
        public ActionResult<string> Get(string isbn)
        {
            return "ISBN-10:8531210410";
        }

         // POST api/values
        [HttpPost]
        public void Post([FromBody] string comentario)
        {
            //return "Livro incluido com sucesso";
           //  "comentario":"O livro é muito bom";
        }





       
    }
}
