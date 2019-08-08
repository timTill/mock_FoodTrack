using FridgeTracker.Models;
using FridgeTracker.ViewModels;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridgeTracker.Controllers
{
	public class HomeController : Controller
	{
		private readonly IFridgeFoodRepository _iFridgeFoodRepository;
		private readonly HostingEnvironment _hostingEnvironment;

		public HomeController(IFridgeFoodRepository iFridgeFoodRepository,
								HostingEnvironment hostingEnvironment)
		{
			_iFridgeFoodRepository = iFridgeFoodRepository;
			this._hostingEnvironment = hostingEnvironment;
		}

		public ViewResult Index(int? id)
		{
			IndexViewModel indexViewModel = new IndexViewModel()
			{
				Categories = Enum.GetValues(typeof(Category)),
				CountByCateg = _iFridgeFoodRepository.GetCountByCategory()
			};

			if (id == null)
			{
				indexViewModel.fridgeFoodList = _iFridgeFoodRepository.GetAllFridgeFood();
				indexViewModel.tagNumber = -1;
			}
			else
			{
				indexViewModel.fridgeFoodList = _iFridgeFoodRepository.GetFridgeFoodByCateg(id ?? 1);
				indexViewModel.tagNumber = id ?? -1;
			}
			return View(indexViewModel);
		}

		[HttpGet]
		public ViewResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(FridgeFood fridgeFood)
		{
			if (ModelState.IsValid)
			{
				_iFridgeFoodRepository.Add(fridgeFood);
				return RedirectToAction("details", new { id = fridgeFood.ID });
			}
			return View();
		}

		public ViewResult Details(int? id)
		{
			FridgeFood ff = _iFridgeFoodRepository.GetFridgeFood(id ?? 1);
			return View(ff);
		}

		[HttpGet]
		public ViewResult Edit(int id)
		{
			FridgeFood ff = _iFridgeFoodRepository.GetFridgeFood(id);
			return View(ff);
		}

		[HttpPost]
		public IActionResult Edit(FridgeFood editedFridgeFood)
		{
			if (ModelState.IsValid)
			{
				FridgeFood oldFridgeFood = _iFridgeFoodRepository.GetFridgeFood(editedFridgeFood.ID);
				oldFridgeFood.Name = editedFridgeFood.Name;
				oldFridgeFood.BestBefore = editedFridgeFood.BestBefore;
				oldFridgeFood.Category = editedFridgeFood.Category;
				oldFridgeFood.Measurement = editedFridgeFood.Measurement;
				oldFridgeFood.Unit = editedFridgeFood.Unit;
				_iFridgeFoodRepository.Update(oldFridgeFood);
				return RedirectToAction("details", new { id = editedFridgeFood.ID });
			}
			return View();
		}

		[HttpPost]
		public IActionResult delete(int id)
		{
			FridgeFood ff = _iFridgeFoodRepository.GetFridgeFood(id);			
			_iFridgeFoodRepository.Delete(id);
			return RedirectToAction("index");
		}
	}
}
