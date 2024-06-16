using ClosedXML.Excel;
using WebApplicationHTML_TO_EXCEL_EXPORT.Entities;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics;
using WebApplicationHTML_TO_EXCEL_EXPORT.Models;

namespace WebApplicationHTML_TO_EXCEL_EXPORT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<FileResult> ExportPeopleExcel()
        {
            var people = await context.People.ToListAsync();
            var FileName = "people.xlsx";
            return GenerateExcel(FileName, people);

        }
        private FileResult GenerateExcel(string FileName, IEnumerable<Person> people)
        {
            DataTable datatable = new DataTable("People");
            datatable.Columns.AddRange(new DataColumn[]
            {
                    new DataColumn("ID"),
                    new DataColumn("Name"),
                    new DataColumn("Email"),
                    new DataColumn("PhoneNO")
            });

            foreach (var person in people)
            {
                datatable.Rows.Add(person.ID,person.Name,person.Email,person.PhoneNO);

            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(datatable);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", FileName);

                }


            }

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
