using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektIS.Models
{
    public class CoverType
    {
        [Key]
        public int id { get; set; }
        [Display(Name="Cover Type")]
        [Required]
        [MaxLength(50)]
        
        public string Name { get; set; }

    }
}
