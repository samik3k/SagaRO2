using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f02
{
    public class Nernst : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f02";
            Type = 1164;
            Name = "Nernst";
            StartX = 22236F;
            StartY = -32352F;
            StartZ = -4064;
            Startyaw = 0;
            SetScript(3);
            AddButton(Functions.EverydayConversation, new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
        }

    }
}