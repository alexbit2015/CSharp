. C:\Service\scripts\adminlauncher\rdpfunction.ps1

### Set Credentials ###

$User = "uamarwww001\Administrator"
$PWord = ConvertTo-SecureString -String "6851822Qq" -AsPlainText -Force
$C = New-Object -TypeName "System.Management.Automation.PSCredential" -ArgumentList $User, $PWord

### Connect to Mar DB Server ###

Connect-Mstsc -ComputerName UAMARWWW001 -Credential $C