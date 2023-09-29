using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literature.Database.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string TitleBook { get; set; }

        public string? DescriptionBook { get;set; }

        public int? NumberOfChapter { get; set; }

        //public string? Genre { get; set; }

        public string Type { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Discussion> Discussions { get; set;}

        public ICollection<Genre> Genres { get; set; }

    }
}
