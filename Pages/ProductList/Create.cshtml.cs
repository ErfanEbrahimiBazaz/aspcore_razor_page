using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstRazorPage.Data;
using FirstRazorPage.Models;

namespace FirstRazorPage.Pages.ProductList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateModel(ApplicationDbContext context)
        {
            this._context = context;
        }
        [BindProperty]
        public Product Product{ get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _context.AddAsync(Product);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }

    }
}
