using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public string ID { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }
        public string Genre { get; set; }

        public int Year { get; set; }
        public int Runtime { get; set; }

    }
}
