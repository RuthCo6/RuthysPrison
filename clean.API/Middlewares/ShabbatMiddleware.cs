namespace clean.API.Middlewares
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;

        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("middlewere start");
            var Shabbat = false;
            if (Shabbat)
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            else
                await _next(context);
            Console.WriteLine("middlewere end");

        }
    }
}
