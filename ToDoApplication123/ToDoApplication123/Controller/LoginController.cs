using ToDoApplication123.Model;

namespace ToDoApplication.Controller
{
    public class LoginController
    {
        public bool IsUserRegistered(string username, string password)
        {
            using (ToDoEntities toDo = new ToDoEntities())
            {
                bool isRegistered = false;
                foreach(var user in toDo.Users)
                {
                    if(user.Username == username && user.Password == password)
                    {
                        isRegistered = true;
                    }
                }
                return isRegistered;
            }
        }
    }
}
