using System;
using System.Windows.Forms;
using UoFiddler.Plugin.UopPacker;
using UoFiddler.Controls.Plugin;
using UoFiddler.Controls.Plugin.Interfaces;
using Ultima;
using UoFiddler.Plugin.UoMarsManagementTool.UserControls;

namespace UoFiddler.Plugin.UoMarsManagementTool
{
    public class UoMarsManager : PluginBase
    {
        private readonly Version _ver;

        public UoMarsManager()
        {
            _ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        }

        /// <summary>
        /// Name of the plugin
        /// </summary>
        public override string Name { get; } = "Uo Mars Manager Tool";

        /// <summary>
        /// Description of the Plugin's purpose
        /// </summary>
        public override string Description { get; } = "File conversion: from centred " +
            "to UoMarsClient Patcher Folder, to ServUo File Folder and start pyFileHasher for versioning." +
            "At the end, serverNode.js will be started";


        /// <summary>
        /// Author of the plugin
        /// </summary>
        public override string Author { get; } = "Hurricane";

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
                Text = "UoMars Manager Tool"
            };
            // da implementare la form
            page.Controls.Add(new UoMarsManagerControl()); 
            tabControl.TabPages.Add(page);
        }
    }
}
