using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementals.Content.Buffs
{
    public class BurnDebuff : ModBuff
    {
        public override void SetStaticDefaults() {
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            BuffID.Sets.LongerExpertDebuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex) {
            player.GetModPlayer<BurnDebuffPlayer>().burnDebuff = true;
        }
    }

    public class BurnDebuffPlayer : ModPlayer
    {
        public bool burnDebuff;

        public override void ResetEffects() {
            burnDebuff = false;
        }

        public override void UpdateBadLifeRegen() {
            if (burnDebuff) {
                if (Player.lifeRegen > 0) {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegenTime = 0;
                Player.lifeRegen -= 12;
            }
        }
    }
}