using Rocket.API;
using Rocket.Unturned.Chat;
using System;
using System.Collections.Generic;

namespace UnturnedExamplePlugin.Commands
{
    public class ExampleCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "example";

        public string Help => "Use /example for get example message";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedChat.Say(caller, $"[{DateTime.Now}] {Plugin.Instance.Random.Next(10000)}"); // Say player message with Rocket
        }
    }
}
