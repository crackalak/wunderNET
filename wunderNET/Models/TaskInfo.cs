using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wunderNET.Models
{
    public class TaskInfo
    {
        public int RecurrenceCount { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string AssigneeId { get; set; }
        public DateTime CompletedAt { get; set; }
        public string UpdatedById { get; set; }
        public string RecurrenceType { get; set; }
        public DateTime DeletedAt { get; set; }
        public string ID { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string RecurringParentId { get; set; }
        public string Note { get; set; }
        public string ParentId { get; set; }
        public int Version { get; set; }
        public string ListId { get; set; }
        public string Type { get; set; }
        public string OwnerId { get; set; }
        public DateTime DueDate { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LocalIdentifier { get; set; }
        public decimal Position { get; set; }
        public bool Starred { get; set; }
    }
}
