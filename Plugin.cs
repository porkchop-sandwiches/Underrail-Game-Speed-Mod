using BepInEx;
using BepInEx.NET.Common;
using GameplayChanges.Configurations;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace GameplayChanges;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    [HarmonyPatch(typeof(c6o))]
    [HarmonyPatch(nameof(c6o.wm))]
    internal class SpeedPatch
    {
        [HarmonyPostfix]
        public static void Postfix(c60 __instance)
        {
            var d52 = Traverse.Create(__instance).Field("c").GetValue();
            var speedMultiplierField = Traverse.Create(d52).Field("a");
            
            speedMultiplierField.SetValue(0.25 * Configuration.getInstance().speed_multiplier.Value);            
        }
    }

    public override void Load()
    {
        Configuration.instance = new Configuration(Config);
        Configuration.Log = Log;
        var harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);

        var assembly = Assembly.GetExecutingAssembly();
        harmony.PatchAll(assembly);
        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    }
}
