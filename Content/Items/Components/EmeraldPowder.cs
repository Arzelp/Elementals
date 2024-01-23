using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace Elementals.Content.Items.Components
{
    public class EmeraldPowder : ModItem
    {
        public override void SetDefaults() {
            Item.width = 10;
            Item.height = 10;
            Item.maxStack = 999;
            Item.value = Item.sellPrice(silver: 2, copper: 25);
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(10);
            recipe.AddIngredient(179, 1);
            recipe.Register();
        }
    }
}