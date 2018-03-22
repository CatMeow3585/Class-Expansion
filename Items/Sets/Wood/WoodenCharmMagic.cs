using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace UV.Items.Sets.Wood
{
	public class WoodenCharmMagic : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Charm that enhances Magic combat" + "\n1% increased magic damage and critical strike chance" + "\nIncreases maximum mana by 10 and reduces mana usage by 1%");
			DisplayName.SetDefault("Wooden Star Charm");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.value = 10000;
			item.rare = 0;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.magicDamage += 0.01f;
				player.manaCost -= 0.01f;
				player.magicCrit += 1;
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