using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wunderNET.Models
{
    public class ListInfo
    {
      public string Title { get; set; }
      public DateTime CreatedAt { get; set; }
      public DateTime UpdatedAt { get; set; }
      public int Version { get; set; }
      public string LocalIdentifier { get; set; }
      public decimal Position { get; set; }
      public string Type { get; set; }
      public string ID { get; set; }
      public string OwnerId { get; set; }
    }
}
