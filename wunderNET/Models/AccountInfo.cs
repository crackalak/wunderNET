using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wunderNET.Models
{
    public class AccountInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Product { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Avatar { get; set; }
        public string ConfirmationState { get; set; }
        public string Type { get; set; }
        public string ID { get; set; }
        public bool EmailConfirmed { get; set; }
        public SettingsInfo Settings { get; set; }
    }
}
