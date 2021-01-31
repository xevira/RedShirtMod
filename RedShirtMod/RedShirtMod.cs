using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;

namespace RedShirtMod
{
    [BepInPlugin("gg.xevira.redshirt", "RedShirt Mod", "1.0.0")]
    public class RedShirtMod : BasePlugin
    {
		public static BepInEx.Logging.ManualLogSource log;

		private Harmony _harmony;

		public RedShirtMod()
        {
			log = Log;
        }

		public override void Load()
		{
			log.LogMessage("RedShirt Mod loaded");
			this._harmony = new Harmony("gg.xevira.redshirt");
			this._harmony.PatchAll();
		}
	}
}
