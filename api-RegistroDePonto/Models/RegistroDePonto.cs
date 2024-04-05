using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_RegistroDePonto.Models
{
    [Table("Registro")]
    public class RegistroDePonto
    {
        [Key]
        public int Id { get; set; }
        
        [Required]        
        public string NomeFuncionario { get; set; }
        
        [Required]
        public TimeSpan EntradaManha { get; set; }
        
        [Required]
        public TimeSpan SaidaManha { get; set; }
        
        [Required]
        public TimeSpan EntradaTarde { get; set; }
        
        [Required]
        public TimeSpan SaidaTarde { get; set; }

    }
}
