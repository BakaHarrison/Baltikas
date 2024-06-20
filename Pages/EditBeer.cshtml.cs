using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;
using WebApplication1.Repository;

namespace WebApplication1.Pages
{
    public class EditBeerModel : PageModel
    {

        public EditBeerModel(IBaltika BeerRepository)
        {
            _beer = BeerRepository;
        }

        private IBaltika _beer;
        public Baltika? Beer { get; set; }

        public IActionResult OnGet(int id)
        {
            Beer = _beer.Get(id);
            Beer ??= new();
            return Page();
        }

        public IActionResult OnPost(Baltika? BeerForm)
        {

            var BaltikaDB = _beer.Update(BeerForm);
            if (BaltikaDB == null) return NotFound();
            return Page();
        }
    }
}
