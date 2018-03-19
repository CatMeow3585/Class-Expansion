using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class NinjaHood : GlobalItem
	{

		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.NinjaHood)
			{
				item.rare = 2;
				item.defense = 4;
			}
		}
	}
}