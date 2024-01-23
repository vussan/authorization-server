using Carter;

namespace AuthorizationServer.Endpoints
{
    public class AuthorizationModule : CarterModule
    {
        public AuthorizationModule() : base("/account") { }
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/", () => "Hello World!");

        }
    }
}
