namespace Ex046.Entities
{
    internal class LogItem
    {
        public User User { get; set; }
        public DateTime Moment { get; set; }

        public LogItem(User user, DateTime moment)
        {
            User = user;
            Moment = moment;
        }

        public override int GetHashCode()
        {
            return User.Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogItem))
            {
                return false;
            }

            LogItem other = (LogItem)obj;

            return User.Username.Equals(other.User.Username);
        }
    }
}
