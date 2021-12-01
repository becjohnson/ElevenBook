using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenBook.Models
{
    public class ReplyListItem
    {
        public int ReplyId { get; set; }
        [Required]
        [MaxLength(8000)]
        [Display(Name = "Reply")]
        public string Text { get; set; }
    }
}
