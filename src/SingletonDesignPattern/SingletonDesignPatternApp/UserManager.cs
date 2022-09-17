namespace SingletonDesignPatternApp
{
    public class UserManager : IUserManager
    {
        private readonly string[] userNames;

        public UserManager()
        {
            userNames = new[] { "User1", "User2", "User3" };
        }

        public string[] UserNames()
        {
            return userNames;
        }
    }
}