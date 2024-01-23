using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

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
                npc.lifeRegen = -5;
            }
        }
    }
}