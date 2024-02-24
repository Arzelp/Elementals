using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementals.Content.Items.Weapons.Melee
{
    public class StoneFireSword : ModItem
    {
        public override void SetDefaults() {
            Item.width = 40;
            Item.height = 40;
            Item.value = Item.sellPrice(copper: 1);
            Item.rare = ItemRarityID.White;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 2;
            Item.knockBack = 1f;
            Item.crit = 20;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;
            Item.UseSound = SoundID.Item1;

        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.Register();
        }
    }
}