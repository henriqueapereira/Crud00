using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Crud00.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título do Premium")]
        [StringLength(80, ErrorMessage = "O titulo deve conter até 80 caracteres")]
        [MinLength(5, ErrorMessage = "O titulo deve conter pelo menos 5 caracteres")]
        [DisplayName("Titulo")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        //[GreaterThanToday]
        [DisplayName("Inicio")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Término")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Aluno inválido")]
        [DisplayName("Aluno")]
        public int StudentId { get; set; }

        public Student? Student { get; set; }
    }
}
