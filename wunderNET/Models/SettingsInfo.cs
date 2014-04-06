using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wunderNET.Models
{
    public class SettingsInfo
    {
        public string SmartlistVisibilityWeek { get; set; }
        public string SmartlistVisibilityToday { get; set; }
        public string ConfirmDeleteEntity { get; set; }
        public string SmartlistVisibilityStarred { get; set; }
        public string PrintCompletedItems { get; set; }
        public string SoundNotificationEnabled { get; set; }
        public string NewsletterSubscriptionEnabled { get; set; }
        public string AccountLocale { get; set; }
        public string NewTaskLocation { get; set; }
        public string SmartlistVisibilityAll { get; set; }
        public string SmartlistVisibilityDone { get; set; }
        public string NotificationsDesktopEnabled { get; set; }
        public string Background { get; set; }
        public string SoundCheckoffEnabled { get; set; }
        public string NotificationsEmailEnabled { get; set; }
        public string UseBadgeIcon { get; set; }
    }
}
