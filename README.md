<h1 align="center">VendingMachine</h1>
<h3 align="center">A <a href=https://store.steampowered.com/app/700330/SCP_Secret_Laboratory/>SCP: Secret Laboratory</a> Vending Machine plugin for <a href=https://github.com/Exiled-Official/EXILED>EXILED</a>.</h3>

<div align="center">

This is my first [EXILED](https://github.com/Exiled-Official/EXILED) plugin, or C# project for that matter. It's a simple vending machine plugin, where you interact with a Pickup, with a coin in your hand, to receive a random item from a list in the config.

![Release](https://img.shields.io/github/v/tag/razormontana/VendingMachine?logo=github&label=Version)
![EXILEDVersion](https://img.shields.io/badge/EXILED_Version-8.9.7-crimson?logo=scpfoundation)
![Downloads](https://img.shields.io/github/downloads/razormontana/VendingMachine/total?logo=googleanalytics&logoColor=white&label=Downloads&color=green)

</div>

<h2>Features:</h1>

- The primary feature of the plugin is that when a pickup with the GameObject name "Vending" is searched, it will exchange the coin for a random item.
  
- Alternatively, one can use the Console (not RemoteAdmin!!!!) with the ```.vdg``` command and ```vdg.perm``` permission to perform the same action. You can set this up to let your VIPs use VendingMachine anywhere.
  
- The command can be used on other players as well with the ```vdg.targetothers``` permission.

VendingMachine is meant to be used with [MapEditorReborn](https://github.com/Michal78900/MapEditorReborn), but any Pickup object with the correct name should suffice.

<h2>Dependencies:</h1>

The plugin requires [EXILED](https://github.com/Exiled-Official/EXILED) to be installed on your server.

You will need <a href=https://github.com/Michal78900/MapEditorReborn>MapEditorReborn</a> to create your "Vending" Pickup. 

(<a href=https://github.com/Michal78900/MapEditorReborn>AMERT</a> InteractablePickups are not required and were not tested.)

<h2>Config:</h1>

All messages are fully customizable with the config file, and so is the item list.

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
