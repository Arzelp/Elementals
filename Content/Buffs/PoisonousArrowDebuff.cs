using Elementals.Common.GlobalNPCs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementals.Content.Buffs
{
	public class PoisonousArrowDebuff : ModBuff
	{
		public override void SetStaticDefaults() {
			BuffID.Sets.GrantImmunityWith[Type].Add(BuffID.BoneJavelin);
		}

		public override void Update(NPC npc, ref int buffIndex) {
			npc.GetGlobalNPC<DamageOverTimeGlobalNPC>().PoisonousArrowDebuff = true;
		}
	}
}