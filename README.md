<h1 align="center"> VendingMachine</h1>
<h3 align="center">A SCP:SL Vending Machine plugin for EXILED.</h3>

<div align="center">

This is my first EXILED plugin, or C# project for that matter. It's a simple vending machine plugin, where you interact with a Pickup, with a coin in your hand, to receive a random item from a list in the config.

[![Version](https://img.shields.io/github/v/release/Jesus-QC/ScpProximityChat?sort=semver&style=flat-square&color=8DBBE9&label=Version)]()

</div>

### This plugin can be interacted with in two ways:

- The primary feature of the plugin is that when a pickup with the GameObject name "Vending" is searched, it will exchange the coin for a random item.
  
- Alternatively, one can use the Console (not RemoteAdmin!!!!) with the ```.vdg``` command and ```vdg.perm``` permission to perform the same action. You can set this up to let your VIPs use VendingMachine anywhere.
  
- The command can be used on other players as well with the ```vdg.targetothers``` permission.

All messages are fully customizable with the config file and so is the item list. This is what the default ```config.yaml``` looks like:

```Yaml
# Whether the plugin is enabled or not.
is_enabled: true
# Locatization settings (modify these messages to your liking).
description_console: 'Checks if the player is holding a coin and gives a random item if so.'
interaction_successful_message: '<b>The vending machine <color=#42f57b>dispensed something.</color></b>'
interaction_failed_message: '<b>You aren''t <color=red>holding a coin!</color></b>'
interaction_failed_console: 'Item was not granted. The player was not holding a coin.'
interaction_successful_console: 'Successfully granted a random item.'
no_permission_console: 'You do not have permission to execute this command.'
no_others_permission_console: 'You can only use this command on yourself with your current permissions.'
no_player: 'Player not found.'
# Debug.
debug: false
# List of items that the vending machine has in stock:
vending_machine_stock:
- KeycardChaosInsurgency
- KeycardContainmentEngineer
- KeycardFacilityManager
- GunA7
- GunFSP9
- GunLogicer
- GunE11SR
- GunRevolver
- GunCrossvec
- GunCom45
- Jailbird
- ParticleDisruptor
- SCP018
- SCP207
- AntiSCP207
- KeycardJanitor
- KeycardScientist
- KeycardZoneManager
- KeycardGuard
- MicroHID
- SCP500
- SCP268
- SCP1853
```


### You will need MapEditorReborn to create your "Vending" Pickup! (AMERT is not required.)
