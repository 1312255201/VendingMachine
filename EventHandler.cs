using Exiled.Events;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Features;
using System;

namespace VendingMachinePlugin
{
    internal sealed class EventHandler
    {
        Config config = new Config();
        public void EnableEvents()
        {
            Exiled.Events.Handlers.Player.SearchingPickup += Interacted;

        }
        public void DisableEvents()
        {
            Exiled.Events.Handlers.Player.SearchingPickup -= Interacted;
        }

        private void Interacted(SearchingPickupEventArgs ev)
        {
            Player player = ev.Player;
            if (ev.Pickup.GameObject.name.Equals("Vending"))
            {
                if (player.CurrentItem == null)
                {
                    
                    player.ShowHint(config.InteractionFailedMessage, 5f);
                }

                if (player.CurrentItem.Type == ItemType.Coin)
                {
                    player.RemoveItem(player.CurrentItem);
                    Random random = new Random();
                    ItemType randomItem = config.VendingMachineStock[random.Next(config.VendingMachineStock.Count)];
                    player.AddItem(randomItem);
                    player.ShowHint(config.InteractionSuccessfulMessage, 5f);
                }
                else
                {
                    player.ShowHint(config.InteractionFailedMessage, 5f);
                }
            }
        }
    }
}
