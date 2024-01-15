using System;
using Terraria;
using Terraria.ModLoader;

namespace Elementals.Content.Buffs
{
	public class BurnDebuffNPC : ModBuff
	{
		public int Counter;
		public override void Update(NPC npc, ref int buffIndex) {
			Counter++;
			NPC.HitInfo.Damage = 10;
            npc.StrikeNPC(NPC.HitInfo);
		}
	}
}