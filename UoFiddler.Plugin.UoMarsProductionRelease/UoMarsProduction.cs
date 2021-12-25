// /***************************************************************************
//  *
//  * $Author: Lion
//  *
//  ***************************************************************************/

using System;
using System.Windows.Forms;
using UoFiddler.Controls.Plugin;
using UoFiddler.Controls.Plugin.Interfaces;
using Ultima;
using UoFiddler.Plugin.UoMarsProductionRelease.UserControls;

namespace UoFiddler.Plugin.UoMarsProductionRelease
{
    public class UoMarsProduction : PluginBase
    {
        private readonly Version _ver;

        public UoMarsProduction()
        {
            _ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        }

        /// <summary>
        /// Name of the plugin
        /// </summary>
        public override string Name { get; } = "Uo Mars Production Release";

        /// <summary>
        /// Description of the Plugin's purpose
        /// </summary>
        public override string Description { get; } = "Release files to production server";


        /// <summary>
        /// Author of the plugin
        /// </summary>
        public override string Author { get; } = "Lion";

        /// <summary>
        /// Version of the plugin
        /// </summary>
        public override string Version { get { return _ver.ToString(); } }

        /// <summary>
        /// Host of the plugin.
        /// </summary>
        public override IPluginHost Host { get; set; }

        public override void Initialize()
        {
            _ = Files.RootDir;
        }

        public override void Unload()
        {
        }

        public override void ModifyTabPages(TabControl tabControl)
        {
            TabPage page = new TabPage
            {
                Tag = 0, // at end used for undock/dock feature to define the order
                Text = "UoMars Prod release"
            };
            // da implementare la form
            page.Controls.Add(new UoMarsProductionControl()); 
            tabControl.TabPages.Add(page);
        }
    }
}
