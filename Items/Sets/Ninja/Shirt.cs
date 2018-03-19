using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class NinjaShirt : GlobalItem
	{

		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.NinjaShirt)
			{
				item.rare = 2;
				item.defense = 8;
			}
		}
	}
}