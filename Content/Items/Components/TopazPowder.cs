using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace Elementals.Content.Items.Components
{
    public class TopazPowder : ModItem
    {
        public override void SetDefaults() {
            Item.width = 10;
            Item.height = 10;
            Item.maxStack = 999;
            Item.value = Item.sellPrice(copper: 10);
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(10);
            recipe.AddIngredient(180, 1);
            recipe.Register();
        }
    }
}