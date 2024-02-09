using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Elementals.Projectiles;

using System.Diagnostics;

namespace Elementals.Common.GlobalNPCs
{
    internal class DamageOverTimeGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public bool PoisonousArrowDebuff;

        public override void ResetEffects(NPC npc) {
            PoisonousArrowDebuff = false;
        }

        public override void UpdateLifeRegen(NPC npc, ref int damage) {
            if (PoisonousArrowDebuff) {
                int PoisonousCount = 0;
                /*for (int i = 0; i < 1000; i++) {
                    
                    Projectile p = Main.projectile[i];
                    if (p.type == ModContent.ProjectileType<PoisonousArrow>() && p.ai[0] == 1f && p.ai[1] == npc.whoAmI) {
                        PoisonousCount++;
                    }
                }
                if (PoisonousCount == 0) {
                    npc.lifeRegen = -100;
                } else {
                    npc.lifeRegen = PoisonousCount * -3;
                }*/
                npc.lifeRegen = -5;
            }
        }
    }
}