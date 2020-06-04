namespace M2RG.MyTimesheet.Flunt.Notifications
{
    public sealed class Notification
    {
        public string Key { get; set; }
        public string Property { get; set; }
        public string Message { get; set; }

        public Notification()
        {
        }

        public Notification(string key, string property, string message)
        {
            Key = key;
            Property = property;
            Message = message;
        }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Property) ? Message : $"{Property} - {Message}";
        }
    }
}
