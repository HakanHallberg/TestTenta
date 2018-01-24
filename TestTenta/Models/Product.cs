using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTenta.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
