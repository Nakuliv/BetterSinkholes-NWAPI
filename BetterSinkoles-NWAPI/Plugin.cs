using HarmonyLib;

namespace BetterSinkoles_NWAPI
{
    public class Plugin
    {
        public static Plugin Instance { get; private set; }

        [PluginAPI.Core.Attributes.PluginEntryPoint("Better Sinkholes", "1.0.0", "", "Nakuliv")]
        private void Load()
        {
            Instance = this;

            //PluginAPI.Events.EventManager.RegisterEvents(this);
            var instance = new Harmony("SinkholePatch");
            instance.PatchAll();
        }

        [PluginAPI.Core.Attributes.PluginConfig]
        public Config Config;
    }
}
