using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literature.Database.Models
{
    public class New
    {
        public int NewId { get; set; }

        public DateTime DateOfNew { get; set; }

        public string NameOfNew { get; set; }

        public string NewDescription { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}
