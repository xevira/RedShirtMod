using HarmonyLib;

namespace RedShirtMod
{
    [HarmonyPatch(typeof(BOCOFLHKCOJ), "Start")]
    public static class VersionShowerPatch
    {
        // Methods
        public static void Postfix(BOCOFLHKCOJ __instance)
        {
            __instance.text.Text += "\n[FF0000FF]RedShirt[] Mod v1.0 by Xevira";
        }
    }
}
