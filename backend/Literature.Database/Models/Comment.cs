using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literature.Database.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public DateTime DateOfComment { get; set; }

        public string TextComment { get; set;}

        public User User { get; set; }

        public string UserId { get; set; }

        public Book Book { get; set; }

        public int BookId { get; set; }

    }
}
