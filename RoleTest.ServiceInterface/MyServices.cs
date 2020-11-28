using System;
using ServiceStack;
using RoleTest.ServiceModel;

namespace RoleTest.ServiceInterface
{
    [Authenticate]
    [RequiresAnyRole("Admin", "SubSite")]
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
