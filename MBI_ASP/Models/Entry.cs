using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MBI_ASP.Models
{
    public class Entry 
    {
        public int Id { get; set; }

        [DisplayName("Weight (kg)")]

        public double Weight { get; set; }


        [DisplayName("Height (kg)")]

        public double Height { get; set; }


        [DisplayName("Gender (M/F)")]

        public string Gender { get; set; }


        [NotMapped]
        public double MBI { get; set; }
        [NotMapped]
        public string Classification { get; set; }
    }
}