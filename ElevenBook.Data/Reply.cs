using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenBook.Models
{
    public class Reply
    {
        [Key]
        public int ReplyId { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
        [Display(Name = "Reply")]
        public string Text { get; set; }
    }
}
