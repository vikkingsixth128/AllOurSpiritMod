using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AllOurSpiritMod
{
	class AllOurSpiritMod : Mod
	{
        public AllOurSpiritMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadBackgrounds = true,
                AutoloadGores = true,
                AutoloadSounds = true,

            };
        }

        public override void AddRecipeGroups()
        {
            string evilSoul = Language.GetTextValue("Mods.AllOurSpiritMod.evilSoul");

            RecipeGroup group = new RecipeGroup(() => Language.GetText("37") + " " +evilSoul, new int[]
            {
                ItemID.Ichor,
                ItemID.CursedFlame
            });
            RecipeGroup.RegisterGroup("AllOurSpiritMod:evilSoul", group);
        }

        public void SetTranslation()
        {
            ModTranslation text = CreateTranslation("AllOurSpiritMod:evilSoul");
            text.SetDefault("Evil-hardmode item");
            text.AddTranslation(GameCulture.Spanish, "Objeto corrupto del modo difícil");
            AddTranslation(text);
        }

    }

        
}
