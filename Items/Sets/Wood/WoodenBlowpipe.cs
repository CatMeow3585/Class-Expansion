using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Wood
{
	public class WoodenBlowpipe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Blowpipe");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Blowpipe);
			item.value = 100;
			item.useTime = 30;
			item.useAnimation = 30;
			item.width = 38;
			item.height = 8;
			item.autoReuse = false;
			item.damage = 4;
		}
	}
}