
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

using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;

namespace HerbTeleportRequest.Command
{

    public class TPA
    {

        private string Prefix;

        public TPA(PluginManager pluginmanager)
        {
            Prefix = HerbTeleportRequest.Prefix;
        }

        [Command(
            Name = "tpa",
            Description = "Request to be teleported to a user"
            )]
        public void execute(Player requester, string var)
        {
            if(! new HerbTeleportRequest().CanReceive(var, requester.Level))
            {
                requester.SendMessage($"{Prefix} {var} is not a valid player.");
            }
            else if()
        }
    }
}
