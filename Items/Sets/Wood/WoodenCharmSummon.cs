using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace UV.Items.Sets.Wood
{
	public class WoodenCharmSummon : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Charm that enhances Summoneable combat" + "\nIncreases minion damage by 1%" + "\nIncreases your max number of minions by 1" + "\nIncreases maximum mana by 10");
			DisplayName.SetDefault("Wooden Dragon Charm");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 32;
			item.value = 10000;
			item.rare = 0;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.maxMinions += 1;
				player.minionDamage += 0.01f;
				player.statManaMax2 += 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.FallenStar);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}