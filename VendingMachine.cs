using System;
using Exiled.API.Features;

namespace VendingMachinePlugin
{
    class VendingMachine : Plugin<Config>
    {
        public override string Author => "Razortosh";
        public override string Name => "Vending Machine";
        public override string Prefix => "VendingMachine";
        public override Version Version => new Version(1, 0, 0, 1);
        public static VendingMachine Singleton;
        private EventHandler Hdlr;
        public override void OnEnabled()
        {
            Singleton = this;
            Hdlr = new EventHandler();
            Hdlr.EnableEvents();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Singleton = null;
            Hdlr.DisableEvents();
            Hdlr = null;
            base.OnDisabled();
        }
    }
}