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


        [DisplayName("Height (cm)")]

        public double Height { get; set; }


        [DisplayName("Gender (M/F)")]

        public string Gender { get; set; }


    
        public double MBI { get; set; }
     
        public string Classification { get; set; }
    }
}