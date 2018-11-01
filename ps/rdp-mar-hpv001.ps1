. C:\Service\scripts\adminlauncher\rdpfunction.ps1

### Set Credentials ###

$User = "uamarhpv001\Administrator"
$PWord = ConvertTo-SecureString -String "StartMarHpv001" -AsPlainText -Force
$C = New-Object -TypeName "System.Management.Automation.PSCredential" -ArgumentList $User, $PWord

### Connect to Mar DB Server ###

Connect-Mstsc -ComputerName UAMARHPV001 -Credential $C