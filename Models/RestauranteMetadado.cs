using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace RestauranteOnline.Models
{
    [MetadataType(typeof(RestauranteMetadado))]
    public partial class Restaurante
    {
    }
    public class RestauranteMetadado
    {
        public Int32 IDRestaurante { get; private set; }

        [Required(ErrorMessage = "O nome é Obrigatório")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no maximo 30 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Endereço é Obrigatório")]
        [StringLength(50, ErrorMessage = "O Nome deve possuir no maximo 50 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O Telefone é Obrigatório")]
        [StringLength(13, ErrorMessage = "O Telefone deve possuir no maximo 11 caracteres")]
        public string Telefone { get; set; }


        [StringLength(40, ErrorMessage = "O Site deve possuir no maximo 40 caracteres")]
        public string Site { get; set; }

        [Required(ErrorMessage = "È obrigatorio informar se o restaurante tem disque entrega ")]
        public bool DisqueEntrega { get; set; }

        //[Required]
        //[DataType(DataType.ImageUrl)]
        //[Display(Name = "Foto")]
        //public HttpPostedFileBase ImageUpload { get; set; }



        //[Required]
        //[DataType(DataType.ImageUrl)]
        //[Display(Name = "Imagem")]
        //public HttpPostedFileBase ImageUpload { get; set; }

        [Display(Name = "Genero")]
        [Required(ErrorMessage = "O Genero e obrigatorio")]
        public int IDGenero { get; set; }
        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O Bairro é obrigatorio")]
        public int IDBairro { get; set; }

    }
}