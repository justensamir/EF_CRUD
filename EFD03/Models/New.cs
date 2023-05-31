using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD03.Models
{
    public class New
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [StringLength(100)]
        public string Brief { get; set; }
        [StringLength(100)]
        public string? Photo { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime Date { get; set; }
        
        [ForeignKey("Category")]
        public virtual int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        [ForeignKey("User")]
        public virtual int? UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
