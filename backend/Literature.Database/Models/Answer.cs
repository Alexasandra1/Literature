using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literature.Database.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }

        public string AnswerText { get; set; }

        public DateTime DateOfAnswer { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }

        public Discussion Discussion { get; set; }

        public int DiscussionId { get; set; }
    }
}
