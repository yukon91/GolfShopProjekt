using GolfShopHemsida.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfShopHemsida.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class ProductManagementModel : PageModel
    {
        private readonly AppDbContext _context;

        public ProductManagementModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Item> Items { get; set; } = new();

        [BindProperty]
        public Item NewItem { get; set; }

        public async Task OnGetAsync()
        {
            Items = _context.Items.ToList();
        }

        public async Task<IActionResult> OnPostAddAsync()
        {
            if (!ModelState.IsValid)
            {
                Items = _context.Items.ToList();
                return Page();
            }

            _context.Items.Add(NewItem);
            await _context.SaveChangesAsync();
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var product = await _context.Items.FindAsync(id);
            if (product != null)
            {
                _context.Items.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}