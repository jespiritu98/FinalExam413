using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam413.Models
{
    //Added Data Validation
    public class QuoteResponse
    {
        [Key]
        [Required]
        public int QuoteId { get; set; }

        [Required]
        public string Quote { get; set; }

        [Required]
        public string Author { get; set; }

        public string Date { get; set; }

        public string Subject { get; set; }


        public string Citation { get; set; }
    }
}
