using System.ComponentModel.DataAnnotations;

namespace ApiLucasFlix.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public string Ano { get; set; }


    }
}
