. C:\Service\scripts\adminlauncher\rdpfunction.ps1

### Set Credentials ###

$User = "UABLHPV002\Administrator"
$PWord = ConvertTo-SecureString -String "StartBlHpv002" -AsPlainText -Force
$C = New-Object -TypeName "System.Management.Automation.PSCredential" -ArgumentList $User, $PWord

Connect-Mstsc -ComputerName UABLHPV002 -Credential $C