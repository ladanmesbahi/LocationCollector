using LocationCollector.Core;
using LocationCollector.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LocationCollector.Pages.AddPerson
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _cotext;

        [BindProperty]
        public Person Person { get; set; }
        public CreateModel(ApplicationDbContext cotext)
        {
            _cotext = cotext;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                _cotext.People.Add(Person);
                _cotext.SaveChanges();
            }
            else
                throw new System.Exception();
        }
    }
}
