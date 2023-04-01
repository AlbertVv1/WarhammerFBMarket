using Microsoft.AspNetCore.Mvc;
using WarhammerFBMarket.BL.Interfaces;

namespace WarhammerFBMarket.Controllers
{
	public class MiniatureController : Controller
	{
		private readonly IMiniatureBL _miniatureBL;

		public MiniatureController(IMiniatureBL miniatureBL)
		{
			_miniatureBL = miniatureBL;
		}

		[HttpGet]
        public async Task<IActionResult> GetMiniature()
		{
			var response = await _miniatureBL.GetMiniatures();
			return View(response.Data);
		}
	}
}
