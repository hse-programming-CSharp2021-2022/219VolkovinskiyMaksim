using System;

namespace PizzaStuff.Recipes
{
    public sealed class TastyHawaii : PizzaRecipe
    {
        public override string Name => "Hawaii";

        public override Ingredients Ingredients =>
            Ingredients.Dough | Ingredients.Mozzarella | Ingredients.Ham | Ingredients.Pineapple |
            Ingredients.TomatoSauce;
    }
}
