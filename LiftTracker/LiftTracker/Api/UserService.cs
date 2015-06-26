using ServiceStack;
namespace LiftTracker.Api
{
    public class UserService : Service
    {
        public object Post(AddUser request)
        {
            //add the user
            return new AddUserResponse {UserId = 255};
        }
    }

    public class AddUserResponse
    {
        public long UserId { get; set; }
    }

    [Route("/users", "POST")]
    public class AddUser
    {
        public string Name { get; set; }
        public int Goal { get; set; }
    }
}
