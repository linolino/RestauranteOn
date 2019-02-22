using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteOnline.Models
{
    [MetadataType(typeof(BairroMetadado))]
    public partial class Bairro { }
    public class BairroMetadado
    {

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [StringLength(50, ErrorMessage = "O Nome deve possuir no maxímo 50 caracteres")]
        public string Nome { get; set; }
    }
}