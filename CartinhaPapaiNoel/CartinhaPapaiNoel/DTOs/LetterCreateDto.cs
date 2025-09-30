using CartinhaPapaiNoel.Models;
using System.ComponentModel.DataAnnotations;

namespace CartinhaPapaiNoel.DTOs
{
    public class LetterCreateDto
    {
        [Required(ErrorMessage = "Nome da criança é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 e 255 caracteres")]
        public string NomeCrianca { get; set; }

        [Required(ErrorMessage = "Endereço é obrigatório")]
        public Address Endereco { get; set; }

        [Required(ErrorMessage = "Idade é obrigatória")]
        [Range(0, 14, ErrorMessage = "Apenas crianças menores de 15 anos são aceitas (0 a 14)")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Texto da carta é obrigatório")]
        [StringLength(500, ErrorMessage = "Texto da carta deve ter no máximo 500 caracteres")]
        public string TextoCarta { get; set; }
    }
}
