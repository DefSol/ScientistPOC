
using GitHub;

namespace POC.Contracts
{
    public class UserService : IUserService
    {
        
        public User ProcessUserExperiment(int userID)
        {
            var user = Scientist.Science<User>("ProcessUserExperiment", experiment =>
             {
                 experiment.Use(() => ProcessUser(userID));
                 experiment.Try(() => InitialiseUser(userID));                 
             });

            return user;
        }

        /// <summary>
        /// Old Code Block
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public User ProcessUser(int userID)
        {
            var user = GetUser(userID);
            return Validate(user);
        }


        public User InitialiseUser(int userID)
        {

            return null;
        }              

        private User GetUser(int userID)
        {
            User user = new User(userID);
            user.FirstName = "Zack";
            user.LastName = "Holman";
            user.UserName = "zholman";
            user.Age = 43;

            return user;
        }


        private User Validate(User user)
        {
            if(user.Age > 30)
                user.IsValid = true;

            if (user.IsValid)
                user.IsSecure = true;

            return user;
        }

    }
}
