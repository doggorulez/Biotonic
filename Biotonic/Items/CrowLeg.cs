using Terraria.ID;
using Terraria.ModLoader;

namespace Biotonic.Items
{
	public class CrowLeg : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Crow Leg");
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