using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class SilentSilkDrop : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (npc.type == NPCID.KingSlime)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("SilentSilk"), Main.rand.Next(5,10));
				Item.NewItem(npc.getRect(), (ItemID.DynastyWood)); Main.rand.Next(3, 5);
			}
		}
	}

}