using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw1_9518_view.Models
{
    public class Room
    {
        [DisplayName("Id")]
        public int RoomId { get; set; }
        [Required]
        [DisplayName("Number")]
        public int RoomNumber { get; set; }
        [Required]
        [DisplayName("Floor")]
        public int Floor { get; set; }
        [DisplayName("IsAvailable")]
        public bool IsAvailable { get; set; }
        [Required]
        [DisplayName("Price")]
        [RegularExpression("[0-9]+[.[0-9]+]?")]
        public string Price { get; set; }
        [Required]
        [DisplayName("Brief")]
        public string Brief { get; set; }
    }
}
