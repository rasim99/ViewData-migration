using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewDataViewBag.Models;

namespace ViewDataViewBag.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			//ViewData
			//var p = new Product
			//{
			//	Id = 1,
			//	Name = "Product1",
			//	Price = 122
			//};

			//ViewData["ProductName"] = p.Name;
			//ViewData["Name"] = "Name";
			//ViewData["Surname"] = "Surname";
			//ViewData["Age"] = 20;

			//ViewBag
			//ViewBag.Name = "Lorem";
			//ViewBag.Surname = "Doler";
			//ViewBag.Age = 27;
			//ViewBag.Product = p;
			//var productList = new List<Product>();
			//productList.Add(p);
			//ViewBag.Products = productList;

			//TempData -- digerlerinden ferqi controllerin basqa actionunda cagirmaq olur
			//TempData["Name"] = "Name";
			//TempData["SurName"] = "SurName";
			//TempData["age"] = 20;
			ViewData["Name"] = "Name";
			ViewBag.Surname = "Surname";
			TempData["Age"] = 33;

			return RedirectToAction(nameof(About));
		}
		public IActionResult About()
		{
			return View();
		}

	}
}
