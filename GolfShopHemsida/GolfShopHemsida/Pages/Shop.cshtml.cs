using GolfShopHemsida.Models;
using GolfShopHemsida.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace GolfShopHemsida.Pages
{
    public class ShopModel : PageModel
    {
        //private readonly ShoppingCartService _cartService;
        private readonly ItemRepository _itemRepository;

        
        public ShopModel(ItemRepository itemRepository)
        {
            
            _itemRepository = itemRepository;
            Items = new List<Item>();
        }

        public List<Item> Items { get; set; }

        public async Task OnGetAsync()
        {
            Items = await _itemRepository.GetAllItemsAsync();
        }

    }
}
