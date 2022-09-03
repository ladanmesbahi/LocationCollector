using LocationCollector.Core;
using LocationCollector.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace LocationCollector.Pages.PeopleList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Person> People { get; set; }
        public Person Person { get; set; } = new Person();
        public decimal Lat { get; set; }
        public decimal Lang { get; set; }
        public void OnGet()
        {
            People = _context.People.ToList();
        }
    }
}
