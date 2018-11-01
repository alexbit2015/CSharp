. C:\Service\scripts\adminlauncher\rdpfunction.ps1

### Set Credentials ###

$User = "UAKHEHPV002\Administrator"
$PWord = ConvertTo-SecureString -String "2018StartKheHpv002" -AsPlainText -Force
$C = New-Object -TypeName "System.Management.Automation.PSCredential" -ArgumentList $User, $PWord

### Connect to Kiev DB Server ###

Connect-Mstsc -ComputerName UAKHEHPV002 -Credential $C