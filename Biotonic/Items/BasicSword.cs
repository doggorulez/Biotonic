using Terraria.ID;
using Terraria.ModLoader;

namespace Biotonic.Items
{
	public class BasicSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("SQUID GAMES !!!!11!1!1!!"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("SQUID GAMES !!!!11!1!1!!");
		}

		public override void SetDefaults() 
		{
			item.damage = 50000;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}