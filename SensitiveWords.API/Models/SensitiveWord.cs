using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SensitiveWords.API.Models
{
    public class SensitiveWord
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string word { get; set; }

    }
}