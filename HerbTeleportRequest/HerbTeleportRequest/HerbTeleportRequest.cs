
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

using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;
using MiNET.Worlds;

namespace HerbTeleportRequest
{

    public class HerbTeleportRequest
    {

        public const string Prefix = "\x5b\x48\x65\x72\x62\x54\x65\x6c\x65\x70\x6f\x72\x74\x52\x65\x71\x75\x65\x73\x74\x5d";

        public string[] RequestList { get; set; }

        public void MadeRequest(Player requester, Player target)
        {
            
        }

        public void RemoveRequest(Player requester, Player target)
        {

        }

        public void ReceiveRequest(Player requester, string type = null)
        {

        }

        public void TeleportTarget(Player requester)
        {

        }

        public void TeleportHere(Player requester)
        {

        }

        public bool CanReceive(string var, Level level)
        {
            foreach(var player in level.Players)
            {
                if (player.Value.Username.Contains(var))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
