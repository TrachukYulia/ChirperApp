using Chirper.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Core.Entities
{
    public class Post:BaseEntity
    {
        public string? Title { get; set; }
        public string? Text { get; set; }
        public int Likes { get; set; }
        public DateTime TimeCreated { get; set; }
        public int UserId { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public User? User { get; set; }
    }
}
