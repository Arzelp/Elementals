using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialM.Items.Ammo
{
    public class EliteArrow : ModItem
    {
        public override void SetDefaults() {
            Item.width = 13;
            Item.height = 13;

            Item.damage = 5;
            Item.DamageType = DamageClass.Ranged;

            Item.maxStack = 1000;
            Item.consumable = true;
            Item.knockBack = 3f;
            Item.value = Item.sellPrice(copper: 90);
            Item.rare = ItemRarityID.Blue;

            Item.ammo = Item.type;
            Item.shoot = ModContent.ProjectileType<Projectiles.EnlightedArrow>();
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}