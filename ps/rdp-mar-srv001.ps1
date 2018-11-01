. C:\Service\scripts\adminlauncher\rdpfunction.ps1

### Set Credentials ###

$User = "uamarsrv001\Administrator"
$PWord = ConvertTo-SecureString -String "StartMarSrv001" -AsPlainText -Force
$C = New-Object -TypeName "System.Management.Automation.PSCredential" -ArgumentList $User, $PWord

### Connect to Kiev DB Server ###

Connect-Mstsc -ComputerName UAMARSRV001 -Credential $C