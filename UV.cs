using Terraria.ModLoader;

namespace UV
{
	class UV : Mod
	{
		public UV()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
