using System.Linq;

namespace SingletonDesignPatternApp
{
    public class UserProcessor
    {
        private readonly IUserManager _userManager;

        public UserProcessor(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public string Process()
        {
            var users = _userManager.UserNames();
            //we can implement so log here
            return users.FirstOrDefault();
        }
    }
}