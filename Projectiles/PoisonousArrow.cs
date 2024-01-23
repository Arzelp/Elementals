using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Elementals.Content.Items.Ammo;
using Elementals.Content.Buffs;

namespace Elementals.Projectiles
{
	// This projectile showcases advanced AI code. Of particular note is a showcase on how projectiles can stick to NPCs in a manner similar to the behavior of vanilla weapons such as Bone Javelin, Daybreak, Blood Butcherer, Stardust Cell Minion, and Tentacle Spike. This code is modeled closely after Bone Javelin.
	public class PoisonousArrow : ModProjectile
	{
		public override void SetDefaults() {
			Projectile.width = 16; // The width of projectile hitbox
			Projectile.height = 16; // The height of projectile hitbox
			Projectile.aiStyle = 0; // The ai style of the projectile (0 means custom AI). For more please reference the source code of Terraria
			Projectile.friendly = true; // Can the projectile deal damage to enemies?
			Projectile.hostile = false; // Can the projectile deal damage to the player?
			Projectile.DamageType = DamageClass.Ranged; // Makes the projectile deal ranged damage. You can set in to DamageClass.Throwing, but that is not used by any vanilla items
			Projectile.penetrate = 2; // How many monsters the projectile can penetrate.
			Projectile.timeLeft = 600; // The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			Projectile.alpha = 255; // The transparency of the projectile, 255 for completely transparent. Our custom AI below fades our projectile in. Make sure to delete this if you aren't using an aiStyle that fades in.
			Projectile.light = 0.5f; // How much light emit around the projectile
			Projectile.ignoreWater = true; // Does the projectile's speed be influenced by water?
			Projectile.tileCollide = true; // Can the projectile collide with tiles?
			Projectile.hide = true; // Makes the projectile completely invisible. We need this to draw our projectile behind enemies/tiles in DrawBehind()
		}

        public override bool PreDraw(ref Color lightColor) {
            Main.instance.LoadProjectile(Projectile.type);
            Texture2D texture = TextureAssets.Projectile[Projectile.type].Value;

            Vector2 drawOrigin = new Vector2(texture.Width * 0.5f, Projectile.height * 0.5f);
            for (int k = 0; k < Projectile.oldPos.Length; k++) {
                Vector2 drawPos = (Projectile.oldPos[k] - Main.screenPosition) + drawOrigin + new Vector2(0f, Projectile.gfxOffY);
                Color color = Projectile.GetAlpha(lightColor) * ((Projectile.oldPos.Length - k) / (float)Projectile.oldPos.Length);
                Main.EntitySpriteDraw(texture, drawPos, null, color, Projectile.rotation, drawOrigin, Projectile.scale, SpriteEffects.None, 0);
            }

            return true;
        }

        public override void OnKill(int timeLeft) {
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
        }

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone) {
            target.AddBuff(ModContent.BuffType<PoisonousArrowDebuff>(), 500);
		}
	}
}