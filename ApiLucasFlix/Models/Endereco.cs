using System.ComponentModel.DataAnnotations;

namespace ApiLucasFlix.Models
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        public Cinema Cinema { get; set; }
    }
}
