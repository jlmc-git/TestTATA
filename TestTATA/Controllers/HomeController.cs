using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestTATA.Interfaces;
using TestTATA.Models;
using TestTATA.ViewModel;

namespace TestTATA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITextService _textServices;

        public HomeController(ILogger<HomeController> logger, ITextService textServices)
        {
            _logger = logger;
            _textServices = textServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WordCounter(int num)
        {
            TextToCountWordsViewModel textToCount = new TextToCountWordsViewModel();
            return View(textToCount);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult WordCounter([Bind("Text, Word, Result")] TextToCountWordsViewModel textToCount)
        {
            var delimiters = " ,.".ToCharArray();
            string[] allWords = textToCount.Text.Split(' ', ',', '.');
            textToCount.Result = _textServices.CountWordsFromText(textToCount.Text, textToCount.Word).ToString();
            return View(textToCount);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
