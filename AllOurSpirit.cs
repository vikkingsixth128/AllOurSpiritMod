using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using TheSixthMod.Items;

namespace TheSixthMod
{
	class Thesixthmod : Mod
	{
		public Thesixthmod()
		{
            
        }

            

           public override void AddRecipeGroups()
        {
            string evilSoul = Language.GetTextValue("Mods.TheSixthMod.evilSoul");

            RecipeGroup group = new RecipeGroup(() => Language.GetText("37") + " " +evilSoul, new int[]
            {
                    ItemID.Ichor,
                    ItemID.CursedFlame
            });
            RecipeGroup.RegisterGroup("TheSixthMod:EvilSouls", group);
        }

        public void SetTranslation()
        {
            ModTranslation text = CreateTranslation("evilSoul");
            text.SetDefault("Evil-hardmode item");
            text.AddTranslation(GameCulture.Spanish, "Objeto corrupto del modo difícil");
            AddTranslation(text);
        }

    }

        
}
