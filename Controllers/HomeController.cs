using System.Diagnostics;
using Intro.Models;
using Intro.Services;
using Microsoft.AspNetCore.Mvc;

namespace Intro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly iServiceCounter servicesCounter;
        ServicesCounter services = new ServicesCounter();
        public HomeController(ILogger<HomeController> logger, iServiceCounter servicesCounter)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //ViewBag.Name = "Татьяна";
            //ViewBag.Secondname = "Викторовна";
            //ViewBag.Surname = "Лугинина";
            Person person = new Person();
            person.Age = 42;
            person.Name = "Татьяна";
            person.Secondname = "Викторовна";
            person.Surname = "Лугинина";

            return View(person);
        }
        public IActionResult Test()
        {
            ViewBag.One = "30.10.2021 сертификат Microsoft Non Relational Data";
            ViewBag.Two = "07.08.2021 сертификат Microsoft Database Fundamentals";
            ViewBag.Three = "16.04.2021 сертификат Cisco IT Essentials";
            ViewBag.Four = "06.05.2020 сертификат ОАО РЖД Организация обработки и обеспечение безопасности персональных данных ОАО РЖД";
            return View();
        }
        public IActionResult Privacy()
        {
            ViewData["First"] = "Июнь 2012 — по настоящее время 10 лет 5 месяцев Российские железные дороги, ОАО ";
            ViewData["Second"] = "Бухгалтер 1 категории Ведение бухгалтерского учёта материалов, списание материальных затрат на производство, проведение инвентаризаций.  С 13 года бухгалтер по учету расчётов с персоналом, расчёт заработной платы, заявки на платежи по заработной плате, требования на перечисление заработной платы в банк. С 2016г.бухгалтер сектора учета банковских операций.";
            ViewData["Therd"] = "Январь 2005 — январь 2012 7 лет 1 месяц ГК Септима Новосибирск Экономист: Создание плановых бюджетов предприятия, бюджет движения денежных средств , планирование прибыли аналитика продаж.";
            return View();
        }

        public IActionResult IndexContent()
        {
            return Content("Counter => " + servicesCounter.GetCounter());
        }
        public IActionResult IndexJson()
        {
            return Json("sss");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}