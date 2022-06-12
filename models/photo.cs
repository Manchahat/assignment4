using System;
using System.ComponentModel.DataAnnotations;

namespace assignment4.Models
{
    public class photo
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime pic clicked { get; set; }
        public string size { get; set; }
        public decimal camera { get; set; }
    }
}
