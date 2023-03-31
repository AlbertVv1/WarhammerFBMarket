using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WarhammerFBMarket.DAL.Repositories;
using WarhammerFBMarket.Models;

namespace WarhammerFBMarket.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly MiniatureRepository _miniatureRepository;

		//public HomeController(ILogger<HomeController> logger)
		//{
		//	_logger = logger;
		//}

		public HomeController(MiniatureRepository miniatureRepository)
		{
			_miniatureRepository = miniatureRepository;
		}

		public async Task<IActionResult> Index()
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