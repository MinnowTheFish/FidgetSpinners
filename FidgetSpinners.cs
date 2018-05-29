using Terraria.ModLoader;

namespace FidgetSpinners
{
    public class FidgetSpinners : Mod
    {
        public FidgetSpinners()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadBackgrounds = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}
