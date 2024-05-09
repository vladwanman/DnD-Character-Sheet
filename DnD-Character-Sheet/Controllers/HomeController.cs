using DnD_Character_Sheet.Models;
using DnD_Character_Sheet.Models._4e;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace DnD_Character_Sheet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Char4e()
        {
            return View("4e", new Character4E());
        }

        public IActionResult Char5e()
        {
            return View("5e");
        }

        [HttpPost]
        public IActionResult CreateJson(Character4E character)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var jsonChar = JsonSerializer.Serialize(character, options);

            return File(Encoding.UTF8.GetBytes(jsonChar), "application/json", $"{character.CharacterName}.json");
        }

        [HttpPost]
        public async Task<IActionResult> ReadCharacterAsync(IFormFile jsonFile)
        {
            try
            {
                using (var stream = new MemoryStream())
                {
                    // Copy the file to a memory stream to read its content
                    await jsonFile.CopyToAsync(stream);
                    stream.Seek(0, SeekOrigin.Begin);

                    // Deserialize the JSON content of the file to a Character4E object
                    var character = await JsonSerializer.DeserializeAsync<Character4E>(stream);

                    return View("4e", character);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during file processing
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
