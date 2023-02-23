using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaveUrShowCodeFirstApproach.Models
{
    public class BookTicket
    {
        [Key]
        public long Bookid { get; set; }
        public int? Seatnum { get; set; }

        [ForeignKey("MovieId")]
        public int? MovieId { get; set; }

        [ForeignKey("UserId")]
        public int? Userid { get; set; }
        public DateTime? Date { get; set; }

        public virtual FindTicket Movie { get; set; }
        public virtual Registration User { get; set; }

    }
}
