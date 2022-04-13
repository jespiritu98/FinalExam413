using FinalExam413.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam413.Controllers
{
    public class HomeController : Controller
    {
        private QuoteFormContext _repo { get; set; }
       

        //Constructor
        public HomeController(QuoteFormContext temp)
        {
            _repo = temp;
        }


        //Added order by for author
        public IActionResult Index()
        {
            var blah = _repo.Quotes
                .OrderBy(x => x.Author)
                .ToList();
            
            return View(blah);
        }
        //Get and Post Methods for the Movie form, which takes them to the confirmation
        [HttpGet]
        public IActionResult QuoteForm()
        {
            return View();
        }
        [HttpPost]

        public IActionResult QuoteForm(QuoteResponse qr)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(qr);
                _repo.SaveChanges();
                return View("Confirmation", qr);
            }
            else // If Invalid
            {
                return View(qr);
            }

        }


        public IActionResult QuoteDetails(int quoteid)
        {
            var quote = _repo.Quotes.Single(q => q.QuoteId == quoteid);

            return View(quote);
        }

        [HttpGet]
        public IActionResult Edit(int quoteid)
        {

            var quote = _repo.Quotes.Single(q => q.QuoteId == quoteid);

            return View("QuoteForm", quote);
        }
        [HttpPost]
        public IActionResult Edit(QuoteResponse update)
        {
            _repo.Update(update);
            _repo.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int quoteid)
        {
            var quote = _repo.Quotes.Single(q => q.QuoteId == quoteid);

            return View(quote);
        }
        [HttpPost]
        public IActionResult Delete(QuoteResponse qr)
        {
            _repo.Quotes.Remove(qr);
            _repo.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
