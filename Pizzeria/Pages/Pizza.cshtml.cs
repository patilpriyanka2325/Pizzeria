using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new()
        {
            new PizzasModel{ ImageTittle="Margerita", PizzaName="Margerita", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=10},
            new PizzasModel{ ImageTittle="Bolognese", PizzaName="Bolognese", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=12},
            new PizzasModel{ ImageTittle="Carbonara", PizzaName="Carbonara", BasePrice=2, TomatoSauce=true, Mushroom=true, FinalPrice=10},
            new PizzasModel{ ImageTittle="Hawaiian", PizzaName="Hawaiian", BasePrice=2, TomatoSauce=true, Cheese=true, PeriPeri=true, FinalPrice=14},
            new PizzasModel{ ImageTittle="MeatFeast", PizzaName="MeatFeast", BasePrice=2, TomatoSauce=true, Chicken=true, FinalPrice=20},
            new PizzasModel{ ImageTittle="Mushroom", PizzaName="Mushroom", BasePrice=2, TomatoSauce=true, Cheese=true, Mushroom=true, FinalPrice=16},
            new PizzasModel{ ImageTittle="Pepperoni", PizzaName="Pepperoni", BasePrice=2, TomatoSauce=true, Cheese=true, Peperoni=true, FinalPrice=15},
            new PizzasModel{ ImageTittle="Seafood", PizzaName="Seafood", BasePrice=2, Cheese=true, Tuna=true, FinalPrice=17},
            new PizzasModel{ ImageTittle="Vegetarian", PizzaName="Vegetarian", BasePrice=2, TomatoSauce=true, Cheese=true, Pineapple=true, FinalPrice=18}
        };
        public void OnGet()
        {
        }
    }
}
