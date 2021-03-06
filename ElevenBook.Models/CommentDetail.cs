using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenBook.Models
{
    public class CommentDetail
    {
        public int CommentId { get; set; }
        [Required]
        [MaxLength(8000)]
        [Display(Name = "Comment")]
        public string Text { get; set; }
    }
}
