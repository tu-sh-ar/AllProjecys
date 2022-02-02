using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_Relation
{
    internal class Author
    {
        
            public int AuthorId { get; set; }
            public string Name { get; set; }
            public IEnumerable<Books> Books { get; set; }
        
    }
}
