using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLInvisible_Installer
{
    internal class ScriptCreator
    {
        private string _Path;

        public ScriptCreator(string pPath)
        {
            _Path = pPath;
        }

        public void CreateBat()
        {
            using (StreamWriter writer = File.CreateText(_Path + "\\run.bat"))
            {
                writer.WriteLine("powershell -Command \"Start-Process powershell \\\"-ExecutionPolicy Bypass -NoProfile -Command `\\\"`%~dp0LoLOff.ps1\"`\\\"\\\" -Verb RunAs\"");
            }
        }

        public void CreatePowershellScript()
        {
            using (StreamWriter writer = File.CreateText(_Path + "\\LoLOff.ps1"))
            {
                writer.WriteLine("$firewallPort = \"5223\"");
                writer.WriteLine("$firewallRuleName = \"lolchat\"");
                writer.WriteLine("");
                writer.WriteLine("write-host \"Checking for '$firewallRuleName' firewall rule on port '$firewallPort' now....\"");
                writer.WriteLine("if ($(Get-NetFirewallRule -ErrorAction silentlycontinue -DisplayName $firewallRuleName | Get-NetFirewallPortFilter | Where { $_.Remoteport -eq $firewallPort }))");
                writer.WriteLine("{");
                writer.WriteLine("    write-host \"Firewall rule for '$firewallRuleName' on port '$firewallPort' already exists, deleting rule now...\"");
                writer.WriteLine("    netsh advfirewall firewall delete rule name=\"lolchat\"");
                writer.WriteLine("    write-host \"Firewall rule for '$firewallRuleName' on port '$firewallPort' deleted successfully\"");
                writer.WriteLine("}");
                writer.WriteLine("else");
                writer.WriteLine("{");
                writer.WriteLine("    write-host \"Firewall rule for '$firewallRuleName' on port '$firewallPort' does not already exist, creating new rule now...\"");
                writer.WriteLine("    netsh advfirewall firewall add rule name=\"lolchat\" dir=out remoteport=5223 protocol=TCP action=block");
                writer.WriteLine("    write-host \"Firewall rule for '$firewallRuleName' on port '$firewallPort' created successfully\"");
                writer.WriteLine("}");
                writer.WriteLine("");
                writer.WriteLine("Start-Sleep -Seconds 3");
                writer.WriteLine("stop-process -Id $PID");
            }
        }
    }
}
