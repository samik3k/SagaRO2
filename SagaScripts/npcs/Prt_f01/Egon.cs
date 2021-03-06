using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Egon : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1158;
            Name = "Egon";
            StartX = 16700F;
            StartY = 87833F;
            StartZ = 5440;
            Startyaw = 49368;
            SetScript(3);
            AddButton(Functions.EverydayConversation, new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
        }

    }
}