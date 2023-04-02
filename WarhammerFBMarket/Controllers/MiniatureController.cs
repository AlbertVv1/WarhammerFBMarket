using Microsoft.AspNetCore.Mvc;
using WarhammerFBMarket.BL.Implementations;

namespace WarhammerFBMarket.Controllers
{
	public class MiniatureController : Controller
	{
		private readonly MiniatureBL _miniatureBL;

		public MiniatureController(MiniatureBL miniatureBL)
		{
			_miniatureBL = miniatureBL;
		}

		[HttpGet]
        public async Task<IActionResult> GetMiniatures()
		{
			var response = await _miniatureBL.GetMiniatures();
			return View(response.Data);
		}
		[HttpGet]
		public async Task<IActionResult> GetMiniature(int id)
		{
			var response = await _miniatureBL.GetMiniature(id);

			if (response.StatusCode == Domain.Enum.StatusCode.Success)
			{
				return View(response.Data);
			}

			return RedirectToAction("Error");
		}
		[HttpGet]
		public async Task<IActionResult> GetMiniatureByName(string name)
		{
			var response = await _miniatureBL.GetMiniatureByName(name);

			if (response.StatusCode == Domain.Enum.StatusCode.Success)
			{
				return View(response.Data);
			}

			return RedirectToAction("Error");
		}
		[HttpGet] 
		public async Task<IActionResult> Delete(int id)
		{
			var response = await _miniatureBL.DeleteMiniature(id);

			if (response.StatusCode == Domain.Enum.StatusCode.Success)
			{
				return RedirectToAction("GetMiniatures");
			}

			return RedirectToAction("Error");
		}
	}
}
