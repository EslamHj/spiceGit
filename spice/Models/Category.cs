using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace spice.Models
{
    public class Category
    {   
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name= "Category Name")]
        public string name { get; set; }
    }
}
