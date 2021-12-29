using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockerBO;
using StockerDAL;

namespace StockerBLL
{
    public class UserManager
    {

        private UserRepository userRepository;
        public UserManager()
        {
            userRepository = new UserRepository();
        }

        public void AddUser(Utilisateur user)
        {
            userRepository.Add(user);
        }
        public Utilisateur Authenticate(string email, string password)
        {
            var users = userRepository.FindByEmail(email);
            foreach (var user in users)
                if (user.EmailU.ToLower()== email.ToLower() && user.PasswordU == password)
                    return user;
            return null;
        }
        public void EditUser(Utilisateur oldUser, Utilisateur newUser)
        {
            userRepository.Set(oldUser, newUser);
        }
    }
}
