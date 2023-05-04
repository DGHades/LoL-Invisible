using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLInvisible_Installer
{
    internal class Validator
    {
        private List<string> _Errors = new List<string>();
        private string _Path;

        public bool ValidateData(ref string pErrorText, string pPath)
        {
            _Path = pPath;

            _Errors.Clear();
            PathExists();
            FilesAlreadyExist();
            if (_Errors.Count > 0 ) 
            {
                pErrorText = "Error:";
                foreach ( string error in _Errors )
                {
                    pErrorText += "\n" + error;
                }
                return false;
            }
            return true;
        }

        private void PathExists()
        {
            if (!Directory.Exists(_Path))
            {
                _Errors.Add("Path does not Exist!");
            }
        }

        private void FilesAlreadyExist()
        {
            if (File.Exists(_Path + "\\run.bat") || File.Exists(_Path + "\\LoLOff.ps1"))
            {
                _Errors.Add("Files already Installed in this Path!");
            }
        }
    }
}
