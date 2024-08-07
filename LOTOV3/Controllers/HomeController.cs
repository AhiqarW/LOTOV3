using FichesLoto.Services;
using FichesLoto.Shared.Domain;
using LOTOV3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SchemaBD;
using System.Diagnostics;

namespace LOTOV3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Loto()
        {

            var descriptionGenerale = MockDataService.DescriptionGenerale();
            var accessoires = MockDataService.Accessoires();
            var preparationsEtapeControle = MockDataService.PreparationEtapeControle();
            var etapeMaitrise = MockDataService.EtapeMaitrise();
            var etapeMaitriseAccessoire = MockDataService.EtapeMaitriseAccessoire();
            var etapeMaitrisePhoto = MockDataService.EtapeMaitrisePhoto();
            var participant = MockDataService.Participant();

            var model = new LotoViewModel
            {
                DescriptionGenerale = descriptionGenerale,
                Accessoires = accessoires,
                PreparationsEtapeControle = preparationsEtapeControle,
                EtapeMaitrise = etapeMaitrise,
                EtapeMaitriseAccessoire = etapeMaitriseAccessoire,
                EtapeMaitrisePhoto = etapeMaitrisePhoto,
                Participant = participant
            };



            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateComment([FromBody] CommentModel data)
        {
            string comment = data.Comment;
            Console.WriteLine($"Commentaire recu du client: {comment}");

            using (var context = new SchemaContext())
            {
                var description = context.DescriptionGenerales.FirstOrDefault(); 
                if (description != null)
                {
                    description.UsagerDescriptionGeneraleRemarques = comment;
                    await context.SaveChangesAsync();
                    Console.WriteLine("Commentaire actualisé dans la BD.");
                }
            }

            return Ok();
        }


    }


}
