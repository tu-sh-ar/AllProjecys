using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_Relation
{
    internal class Catagory
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<BookCatagory> BookCatagory { get; set; }
    }
}
