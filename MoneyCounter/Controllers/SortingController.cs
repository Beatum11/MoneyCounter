using Microsoft.AspNetCore.Mvc;
using MoneyCounter.Controllers;

namespace MoneyCounter.Controllers
{
    public class SortingController : Controller
    {

        public IActionResult SortByScending()
        {
            var newList = MoneyController.notes.OrderBy(n => n.Spending).ToList();
            MoneyController.notes = newList;

            foreach (var note in MoneyController.notes)
            {
                MoneyController.moneyHandler.Spend -= note.Spending;
            }
            return RedirectToAction("Index", "Money", new { area = "" });
        }

        public IActionResult SortByDescending()
        {
            var newList = MoneyController.notes.OrderByDescending
                                          (n => n.Spending).ToList();
            MoneyController.notes = newList;

            foreach (var note in MoneyController.notes)
            {
                MoneyController.moneyHandler.Spend -= note.Spending;
            }
            return RedirectToAction("Index", "Money", new { area = "" });
        }

        public IActionResult SortByDate()
        {
            var newList = MoneyController.notes.OrderBy
                                          (n => n.Date).ToList();
            MoneyController.notes = newList;

            foreach (var note in MoneyController.notes)
            {
                MoneyController.moneyHandler.Spend -= note.Spending;
            }
            return RedirectToAction("Index", "Money", new { area = "" });
        }

        public IActionResult SortByCategory()
        {
            var newList = MoneyController.notes.OrderBy
                                          (n => n.Theme).ToList();
            MoneyController.notes = newList;

            foreach (var note in MoneyController.notes)
            {
                MoneyController.moneyHandler.Spend -= note.Spending;
            }
            return RedirectToAction("Index", "Money", new { area = "" });
        }

    }
}
