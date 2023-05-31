using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD03.Models
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(50, MinimumLength = 8)]
        public string Password { get; set; }
        [MaxLength(50)]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [StringLength(50, MinimumLength = 6)]
        public string Username { get; set; }
        [StringLength(100)]
        public string? Photo { get; set; }
        public int? Age { get; set; }
        [StringLength(50)]
        public string? Address { get; set; }
        public virtual List<New>? News { get; set; } = new List<New>();

        public override string ToString()
        {
            return Name;
        }
    }
}
