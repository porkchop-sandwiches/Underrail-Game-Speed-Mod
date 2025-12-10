using BepInEx.Configuration;
using BepInEx.Logging;

namespace GameplayChanges.Configurations
{
    public sealed class Configuration
    {

        private Configuration() {}

        public static volatile Configuration instance;

        public static Configuration getInstance() {
            return instance;
        }

        public static ManualLogSource Log { get; set; }

        private ConfigFile config { get; set; }

        public ConfigEntry<int> speed_multiplier { get; private set; }

        public Configuration(ConfigFile _config)
        {
            config = _config;

            speed_multiplier = config.Bind("Constants", "speed_multiplier", 3, "Multiplies game speed increase by it's value");
        }

    }

}
