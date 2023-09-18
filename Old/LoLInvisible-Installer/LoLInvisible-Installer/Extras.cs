using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLInvisible_Installer
{
    internal class Extras
    {
        private string _Path;
        public Extras(string pPath, bool pAddDesktopShortcut)
        {
            _Path = pPath;

            if (pAddDesktopShortcut)
            {
                AddDesktopShortcut();
            }
        }

        private void AddDesktopShortcut()
        {
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\LoL_Invisible.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "Shortcut to the LoL-Invisible Script.";
            shortcut.Hotkey = "Ctrl+Shift+O";
            shortcut.TargetPath = _Path + @"\run.bat";
            shortcut.Save();
        }
    }
}
