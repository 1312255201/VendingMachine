# VendingMachine
A SCP:SL Vending Machine plugin for EXILED.

This is my first EXILED plugin, or C# project for that matter.
It's a simple vending machine plugin, where you interact with a Pickup, with a coin in your hand, to receive a random item from a list in the config.

### This plugin can be interacted with in two ways:

- The primary feature of the plugin is that when a pickup with the GameObject name "Vending" is searched, it will exchange the coin for a random item.
  
- Alternatively, one can use the Console (not RemoteAdmin!!!!) with the ```.vdg``` command and ```vdg.perm``` permission to perform the same action. You can set this up to let your VIPs use VendingMachine anywhere.
  
- The command can be used on other players as well with the ```vdg.targetothers``` permission.

All messages are fully customizable with the config file and so is the item list.

### You will need MapEditorReborn to create your "Vending" Pickup! (AMERT is not required.)
