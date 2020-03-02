using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JammedComputers.Models
{
    public class Blog
    {
        public int ID { get; set; }
        [Required, MaxLength(60)]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required, MinLength(50), MaxLength(10000)]
        public string Text { get; set; }
        public string Link { get; set; }
    }
}
