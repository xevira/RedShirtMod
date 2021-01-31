using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerControl = FFGALNAPKCD;

namespace RedShirtMod
{
    [HarmonyPatch]
    public static class PlayerControllerPatch
    {
        [HarmonyPatch(typeof(FFGALNAPKCD), "MurderPlayer")]
        public static void Postfix(FFGALNAPKCD __instance, FFGALNAPKCD CAKODNGLPDF)
        {
            CAKODNGLPDF.SetColor((byte)0);
        }
    }
}
