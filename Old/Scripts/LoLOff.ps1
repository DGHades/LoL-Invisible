$firewallPort = "5223"
$firewallRuleName = "lolchat"

write-host "Checking for '$firewallRuleName' firewall rule on port '$firewallPort' now...."
if ($(Get-NetFirewallRule -ErrorAction silentlycontinue -DisplayName $firewallRuleName | Get-NetFirewallPortFilter | Where { $_.Remoteport -eq $firewallPort })) 
{
    write-host "Firewall rule for '$firewallRuleName' on port '$firewallPort' already exists, deleting rule now..."
    netsh advfirewall firewall delete rule name="lolchat"
    write-host "Firewall rule for '$firewallRuleName' on port '$firewallPort' deleted successfully"
}
else
{
    write-host "Firewall rule for '$firewallRuleName' on port '$firewallPort' does not already exist, creating new rule now..."
    netsh advfirewall firewall add rule name="lolchat" dir=out remoteport=5223 protocol=TCP action=block
    write-host "Firewall rule for '$firewallRuleName' on port '$firewallPort' created successfully"
}

Start-Sleep -Seconds 3
stop-process -Id $PID