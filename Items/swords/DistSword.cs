using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AllOurSpiritMod.Items.swords
{
    public class DistSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Distortion Sword");  
            Tooltip.SetDefault("You feel in other world"  +"\nPug :v"  + "\n[c/EA899A:Part of Selly's Kit]");
            
            //Traducciones - translates

            DisplayName.AddTranslation(GameCulture.Spanish, "Espada Distorsión");                                                       //Español - Spanish
            Tooltip.AddTranslation(GameCulture.Spanish, "Sientes que estás en otro mundo" +"\nPug :v" + "\n[c/EA899A:Parte del kit de Selly]");     //Español - Spanish
        }

        public override void SetDefaults()
        {
            item.damage = 777;
            item.melee = true;
            item.width = 128;
            item.height = 128;
            item.useTime = 3;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 7f;
            item.value = 777777777;
            item.rare = 7;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override bool CanHitPvp(Player player, Player target)
        {
            target.AddBuff(BuffID.VortexDebuff, 200);
            return true;
        }

        /*
         *
         * Método de obtención:
         * Silly Bag
         * 
         */

    }
}