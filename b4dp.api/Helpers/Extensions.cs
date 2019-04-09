using Microsoft.AspNetCore.Http;

namespace b4dp.api.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationMethod(this HttpResponse response, string message)
        {
            response.Headers.Add("Applicaion-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}