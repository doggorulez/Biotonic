using Terraria.ID;
using Terraria.ModLoader;

namespace Biotonic.Items
{
	public class PlasticBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Plastic Bag");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.crit = -1;
			item.damage = +3;
			item.defense = -40;
			item.width = 40;
			item.height = 40;
			item.value = 5000;
			item.rare = 6;
		}
	}
}