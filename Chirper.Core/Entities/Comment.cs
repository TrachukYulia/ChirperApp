using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chirper.Core.Common;

namespace Chirper.Core.Entities
{
    public class Comment:BaseEntity
    {
        public string? Text { get; set; }
        public int PostId { get; set; }
        public Post? Post { get; set; }
    }
}
