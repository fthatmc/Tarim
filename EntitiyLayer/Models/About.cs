using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Models
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutHistory { get; set; }
        public string AboutUs { get; set; }
    }
}
