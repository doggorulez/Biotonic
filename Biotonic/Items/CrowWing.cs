using Terraria.ID;
using Terraria.ModLoader;

namespace Biotonic.Items
{
	public class CrowWing : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crow Wing");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.material = true;
			item.width = 40;
			item.height = 40;
			item.value = 5000;
			item.rare = 3;
		}
	}
}