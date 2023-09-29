using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literature.Database.Models
{
    public class Discussion
    {
        public int DiscussionId { get; set; }

        public DateTime DateOfDiscussion { get; set; }

        public string Topic { get; set; }

        public string? TextDiscussion { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }
    }
}
