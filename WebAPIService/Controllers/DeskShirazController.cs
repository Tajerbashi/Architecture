using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using WebAPIService.Models;

namespace WebAPIService.Controllers
{
    public class DeskShirazController : Controller
    {
        private readonly JsonSerializerOptions _options;
        HttpClient client= new HttpClient();

        public DeskShirazController()
        {
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

        public async Task<IActionResult> GetTeacherByName(string name)
        {
            // New code:
            HttpContent content = new StringContent(name, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("api/Teachers/GetTeacherByName",content);
            if (!response.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            var ResultContent = await response.Content.ReadAsStringAsync();
            var teachers = JsonSerializer.Deserialize<Teacher>(ResultContent, _options);
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
    }
}
