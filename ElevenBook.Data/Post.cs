using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenBook.Models
{
    public class Post
    {
        //Primary Key
        [Key]
        public int PostId { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(8000)]
        [Display(Name = "Post")]
        public string Text { get; set; }
    }
}
