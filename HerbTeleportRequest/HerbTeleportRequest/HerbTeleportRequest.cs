
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

using MiNET.Utils;

using HerbTeleportRequest.Command;

namespace HerbTeleportRequest
{

    class HerbTeleportRequest
    {

        public string prefix { get; set; }

        public HerbTeleportRequest()
        {
            prefix = "\x5b\x48\x65\x72\x62\x54\x65\x6c\x65\x70\x6f\x72\x74\x52\x65\x71\x75\x65\x73\x74\x5d";
        }

        public bool IsRequested(Player player)
        {
            return true;
        }

        public void TeleportPlayer(Player player, Player target)
        {

        }

        public void TeleportHere(Player player, Player target)
        {

        }

        public void DenyPlayer(Player player, Player target)
        {

        }

        public void RequestPlayer(Player player, Player target)
        {

        }
    }
}
