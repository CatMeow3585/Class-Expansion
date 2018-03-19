using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace UV.Items.Sets.Ninja
{
    public class KusagiramaFlail : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chained Kusagirama");
		}

        public override void SetDefaults()
        {
            item.width = 50;
            item.height = 46;
            item.value = Item.sellPrice(5, 0, 0, 0);
            item.rare = 2;
 
            item.noMelee = true; // Makes sure that the animation when using the item doesn't hurt NPCs.
            item.useStyle = 5; // Set the correct useStyle.
            item.useAnimation = 40; // Determines how long the animation lasts.
            item.useTime = 40; // Determines how fast you can use this weapon (a lower value results in a faster use time).
            item.knockBack = 7.5F;
            item.damage = 15;
			item.scale = 2F;
            item.noUseGraphic = true; // Do not use the item graphic when using the item (we just want the ball to spawn).
            item.shoot = mod.ProjectileType("KusagiramaFlailProjectileBlade");
            item.shootSpeed = 15.1F;
            item.UseSound = SoundID.Item1;
            item.melee = true; // Deals melee damage.
            item.channel = true; // We can keep the left mouse button down when trying to keep using this weapon.
        }
 
    }
}