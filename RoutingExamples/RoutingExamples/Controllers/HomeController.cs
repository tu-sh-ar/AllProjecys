using Microsoft.AspNetCore.Mvc;

namespace RoutingExamples.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public void RouteIndex()
        {
            Console.WriteLine("hello");
        }
        [HttpGet("/name")]
        public void RoutePage2()
        {
            Console.WriteLine("Routed to page 2");
        }
        [HttpGet("/age")]
        public void RoutePage3()
        {
            Console.WriteLine("Routed to AGe");
        }
        
    }
}
