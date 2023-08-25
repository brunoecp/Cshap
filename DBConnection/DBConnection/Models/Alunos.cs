using System.ComponentModel.DataAnnotations;

namespace DBConnection.Models
{
    public class Alunos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string nome { get; set; }   
    }
}
