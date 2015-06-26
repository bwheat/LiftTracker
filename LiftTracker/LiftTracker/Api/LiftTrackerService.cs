using ServiceStack;

namespace LiftTracker.Api
{
    public class LiftTrackerService : Service
    {
        public object Any(LiftTrackerRequest request)
        {
            return new LiftTrackerResponse { Result = "Hello, " + request.Name };
        }
    }

    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class LiftTrackerRequest
    {
        public string Name { get; set; }
    }

    public class LiftTrackerResponse
    {
        public string Result { get; set; }
    }
}