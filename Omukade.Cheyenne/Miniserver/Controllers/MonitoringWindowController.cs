using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Omukade.Cheyenne.Miniserver.Controllers
{
    public class MonitoringWindowController : Controller
    {
        // GET: MonitoringWindowController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MonitoringWindowController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MonitoringWindowController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MonitoringWindowController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MonitoringWindowController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MonitoringWindowController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MonitoringWindowController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MonitoringWindowController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
