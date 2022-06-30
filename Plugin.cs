using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using SDG.Unturned;
using System;

namespace UnturnedExamplePlugin
{
    public class Plugin : RocketPlugin<PluginConfiguration>
    {
        public static Plugin Instance { get; private set; } // Your plugin variable
        public UnityEngine.Color MessageColor { get; private set; } // Message color variable
        public Random Random { get; private set; } // Randomizer variable

        protected override void Load()
        {
            Instance = this; // Link plugin and make this public
            MessageColor = UnturnedChat.GetColorFromName(Configuration.Instance.MessageColor, UnityEngine.Color.black); // Get message color from config
            Random = new Random(); // Create and set new Random object for use later in plugin
            Logger.Log(Configuration.Instance.LoadMessage); // Log load message with Rocket
            CommandWindow.Log($"{Name} {Assembly.GetName().Version} has been loaded!"); // Log loading info with Unturned SDG (without Rocket or other loaders)
        }
        protected override void Unload()
        {
            CommandWindow.LogWarning($"{Name} {Assembly.GetName().Version} has been unloaded!"); // Log warning unloading info with Unturned SDG
        }
    }
}
