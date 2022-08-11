using Microsoft.AspNetCore.Mvc;
using MoneyCounter.Models;
using System.Dynamic;

namespace MoneyCounter.Controllers
{
    public class MoneyController : Controller
    {

        #region Basic data

        internal static List<NoteModel> notes = new List<NoteModel>();
        internal static MoneyHandler moneyHandler = new MoneyHandler();

        #endregion

        public IActionResult Index()
        {
            moneyHandler.Left = moneyHandler.Limit;
            moneyHandler.Spend = 0;
            dynamic myModel = new ExpandoObject();
            myModel.MoneyHandler = moneyHandler;
            myModel.notes = notes;
            return View(myModel);
        }

        #region Create new purchase
        public IActionResult CreatePurchase()
        {
            moneyHandler.Spend = 0;
            return View();
        }

        public IActionResult AddPurchase(NoteModel note)
        {
            notes.Add(note);
            return RedirectToAction("Index");
        }

        #endregion


        #region Add a limit 
        public IActionResult SettingsHandler()
        {
            return View(moneyHandler);
        }

        public IActionResult SettingsEdit(MoneyHandler _moneyHandler)
        {
            moneyHandler.Limit = _moneyHandler.Limit;
            return RedirectToAction("Index");
        }

        #endregion

    }
}
