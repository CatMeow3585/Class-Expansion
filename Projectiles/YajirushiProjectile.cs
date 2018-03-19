using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Projectiles
{
	public class YajirushiProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Yajirushi");           
		}

		public override void SetDefaults()
		{
			projectile.width = 10;               
			projectile.height = 5;                                  
			aiType = ProjectileID.WoodenArrowFriendly;        
            projectile.aiStyle = 1; //How the projectile works
            projectile.friendly = true;  //Tells the game whether it is friendly to players/friendly npcs or not
            projectile.hostile = false; //Tells the game whether it is hostile to players or not
            projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
            projectile.ignoreWater = true; //Tells the game whether or not projectile will be affected by water
            projectile.ranged = true;   //Tells the game whether it is a ranged projectile or not
            projectile.penetrate = 10; //Tells the game how many enemies it can hit before being destroyed
            projectile.timeLeft = 400; //The amount of time the projectile is alive for
            projectile.light = 0.1f; //This defines the projectile light
            aiType = 1; // this is the projectile ai style . 1 is for arrows style
		}

		public override void Kill(int timeLeft)
		{
			Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y); // Play a death sound
			Vector2 usePos = projectile.position; // Position to use for dusts
			// Please note the usage of MathHelper, please use this! We subtract 90 degrees as radians to the rotation vector to offset the sprite as its default rotation in the sprite isn't aligned properly.
			Vector2 rotVector =
				(projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2(); // rotation vector to use for dust velocity
			usePos += rotVector * 16f;

			// Spawn some dusts upon javelin death
			for (int i = 0; i < 20; i++)
			{
				// Create a new dust
				Dust dust = Dust.NewDustDirect(usePos, projectile.width, projectile.height, 81);
				dust.position = (dust.position + projectile.Center) / 2f;
				dust.velocity += rotVector * 2f;
				dust.velocity *= 0.5f;
				dust.noGravity = true;
				usePos -= rotVector * 8f;
			}

			// Drop a javelin item, 1 in 18 chance (~5.5% chance)
			int item =
				Main.rand.Next(18) == 0
					? Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, mod.ItemType<Items.Sets.Ninja.Yajirushi>())
					: 0;

			// Sync the drop for multiplayer
			// Note the usage of Terraria.ID.MessageID, please use this!
			if (Main.netMode == 1 && item >= 0)
			{
				NetMessage.SendData(MessageID.SyncItem, -1, -1, null, item, 1f);
			}
		}

	}
}
