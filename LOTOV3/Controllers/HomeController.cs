using FichesLoto.Services;
using FichesLoto.Shared.Domain;
using LOTOV3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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
            DescriptionGenerale infos = new DescriptionGenerale();

            infos.DateCreation = DateTime.Now;
            infos.DateModification = DateTime.Now;
            infos.DateUtilisation = DateTime.Now;

            return View(infos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private DescriptionGenerale? DescriptionGenerale = default;
        private List<Accessoire>? Accessoires = default;
        private List<PreparationEtapeControle> PreparationsEtapeControle = default;
        private List<EtapeMaitrise>? EtapeMaitrise = default;
        private List<EtapeMaitriseAccessoire>? EtapeMaitriseAccessoire = default;
        private List<EtapeMaitrisePhoto>? EtapeMaitrisePhoto = default;
        private List<Participant>? Participant = default;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            DescriptionGenerale = MockDataService.DescriptionGenerale();
            Accessoires = MockDataService.Accessoires();
            PreparationsEtapeControle = MockDataService.PreparationEtapeControle();
            EtapeMaitrise = MockDataService.EtapeMaitrise();
            EtapeMaitriseAccessoire = MockDataService.EtapeMaitriseAccessoire();
            EtapeMaitrisePhoto = MockDataService.EtapeMaitrisePhoto();
            Participant = MockDataService.Participant();
        }

        private void UsagerDescriptionGeneraleRemarques()
        {
            Console.WriteLine(DescriptionGenerale.UsagerDescriptionGeneraleRemarques);
        }
    }
}
