
/*
    ooooo   ooooo                     .o8        .ooooo.   
    `888'   `888'                    "888       888' `Y88. 
     888     888   .ooooo.  oooo d8b  888oooo.  888    888 
     888ooooo888  d88' `88b `888""8P  d88' `88b  `Vbood888 
     888     888  888ooo888  888      888   888       888' 
     888     888  888    .o  888      888   888     .88P'  
    o888o   o888o `Y8bod8P' d888b     `Y8bod8P'   .oP'     

    Directed by Herb9.
*/

using System;

using System.Collections.Generic;

using MiNET;

using MiNET.Utils;

using MiNET.Worlds;

namespace HerbTeleportRequest
{

    public class HerbTeleportRequest
    {

        public const string Prefix = "\x5b\x48\x65\x72\x62\x54\x65\x6c\x65\x70\x6f\x72\x74\x52\x65\x71\x75\x65\x73\x74\x5d";

        private Dictionary<string, string> RequestList = new Dictionary<string, string>();

        public HerbTeleportRequest()
        {

        }

        public void MakeRequest(Player requester, Player target)
        {
            RequestList.Add(target.Username, requester.Username);
        }

        public void RemoveRequest(Player player)
        {
            RequestList.Remove(player.Username);
        }

        public void ReceiveRequest(Player player, bool type)
        {
            string target = null;

            RequestList.TryGetValue(player.Username, out target);

            if (GetNameByPlayer(target) != null)
            {
                type ? TeleportPlayer(player, GetPlayer(target)) : TeleportPlayer(GetPlayer(target), player);
            }
        }

        public void DenyRequest(Player target)
        {

        }

        public void TeleportPlayer(Player player, Player target)
        {
            player.Teleport(new PlayerLocation() { X = target.KnownPosition.X, Y = target.KnownPosition.Y, Z = target.KnownPosition.Z, HeadYaw = target.KnownPosition.HeadYaw, Yaw = target.KnownPosition.Yaw, Pitch = target.KnownPosition.Pitch });
        }

        public Player GetNameByPlayer(string var, Level level)
        {
            foreach(var player in level.Players)
            {
                if (player.Value.Username.Contains(var))
                {
                    return player.Value;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
