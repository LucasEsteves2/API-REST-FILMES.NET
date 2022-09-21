using System.ComponentModel.DataAnnotations;

namespace ApiLucasFlix.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
    }
}
