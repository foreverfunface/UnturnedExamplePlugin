using Rocket.API;

namespace UnturnedExamplePlugin
{
    public class PluginConfiguration : IRocketPluginConfiguration
    {
        public string MessageColor { get; set; }
        public string LoadMessage { get; set; }
        public void LoadDefaults()
        {
            MessageColor = "green";
            LoadMessage = "Example Plugin is active!\nGet more plugins on https://vk.com/astis.unturned.store";
        }
    }
}
