using MelonLoader;
using DooDesch.Weapons;

[assembly: MelonInfo(typeof(CrowbarPlus.Core), "CrowbarPlus", DooDesch.ModVersion.Current, "DooDesch", null)]
[assembly: MelonGame("ReLUGames", "MIMESIS")]

namespace CrowbarPlus
{
    public sealed class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            WeaponPreferences.Initialize();
            MelonLogger.Msg("CrowbarPlus initialized for item 2900. Gameplay follows the host.");
        }
        public override void OnUpdate()
        {
            DooDesch.HostSettings.Update();
            WeaponDisplay.Update();
            WeaponReloadAnimation.Update();
        }
    }
}
