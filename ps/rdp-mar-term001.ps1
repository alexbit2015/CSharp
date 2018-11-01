. C:\Service\scripts\adminlauncher\rdpfunction.ps1


### Set Credentials ###

$User = "uamarterm001\Administrator"
$PWord = ConvertTo-SecureString -String "StartMarTerm001" -AsPlainText -Force
$C = New-Object -TypeName "System.Management.Automation.PSCredential" -ArgumentList $User, $PWord

### Connect to Mar DB Server ###

Connect-Mstsc -ComputerName UAMARTERM001 -Credential $C