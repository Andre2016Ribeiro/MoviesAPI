using System.ComponentModel.DataAnnotations;

namespace appmodel.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        [StringLength(50, ErrorMessage ="Mais 50 caracteres")]
        [Required]
        public string Name { get; set; }
    }
}
