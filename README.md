<h1 align="center">VendingMachine</h1>
<h3 align="center">A <a href=https://store.steampowered.com/app/700330/SCP_Secret_Laboratory/>SCP: Secret Laboratory</a> Vending Machine plugin for <a href=https://github.com/Exiled-Official/EXILED>EXILED</a>.</h3>

<div align="center">

This is my first [EXILED](https://github.com/Exiled-Official/EXILED) plugin, or C# project for that matter. It's a simple vending machine plugin, where you interact with a Pickup, with a coin in your hand, to receive a random item from a list in the config.

![Release](https://img.shields.io/github/v/tag/razormontana/VendingMachine?logo=github&label=Version)
![EXILEDVersion](https://img.shields.io/badge/EXILED_Version-8.11.0-crimson?logo=scpfoundation)
![Downloads](https://img.shields.io/github/downloads/razormontana/VendingMachine/total?logo=googleanalytics&logoColor=white&label=Downloads&color=green)

</div>

<h2>Features:</h1>

- The primary feature of the plugin is that when a pickup with the GameObject name "Vending" is searched, it will exchange the coin for a random item, effect, make the player a dwarf, throw a flashbang at them, outright explode them, or make them throw the 173 Tantrum.
  
- Alternatively, one can use the Console (not RemoteAdmin!!!!) with the ```.vdg``` command and ```vdg.perm``` permission to perform the same action. You can set this up to let your VIPs use VendingMachine anywhere.
  
- The command can be used on other players as well with the ```vdg.targetothers``` permission.

> [!NOTE]
> VendingMachine is meant to be used with [MapEditorReborn](https://github.com/Michal78900/MapEditorReborn), but any Pickup object with the correct name should suffice.

<h2>Dependencies:</h1>

The plugin requires [EXILED](https://github.com/Exiled-Official/EXILED) to be installed on your server.

You will need <a href=https://github.com/Michal78900/MapEditorReborn>MapEditorReborn</a> to create your "Vending" Pickup. 

> [!NOTE]
> (<a href=https://github.com/Michal78900/MapEditorReborn>AMERT</a> InteractablePickups are not required and were not tested.)

<h2>Config:</h1>

All messages are fully customizable with the config file, and so is the item and effect list.
Chance weights don't need to add up to 100. If an event is disabled, it's chance will default to dispensing an item instead.

```Yaml
# Whether the plugin and it's modules are enabled or not.
is_enabled: true
enable_effects: true
enable_size_change: true
enable_explode: true
enable_flashbang: true
enable_tantrum: true
# Module chance weights:
item_chance: 50
effect_chance: 30
size_change_chance: 5
explode_chance: 1
flashbang_chance: 5
tantrum_chance: 9
# Locatization settings (modify these messages to your liking).
description_console: 'Checks if the player is holding a coin and gives a random item if so.'
interaction_successful_items: '<b>The vending machine <color=#42f57b>dispensed something.</color></b>'
interaction_successful_effects: '<b>The vending machine <color=#42f57b>shook violently.</color></b>'
interaction_successful_size: '<b>The vending machine <color=#42f57b>gnomed you.</color></b>'
interaction_successful_explode: '<b>The vending machine <color=#42f57b>exploded.</color></b>'
interaction_successful_flashbang: '<b>The vending machine <color=#42f57b>dispensed a weird can.</color></b>'
interaction_successful_tantrum: '<b>You <color=#42f57b>shit yourself.</color></b>'
interaction_failed_message: '<b>You aren''t <color=red>holding a coin!</color></b>'
interaction_failed_console: 'The player is not holding a coin.'
interaction_successful_console: 'Successful.'
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
# List of effects that the vending machine has in stock, and their durations:
min_effect_duration: 10
max_effect_duration: 25
vending_machine_effects:
- Invigorated
- AntiScp207
- Scp207
- Asphyxiated
- Blinded
- Scp1853
- Hypothermia
- MovementBoost
- Invisible
# Size change settings:
gnomed_size:
  x: 1.13
  y: 0.5
  z: 1.13
```
