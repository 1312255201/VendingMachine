using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using System;

namespace VendingMachinePlugin
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class Commands : ICommand
    {
        public bool SanitizeResponse => false;
        public string Command => "vdg";
        public string[] Aliases => new string[] { };
        Config config = new Config();
        public string Description => config.DescriptionConsole;

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("vdg.perm"))
            {
                response = config.NoPermissionConsole;
                return false;
            }

            if (arguments.Count == 0)
            {
                Player player = Player.Get(sender);
                return Execute(player, out response);
            }

            string playerName = arguments.At(0);
            Player targetPlayer = Player.Get(playerName);

            if (targetPlayer == null)
            {
                response = config.NoPlayer;
                return false;
            }

            if (sender.CheckPermission("vdg.targetothers"))
                return Execute(targetPlayer, out response);
            else
            {
                response = config.NoOthersPermissionConsole;
                return false;
            }
        }

        public bool Execute(Player player, out string response)
        {
            if (player.CurrentItem == null)
            {
                player.ShowHint(config.InteractionFailedMessage, 5f);
                response = config.InteractionFailedConsole;
                return false;
            }

            if (player.CurrentItem.Type == ItemType.Coin)
            {
                player.RemoveItem(player.CurrentItem);
                Random random = new Random();
                ItemType randomItem = config.VendingMachineStock[random.Next(config.VendingMachineStock.Count)];
                player.AddItem(randomItem);
                player.ShowHint(config.InteractionSuccessfulMessage, 5f);
                response = config.InteractionSuccessfulConsole;
                return true;
            }
            else
            {
                player.ShowHint(config.InteractionFailedMessage, 5f);
                response = config.InteractionFailedConsole;
                return false;
            }
        }
    }
}