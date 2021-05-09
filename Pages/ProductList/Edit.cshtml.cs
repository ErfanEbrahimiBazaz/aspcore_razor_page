using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstRazorPage.Data;
using FirstRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstRazorPage.Pages.ProductList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public EditModel(ApplicationDbContext context)
        {
            this._context = context;
        }

        [BindProperty]
        public Product Product  { get; set; }
        public async Task OnGet(int id)
        {
            Product = await _context.Products.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var productFromDb = await _context.Products.FindAsync(Product.Id);
                productFromDb.Name = Product.Name;
                productFromDb.Qty = Product.Qty;
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();

        }
    }
}
