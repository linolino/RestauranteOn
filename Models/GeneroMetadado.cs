using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteOnline.Models
{
    [MetadataType(typeof(GeneroMetadado))]
    public partial class Genero { }
    public class GeneroMetadado
    {
        [Required(ErrorMessage = "A Decrição é obrigatório.")]
        [StringLength(40, ErrorMessage = "A Descrição dever possuir no maxímo 40 caracteres")]
        public string Descricao { get; set; }
    }
}