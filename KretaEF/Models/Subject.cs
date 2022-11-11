using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Model
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public Subject()
        {
            Id = -1;
            Name=string.Empty;
        }

        public Subject(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
