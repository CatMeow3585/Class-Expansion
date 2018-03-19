using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class NinjaBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ninja Box");
			Tooltip.SetDefault("Right Click to open");
		}
		public override void SetDefaults()
		{
			item.maxStack = 999;
            item.consumable = true;
            item.width = 26;
            item.height = 28;
            item.rare = 11;
            bossBagNPC = NPCID.KingSlime;
			item.expert = (true);
		}
		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			int choice = Main.rand.Next(10);//cambiar a todos
			if (choice == 0)
			{
				player.QuickSpawnItem(mod.ItemType("Katana"));
			}
			if (choice == 1)
			{
				player.QuickSpawnItem(mod.ItemType("Ono"));
			}
			if (choice == 2)
			{
				player.QuickSpawnItem(mod.ItemType("Otsuchi"));
			}
			if (choice == 3)
			{
				player.QuickSpawnItem(mod.ItemType("Hankyu"));
				player.QuickSpawnItem(mod.ItemType("Yajirushi"), Main.rand.Next(111,111));
			}
			if (choice == 4)
			{
				player.QuickSpawnItem(mod.ItemType("Kunai"), Main.rand.Next(74,74));
			}
			if (choice == 5)
			{
				player.QuickSpawnItem(mod.ItemType("Shuriken"), Main.rand.Next(74,74));
			}
			if (choice == 6)
			{
				player.QuickSpawnItem(mod.ItemType("Kimura"));
			}
			if (choice == 7)
			{
				player.QuickSpawnItem(mod.ItemType("Kusagirama"));
			}
			if (choice == 8)
			{
				player.QuickSpawnItem(mod.ItemType("SilentSilk"), Main.rand.Next(1,3));
			}
			if (choice == 9)
			{
				player.QuickSpawnItem(mod.ItemType("BlackGlove"));
				player.QuickSpawnItem(mod.ItemType("Kunai"), Main.rand.Next(37,37));
				player.QuickSpawnItem(mod.ItemType("Shuriken"), Main.rand.Next(37,37));
			}
			player.QuickSpawnItem(ItemID.DynastyWood, Main.rand.Next(5, 10));
			player.QuickSpawnItem(mod.ItemType("SilentSilk"), Main.rand.Next(1,3));
		}
	}
}