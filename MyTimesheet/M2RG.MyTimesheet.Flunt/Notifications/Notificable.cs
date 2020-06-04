using System.Collections.Generic;
using System.Linq;

namespace M2RG.MyTimesheet.Flunt.Notifications
{
    public abstract class Notificable
    {
        public bool IsInvalid => notifications.Any();
        public bool IsValid => !IsInvalid;
        public IReadOnlyCollection<Notification> Notifications => notifications;
        private List<Notification> notifications { get; }

        protected Notificable()
        {
            this.notifications = new List<Notification>();
        }

        public void AddNotification(string key, string property, string message)
        {
            this.notifications.Add(new Notification(key, property, message));
        }

        public void AddNotification(Notification notification)
        {
            this.notifications.Add(notification);
        }

        public void AddNotifications(IReadOnlyCollection<Notification> notifications)
        {
            this.notifications.AddRange(notifications);
        }

        public void AddNotifications(IList<Notification> notifications)
        {
            this.notifications.AddRange(notifications);
        }

        public void AddNotifications(ICollection<Notification> notifications)
        {
            this.notifications.AddRange(notifications);
        }

        public void AddNotifications(Notificable item)
        {
            AddNotifications(item.Notifications);
        }

        public void AddNotifications(params Notificable[] items)
        {
            foreach (var item in items)
                AddNotifications(item);
        }
    }
}
