using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenBook.Models
{
    public class PostDetail
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Please enter as least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Title { get; set; }
        [MaxLength(8000)]
        public string Text { get; set; }
    }
}
