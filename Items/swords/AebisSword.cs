using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace TheSixthMod.Items.swords
{
    public class AebisSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aebis Sword");
            Tooltip.SetDefault("One of all [c/FFD452:Hide] [c/00C2FF:Heaven's] Swords");

            //Traducciones - translates

            DisplayName.AddTranslation(GameCulture.Spanish, "Espada de Aebis");
            Tooltip.AddTranslation(GameCulture.Spanish, "Una de todas las espadas del [c/FFD452:Cielo] [c/00C2FF:Oculto]");

        }

        public override void SetDefaults()
        {
            item.damage = 512;
            item.melee = true;
            item.width = 128;
            item.height = 128;
            item.useTime = 50;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = 100000000;
            item.rare = 13;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override bool CanHitPvp(Player player, Player target)
        {
            target.AddBuff(BuffID.Slow, 300);
            return true;
        }

    }
}