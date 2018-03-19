using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class NinjaPants : GlobalItem
	{

		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.NinjaPants)
			{
				item.rare = 2;
				item.defense = 6;
			}
		}
	}
}