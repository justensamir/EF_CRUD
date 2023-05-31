using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD03.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(200)]
        public string? Description { get; set; }
        public virtual List<New>? News { get; set; } = new List<New>();

        public override string ToString()
        {
            return Name;
        }
    }
}
