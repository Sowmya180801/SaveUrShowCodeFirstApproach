using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaveUrShowCodeFirstApproach.Models
{
    public class FindTicket
    {
        [Key]
        public int MovieId { get; set; }
        public string Location { get; set; }
        public string Theatrename { get; set; }
        [Required(ErrorMessage = "Movie name is reqd...!!")]
        public string Moviename { get; set; }
        public string Slot { get; set; }
        [Required(ErrorMessage = "Date is reqd...!!")]
        public DateTime? Date { get; set; }
    }
}
