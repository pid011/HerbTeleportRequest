﻿
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

using MiNET.Plugins;
using MiNET.Plugins.Attributes;

using HerbTeleportRequest.Command;

namespace HerbTeleportRequest
{

    [Plugin(
        PluginName = "HerbTeleportRequest",
        Description = "Allows regular users to teleport to and summon based on an acceptance of the other user.",
        PluginVersion = "1.0",
        Author = "Herb9"
        )]
    public class PluginLoader : Plugin
    {

        private string Prefix;

        protected override void OnEnable()
        {
            Prefix = HerbTeleportRequest.Prefix;

            CheckUpdate();

            RegisterCommands();
        }

        private void CheckUpdate()
        {

        }

        private void RegisterCommands()
        {
            Context.PluginManager.LoadCommands(new TPA(Context.Server.PluginManager));
            Context.PluginManager.LoadCommands(new Tpaccept(Context.Server.PluginManager));
            Context.PluginManager.LoadCommands(new Tpdeny(Context.Server.PluginManager));
            Context.PluginManager.LoadCommands(new Tphere(Context.Server.PluginManager));
        }
    }
}
