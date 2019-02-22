using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteOnline.Models
{
    [MetadataType(typeof(UsuarioMetadado))]
    public partial class Usuario { }

    public class UsuarioMetadado
    {

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [StringLength(50, ErrorMessage = "O Nome dever possuir no maxímo 50 caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O Login é obrigatório.")]
        [StringLength(30, ErrorMessage = "O Login dever possuir no maxímo 30 caracteres")]
        public string Login { get; set; }


        [Required(ErrorMessage = "A Senha é obrigatória.")]
        [StringLength(100, ErrorMessage = "A Senha dever possuir no maxímo 100 caracteres")]
        public string Senha { get; set; }
    }
}