using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Uv.Items.Sets.Wood
{
	public class WoodenArmorBuff : GlobalItem
	{
		static string SetBonus = "WoodBuff";

		public override string IsArmorSet (Item head, Item body, Item legs)
		{
		   if (head.type == ItemID.WoodHelmet && body.type == ItemID.WoodBreastplate && legs.type == ItemID.WoodGreaves)
			return SetBonus;
			return "";
		}

		public override void UpdateArmorSet(Player player, string set)
		{
			if (set == "WoodBuff")
			{
			player.meleeDamage += 0.1f;
			player.setBonus = "+1 defense" + "\n+x% of extra damage";
			}
		}
	}
}