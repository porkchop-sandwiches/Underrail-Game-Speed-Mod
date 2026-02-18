using BepInEx.Configuration;
using BepInEx.Logging;

namespace SpeedUp
{
    public sealed class Configuration
    {
        private Configuration() { }
        public static volatile Configuration instance;

        public static Configuration GetInstance()
        {
            return instance;
        }
        public static ManualLogSource Log { get; set; }
        private ConfigFile Config { get; set; }
        public ConfigEntry<int> Speed_multiplier { get; private set; }

        public Configuration(ConfigFile _config)
        {
            Config = _config;
            Speed_multiplier = Config.Bind("Constants", "speed_multiplier", 3, "Multiplies game speed increase by it's value");
        }
    }
}
