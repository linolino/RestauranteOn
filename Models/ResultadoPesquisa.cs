using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteOnline.Models
{
    public class ResultadoPesquisa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Site { get; set; }
        public bool DisqueEntrega { get; set; }

        public HttpPostedFileBase ImageUpload { get; set; }
    }
}