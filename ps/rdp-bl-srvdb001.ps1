. C:\Service\scripts\adminlauncher\rdpfunction.ps1

### Set Credentials ###

$User = "UABLSRVDB001\Administrator"
$PWord = ConvertTo-SecureString -String "Start123" -AsPlainText -Force
$C = New-Object -TypeName "System.Management.Automation.PSCredential" -ArgumentList $User, $PWord

Connect-Mstsc -ComputerName UABLSRVDB001 -Credential $C