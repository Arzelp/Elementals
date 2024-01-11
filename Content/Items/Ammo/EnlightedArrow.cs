using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Elementals.Content.Items.Components;

namespace Elementals.Content.Items.Ammo
{
    public class EnlightedArrow : ModItem
    {
        public override void SetDefaults() {
            Item.width = 13;
            Item.height = 13;

            Item.damage = 5;
            Item.DamageType = DamageClass.Ranged;

            Item.maxStack = 1000;
            Item.consumable = true;
            Item.knockBack = 3f;
            Item.value = Item.sellPrice(copper: 50);
            Item.rare = ItemRarityID.Blue;

            Item.ammo = AmmoID.Arrow;
            Item.shoot = ModContent.ProjectileType<Projectiles.EnlightedArrow>();
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.WoodenArrow, 1);
            recipe.AddIngredient<TopazPowder>(3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}