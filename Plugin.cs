using BepInEx;
using BepInEx.NET.Common;
using HarmonyLib;
using System.Reflection;

namespace SpeedUp;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
#if UNDERRAIL13015
    internal const string underrailVersion = "1.3.0.15";
#elif UNDERRAIL13016
    internal const string underrailVersion = "1.3.0.16";
#elif UNDERRAIL13017
    internal const string underrailVersion = "1.3.0.17";
#elif UNDERRAIL1310
    internal const string underrailVersion = "1.3.1.0";
#else
    // latest Underrail version
    internal const string underrailVersion = "1.3.1.1";
#endif

    public override void Load()
    {
        Configuration.instance = new Configuration(Config);
        Configuration.Log = Log;
        var harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);

        var assembly = Assembly.GetExecutingAssembly();
        harmony.PatchAll(assembly);
        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} v{MyPluginInfo.PLUGIN_VERSION} for Underrail v{underrailVersion} is loaded!");
    }
}
