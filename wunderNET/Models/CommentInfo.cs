using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wunderNET.Models
{
    public class CommentInfo
    {
        public string ChannelType { get; set; }
        public string ChannelId { get; set; }
        public DateTime LocalCreatedAt { get; set; }
        public AuthorInfo Author { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Type { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CommentId { get; set; }
    }
}
