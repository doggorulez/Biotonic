using Terraria.ID;
using Terraria.ModLoader;

namespace Biotonic.Items
{
	public class CrowSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Crow Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Ravens are better \n- a dead guy");
		}

		public override void SetDefaults() 
		{
			item.damage = 17;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}