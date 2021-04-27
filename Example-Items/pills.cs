using System;
using Exiled.API.Features;
using Exiled.CustomItems;
using Exiled.CustomItems.API;
using Exiled.CustomItems.API.Components;
using Exiled.CustomItems.API.EventArgs;
using Exiled.CustomItems.API.Features;
using Exiled.CustomItems.API.Spawn;
using Exiled.Events.EventArgs;
using System.Collections.Generic;
using CustomItems;
using Player = Exiled.Events.Handlers.Player;

namespace CustomPlugin
{
    public class Pills : CustomItem
    {
        public override ItemType Type { get; set; } = ItemType.Painkillers;
        //Custom Item Id
        public override uint Id { get; set; } = 18;

        //Name of Item
        public override string Name { get; set; } = "Medicaide";

        //What Cassie Should Say When Used
        public string BroadcastMessage { get; set; } = "I am Cool";


        //Description
        public override string Description { get; set; } = "These pills utilize the power of medicaide to talk with cassie.";

        //Spawn Locations
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties
        {
            Limit = 1,
            DynamicSpawnPoints = new List<DynamicSpawnPoint>
            {
                new DynamicSpawnPoint
                {
                    Chance = 100,
                    Location = SpawnLocation.Inside012Locker,
                },
                new DynamicSpawnPoint
                {
                    Chance = 50,
                    Location = SpawnLocation.Inside173Armory,
                },
            },
        };
        protected override void SubscribeEvents()
        {
            Player.UsingMedicalItem += OnUsingMedicalItem;
            base.SubscribeEvents();
        }

        protected override void UnsubscribeEvents()
        {
            Player.UsingMedicalItem -= OnUsingMedicalItem;
            base.UnsubscribeEvents();
        }

        public void OnUsingMedicalItem(UsingMedicalItemEventArgs ev)
        {
            if (!Check(ev.Player.CurrentItem) || ev.Item != ItemType.Medkit)
                return;
            Exiled.API.Features.Cassie.Message(BroadcastMessage, false, true);
        }
        
        protected override void OnPickingUp(PickingUpItemEventArgs ev)
        {
            
            base.OnPickingUp(ev);
        }

        protected override void OnDropping(DroppingItemEventArgs ev)
        {
            base.OnDropping(ev);
        }
    }
}
