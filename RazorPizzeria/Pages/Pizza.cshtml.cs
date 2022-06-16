using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita", PizzaName="Margerita", BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=4},
            new PizzasModel(){ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=15},
            new PizzasModel(){ImageTitle="Vegetarian", PizzaName="Vegetarian", BasePrice=2,TomatoSauce=true,Mushroom=true,FinalPrice=10}
        };
        public void OnGet()
        {
        }
    }
}
