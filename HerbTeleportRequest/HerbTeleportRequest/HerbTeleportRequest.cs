
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

using MiNET.Plugins;
using MiNET.Plugins.Attributes;

using HerbTeleportRequest.Command;

namespace HerbTeleportRequest
{

    [Plugin]
    public class HerbTeleportRequest : Plugin
    {

        public const string Prefix = "";

        protected override void OnEnable()
        {
            Console.WriteLine();

            RegisterCommands();
        }

        private void RegisterCommands()
        {
            var PluginManager = Context.Server.PluginManager;

            Context.PluginManager.LoadCommands(new TPA(PluginManager));
            Context.PluginManager.LoadCommands(new Tpaccept(PluginManager));
            Context.PluginManager.LoadCommands(new Tpdeny(PluginManager));
            Context.PluginManager.LoadCommands(new Tphere(PluginManager));
        }
    }
}
