namespace DooDesch.Weapons
{
    internal static class WeaponDefinition
    {
        internal const string Name = "CrowbarPlus";
        internal static readonly int ItemId = 2900;
        internal static bool IsGun => false;
        internal static bool IsBat => false;
        internal static bool IsReload(int skill) => false;
        internal static bool HasSkill(int skill) => skill == 10806 || skill == 12900;
    }
}
