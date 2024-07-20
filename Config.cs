using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace VendingMachinePlugin
{
    public class Config : IConfig
    {
        [Description("Whether the plugin is enabled or not.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Locatization settings (modify these messages to your liking).")]
        public string DescriptionConsole { get; set; } = "Checks if the player is holding a coin and gives a random item if so.";
        public string InteractionSuccessfulMessage { get; set; } = "<b>The vending machine <color=#42f57b>dispensed something.</color></b>";
        public string InteractionFailedMessage { get; set; } = "<b>You aren't <color=red>holding a coin!</color></b>";
        public string InteractionFailedConsole { get; set; } = "Item was not granted. The player was not holding a coin.";
        public string InteractionSuccessfulConsole { get; set; } = "Successfully granted a random item.";
        public string NoPermissionConsole { get; set; } = "You do not have permission to execute this command.";
        public string NoOthersPermissionConsole { get; set; } = "You can only use this command on yourself with your current permissions.";
        public string NoPlayer { get; set; } = "Player not found.";

        [Description("Debug.")]
        public bool Debug { get; set; } = false;

        [Description("List of items that the vending machine has in stock:")]
        public List<ItemType> VendingMachineStock { get; set; } = new List<ItemType>
        {
            ItemType.KeycardChaosInsurgency,
            ItemType.KeycardContainmentEngineer,
            ItemType.KeycardFacilityManager,
            ItemType.GunA7,
            ItemType.GunFSP9,
            ItemType.GunLogicer,
            ItemType.GunE11SR,
            ItemType.GunRevolver,
            ItemType.GunCrossvec,
            ItemType.GunCom45,
            ItemType.Jailbird,
            ItemType.ParticleDisruptor,
            ItemType.SCP018,
            ItemType.SCP207,
            ItemType.AntiSCP207,
            ItemType.KeycardJanitor,
            ItemType.KeycardScientist,
            ItemType.KeycardZoneManager,
            ItemType.KeycardGuard,
            ItemType.MicroHID,
            ItemType.SCP500,
            ItemType.SCP268,
            ItemType.SCP1853,
        };
    }
}