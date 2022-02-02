using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_Relation
{
    internal class BookCatagory
    {
        public int BookId { get; set; }
        public Books Book { get; set; }
        public int CategoryId { get; set; }
        public Catagory Catagory { get; set; }
    }
}
