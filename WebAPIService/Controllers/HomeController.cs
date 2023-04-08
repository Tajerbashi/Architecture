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
            }
            var content = await response.Content.ReadAsStringAsync();
            var teachers = JsonSerializer.Deserialize<List<Teacher>>(content,_options);
            ViewBag.response = teachers;
            return View();
        }
        public async Task<IActionResult> GetTeacherById()
        {
            // New code:
            HttpResponseMessage response = await client.GetAsync($"api/Teachers/GetTeacher/{1}");
            if (!response.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            var content = await response.Content.ReadAsStringAsync();
            var teachers = JsonSerializer.Deserialize<Teacher>(content, _options);
            ViewBag.response = teachers;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateTeacher(Teacher teacher)
        {
            // New code:
            var content = new Teacher
            {
                Name = teacher.Name,
                Family = teacher.Family,
                Keys = teacher.Keys,
            };

            HttpResponseMessage response = await client.PostAsJsonAsync("api/Teachers/CreateTeacher", content);

            if (!response.IsSuccessStatusCode)
            {
                // Get the URI of the created resource.
                return BadRequest();
            }
            Uri returnUrl = response.Headers.Location;
            return RedirectToAction("Index", "Home");
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