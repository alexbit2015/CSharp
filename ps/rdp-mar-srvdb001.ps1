. C:\Service\scripts\adminlauncher\rdpfunction.ps1

### Set Credentials ###

$User = "uamarsrvdb001\Administrator"
$PWord = ConvertTo-SecureString -String "StartMarSrvdb001" -AsPlainText -Force
$C = New-Object -TypeName "System.Management.Automation.PSCredential" -ArgumentList $User, $PWord

### Connect to Mar DB Server ###

Connect-Mstsc -ComputerName UAMARSRVDB001 -Credential $C