using System.Collections.Generic;

namespace Lab6
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}