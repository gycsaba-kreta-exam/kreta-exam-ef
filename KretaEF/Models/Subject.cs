using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Model
{
    [Index(nameof(Name),IsUnique =true)]
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name field is required.")]
        [StringLength(maximumLength:30,MinimumLength =4)]
        public string Name { get; set; }

    }
}
