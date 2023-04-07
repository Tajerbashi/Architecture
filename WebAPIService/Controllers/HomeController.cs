using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text.Json;
using WebAPIService.Models;

namespace WebAPIService.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly JsonSerializerOptions _options;
        HttpClient client= new HttpClient();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            client.BaseAddress = new Uri("https://localhost:44307/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllTeachers()
        {
            // New code:
            HttpResponseMessage response = await client.GetAsync("api/Teachers/GetAllTeachers");
            if (!response.IsSuccessStatusCode)
            {
                return BadRequest();
                //Teacher teacher = await response.Content.ReadAsAsync<Teacher>();
            }
            //IEnumerable<Teacher> teachers = await response.Content.ReadFromJsonAsync<Teacher>();
            var content = await response.Content.ReadAsStringAsync();
            var companies = JsonSerializer.Deserialize<List<Teacher>>(content,_options);
            ViewBag.response = companies;
            return View();
        }
        public async Task<IActionResult> GetTeacherById()
        {

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}