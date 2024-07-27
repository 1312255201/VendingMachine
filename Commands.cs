using CommandSystem;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
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
        Configs Config => VendingMachine.Singleton.Config;

        public string Description => Config.DescriptionConsole;

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("vdg.perm"))
            {
                response = Config.NoPermissionConsole;
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
                response = Config.NoPlayer;
                return false;
            }

            if (sender.CheckPermission("vdg.targetothers"))
                return Execute(targetPlayer, out response);
            else
            {
                response = Config.NoOthersPermissionConsole;
                return false;
            }
        }

        public bool Execute(Player player, out string response)
        {
            if (player.CurrentItem == null)
            {
                player.ShowHint(Config.InteractionFailedMessage, 5f);
                response = Config.InteractionFailedConsole;
                return false;
            }

            if (player.CurrentItem.Type == ItemType.Coin)
            {
                player.RemoveItem(player.CurrentItem);
                var weightedChances = new WeightedChanceExecutor(
                    new WeightedChanceParam(() =>
                    {
                        System.Random random = new System.Random();
                        ItemType randomItem = Config.VendingMachineStock[random.Next(Config.VendingMachineStock.Count)];
                        player.AddItem(randomItem);
                        player.ShowHint(Config.InteractionSuccessfulItems, 5f);
                    }, Config.ItemChance),
                    new WeightedChanceParam(() =>
                    {
                        if (Config.EnableEffects == true)
                        {
                            System.Random random = new System.Random();
                            EffectType randomEffect = Config.VendingMachineEffects[random.Next(Config.VendingMachineEffects.Count)];
                            player.EnableEffect(randomEffect, random.Next(Config.MinEffectDuration, Config.MaxEffectDuration));
                            player.ShowHint(Config.InteractionSuccessfulEffects, 5f);
                        }
                        else
                        {
                            System.Random random = new System.Random();
                            ItemType randomItem = Config.VendingMachineStock[random.Next(Config.VendingMachineStock.Count)];
                            player.AddItem(randomItem);
                            player.ShowHint(Config.InteractionSuccessfulItems, 5f);
                        }
                    }, Config.EffectChance),
                    new WeightedChanceParam(() =>
                    {
                        if (Config.EnableSizeChange == true)
                        {
                            player.Scale = Config.GnomedSize;
                            player.ShowHint(Config.InteractionSuccessfulSize, 5f);
                        }
                        else
                        {
                            System.Random random = new System.Random();
                            ItemType randomItem = Config.VendingMachineStock[random.Next(Config.VendingMachineStock.Count)];
                            player.AddItem(randomItem);
                            player.ShowHint(Config.InteractionSuccessfulItems, 5f);
                        }
                    }, Config.SizeChangeChance),
                    new WeightedChanceParam(() =>
                    {
                        if (Config.EnableExplode == true)
                        {
                            player.Explode();
                            player.ShowHint(Config.InteractionSuccessfulExplode, 5f);
                        }
                        else
                        {
                            System.Random random = new System.Random();
                            ItemType randomItem = Config.VendingMachineStock[random.Next(Config.VendingMachineStock.Count)];
                            player.AddItem(randomItem);
                            player.ShowHint(Config.InteractionSuccessfulItems, 5f);
                        }
                    }, Config.ExplodeChance),
                    new WeightedChanceParam(() =>
                    {
                        if (Config.EnableFlashbang == true)
                        {
                            FlashGrenade flash = (FlashGrenade)Item.Create(ItemType.GrenadeFlash, player);
                            flash.FuseTime = 1f;
                            flash.SpawnActive(player.Position);
                            player.ShowHint(Config.InteractionSuccessfulFlashbang, 5f);
                        }
                        else
                        {
                            System.Random random = new System.Random();
                            ItemType randomItem = Config.VendingMachineStock[random.Next(Config.VendingMachineStock.Count)];
                            player.AddItem(randomItem);
                            player.ShowHint(Config.InteractionSuccessfulItems, 5f);
                        }
                    }, Config.FlashbangChance),
                     new WeightedChanceParam(() =>
                     {
                         if (Config.EnableTantrum == true)
                         {
                             player.PlaceTantrum();
                             player.ShowHint(Config.InteractionSuccessfulTantrum, 5f);
                         }
                         else
                         {
                             System.Random random = new System.Random();
                             ItemType randomItem = Config.VendingMachineStock[random.Next(Config.VendingMachineStock.Count)];
                             player.AddItem(randomItem);
                             player.ShowHint(Config.InteractionSuccessfulItems, 5f);
                         }
                     }, Config.TantrumChance)
             );
                weightedChances.Execute();
                response = Config.InteractionSuccessfulConsole;
                return true;
            }
            else
            {
                player.ShowHint(Config.InteractionFailedMessage, 5f);
                response = Config.InteractionFailedConsole;
                return false;
            }
        }

    }
}