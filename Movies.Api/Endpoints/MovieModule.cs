using Carter;
using Movies.Api.Entities;

namespace Movies.Api.Endpoints
{
    public class MovieModule : CarterModule
    {
        public MovieModule() : base("/movies")
        {
            this.RequireAuthorization();
        }
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/", () =>
            {
                return new List<Movie>()
                {
                    new() {
                        Id = 1,
                        Title="The Shawshank Redemption",
                        Genre="Mystery"
                    },
                    new() {
                        Id=2,
                        Title="Life is beautiful",
                        Genre="Drama"
                    }
                };
            });

        }
    }
}
