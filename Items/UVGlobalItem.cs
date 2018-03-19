using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class NinjaBoxDrop : GlobalItem
	{

		public override void OpenVanillaBag(string context, Player player, int arg)
		{
			if (context == "bossBag" && arg == ItemID.KingSlimeBossBag)
			{
				player.QuickSpawnItem(mod.ItemType("NinjaBox")); Main.rand.Next(1,1);
			}
		}
	}
}