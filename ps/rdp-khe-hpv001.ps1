. C:\Service\scripts\adminlauncher\rdpfunction.ps1

### Set Credentials ###

$User = "UAKHEHPV001\Administrator"
$PWord = ConvertTo-SecureString -String "2018StartKheHpv001" -AsPlainText -Force
$C = New-Object -TypeName "System.Management.Automation.PSCredential" -ArgumentList $User, $PWord

### Connect to Kiev DB Server ###

Connect-Mstsc -ComputerName UAKHEHPV001 -Credential $C