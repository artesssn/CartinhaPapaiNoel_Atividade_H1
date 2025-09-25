using System.ComponentModel.DataAnnotations;

namespace CartinhaPapaiNoel.Models
{
    public class Address
    {
        [Required(ErrorMessage = "Rua é obrigatória")]
        [StringLength(255, ErrorMessage = "Rua deve ter no máximo 255 caracteres")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Número é obrigatório")]
        [StringLength(50, ErrorMessage = "Número deve ter no máximo 50 caracteres")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatório")]
        [StringLength(100, ErrorMessage = "Bairro deve ter no máximo 100 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatória")]
        [StringLength(100, ErrorMessage = "Cidade deve ter no máximo 100 caracteres")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Estado é obrigatório")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Estado deve ser a sigla de 2 caracteres (ex: MG)")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "CEP é obrigatório")]
        [RegularExpression(@"^\d{5}-?\d{3}$", ErrorMessage = "CEP inválido. Use 00000-000 ou 00000000")]
        public string Cep { get; set; }
    }
}
