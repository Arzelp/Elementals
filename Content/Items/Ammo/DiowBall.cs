using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Elementals.Content.Items.Components;

namespace Elementals.Content.Items.Ammo
{
    public class DiowBall : ModItem {
        public override void SetDefaults() {
            Item.width = 10;
            Item.height = 10;
            Item.damage = 12;
            Item.DamageType = DamageClass.Ranged;
            Item.maxStack = 1000;
            Item.consumable = true;
            Item.knockBack = 1f;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.value = Item.sellPrice(copper: 10);
            Item.rare = ItemRarityID.White;
            Item.ammo = AmmoID.Snowball;
            Item.shootSpeed = 8.5f;
            Item.shoot = ModContent.ProjectileType<Projectiles.DiowBall>();
            Item.useStyle = ItemUseStyleID.Shoot;

        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Snowball, 1)
            recipe.AddIngredient<SapphirePowder>(5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}