using HarmonyLib;

namespace SpeedUp
{
#if UNDERRAIL13017
    // for Underrail v1.3.0.15-v1.3.0.17
    [HarmonyPatch(typeof(c58))]
    [HarmonyPatch(nameof(c58.wx))]
    internal class SpeedPatch
    {
        [HarmonyPostfix]
        public static void Postfix(c60 __instance)
        {
            const string classField = "c"; // name of private class property holder on the patched class
            const string speedDouble = "a"; // speed constant

            var d5y = Traverse.Create(__instance).Field(classField).GetValue();
            var speedMultiplierField = Traverse.Create(d5y).Field(speedDouble);

            speedMultiplierField.SetValue(0.25 * Configuration.GetInstance().Speed_multiplier.Value);
        }
    }
#elif UNDERRAIL1310
    // for Underrail v1.3.1.0
    [HarmonyPatch(typeof(c6z))]
    [HarmonyPatch(nameof(c6z.xd))]
    internal class SpeedPatch
    {
        [HarmonyPostfix]
        public static void Postfix(c7r __instance)
        {
            const string classField = "c"; // name of private class property holder on the patched class
            const string speedDouble = "a"; // speed constant

            var d6f = Traverse.Create(__instance).Field(classField).GetValue();
            var speedMultiplierField = Traverse.Create(d6f).Field(speedDouble);

            speedMultiplierField.SetValue(0.25 * Configuration.GetInstance().Speed_multiplier.Value);
        }
    }
#else
    // for latest Underrail, v1.3.1.1
    [HarmonyPatch(typeof(c6z))]
    [HarmonyPatch(nameof(c6z.xd))]
    internal class SpeedPatch
    {
        [HarmonyPostfix]
        public static void Postfix(c7r __instance)
        {
            const string classField = "c"; // name of private class property holder on the patched class
            const string speedDouble = "a"; // speed constant

            var d6f = Traverse.Create(__instance).Field(classField).GetValue();
            var speedMultiplierField = Traverse.Create(d6f).Field(speedDouble);

            speedMultiplierField.SetValue(0.25 * Configuration.GetInstance().Speed_multiplier.Value);
        }
    }
#endif
}
