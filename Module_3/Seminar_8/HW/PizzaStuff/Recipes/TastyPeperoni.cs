using System;

namespace PizzaStuff.Recipes
{
    public sealed class TastyPeperoni : PizzaRecipe
    {
        public override string Name => "Peperoni";

        public override Ingredients Ingredients => Ingredients.Dough | Ingredients.Mozzarella | Ingredients.Herbs |
                                                   Ingredients.OliveOil | Ingredients.Peperoni |
                                                   Ingredients.TomatoSauce;
    }
}