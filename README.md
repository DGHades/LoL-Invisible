# LoL-Invisible
A Script for appearing Offline in League of Legends while actually being online and able to play.

# *Important:* Please Read the Note at the bottom, as this defines what "appear as Offline" means.

# How to Install:

1. Get the Installer Files from the "InstallerFiles" Folder. Note: You can take the .rar or the Actual Folder, both are the same.

2. Execute "LoLInvisible-Installer.exe"

3. Set the Options how you like it and press install.

4. Here you go now you should have the needed Scripts in your installation path, and if you checked the box for it, also a Desktop Shortcut.


# How to use:

## Appear as Offline:
If you have the Desktop shortcut, you can just double click it, it will ask for Admin Privileges (it won't work without) and then opens up a PowerShell window telling you what it is doing right now.
It will close automatically and you should see that in your LoL-Client your Friendlist will not show anymore.

If you dont have the Desktop Shortcut, then just go to the Installation Directory and Double Click the "run.bat" this will then do the same thing as mentioned in the version with a Desktop Shortcut.

## Appear as Online again:
Just do the same thing as when you want to appear offline, the Script will find the Firewall Rule and will delete it so you can normally be Online again.

# **Note:**
When you "Appear as Offline", you will be not shown as Online to friends, but you also won't be able to connect to the Chat in the Champ-Select, in your friends list, and in the after match Lobby-Chat.
Mind this if you are willing to play blind pick, it can be problematic. 

# Troubleshooting:
If the script for some reason won't disable the rule again, open cmd (write cmd in windows search bar) and execute the command "wf.msc".
From here navigate to "Outgoing Rules" (on the left) and find the Rule "LoLChat", then go ahead and delete that rule.

