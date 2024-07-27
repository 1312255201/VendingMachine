using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace VendingMachinePlugin
{
    public class Configs : IConfig
    {
        [Description("Whether the plugin and it's modules are enabled or not.")]
        public bool IsEnabled { get; set; } = true;
        public bool EnableEffects { get; set; } = true;
        public bool EnableSizeChange { get; set; } = true;
        public bool EnableExplode { get; set; } = true;
        public bool EnableFlashbang { get; set; } = true;
        public bool EnableTantrum { get; set; } = true;

        [Description("Module chance weights: (They don't need to add up to 100.)")]
        public int ItemChance { get; set; } = 50;
        public int EffectChance { get; set; } = 30;
        public int SizeChangeChance { get; set; } = 5;
        public int ExplodeChance { get; set; } = 1;
        public int FlashbangChance { get; set; } = 5;
        public int TantrumChance { get; set; } = 9;

        [Description("Locatization settings (modify these messages to your liking).")]
        public string DescriptionConsole { get; set; } = "Checks if the player is holding a coin and gives a random item if so.";
        public string InteractionSuccessfulItems { get; set; } = "<b>The vending machine <color=#42f57b>dispensed something.</color></b>";
        public string InteractionSuccessfulEffects { get; set; } = "<b>The vending machine <color=#42f57b>shook violently.</color></b>";
        public string InteractionSuccessfulSize { get; set; } = "<b>The vending machine <color=#42f57b>gnomed you.</color></b>";
        public string InteractionSuccessfulExplode { get; set; } = "<b>The vending machine <color=#42f57b>exploded.</color></b>";
        public string InteractionSuccessfulFlashbang { get; set; } = "<b>The vending machine <color=#42f57b>dispensed a weird can.</color></b>";
        public string InteractionSuccessfulTantrum { get; set; } = "<b>You <color=#42f57b>shit yourself.</color></b>";
        public string InteractionFailedMessage { get; set; } = "<b>You aren't <color=red>holding a coin!</color></b>";
        public string InteractionFailedConsole { get; set; } = "The player is not holding a coin.";
        public string InteractionSuccessfulConsole { get; set; } = "Successful.";
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

        [Description("List of effects that the vending machine has in stock, and their durations:")]
        public int MinEffectDuration { get; set; } = 10;
        public int MaxEffectDuration { get; set; } = 25;
        public List<EffectType> VendingMachineEffects { get; set; } = new List<EffectType>
        {
            EffectType.Invigorated,
            EffectType.AntiScp207,
            EffectType.Scp207,
            EffectType.Asphyxiated,
            EffectType.Blinded,
            EffectType.Scp1853,
            EffectType.Hypothermia,
            EffectType.MovementBoost,
            EffectType.Invisible
        };

        [Description("Size change settings:")]
        public Vector3 GnomedSize { get; set; } = new Vector3(1.13f, 0.5f, 1.13f);

    }
}