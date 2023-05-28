public class RedirectMiddleware
{
    private readonly RequestDelegate _next;

    public RedirectMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Check if the user is authenticated
        if (!context.User.Identity.IsAuthenticated
        && context.Request.Path != "/Access/Login"
        && context.Request.Path != "/Access/Signup")
        {
            // Perform the redirect to the desired login page
            context.Response.Redirect("/Access/Login");
            return;
        }

        // Continue processing the request
        await _next(context);
    }
}