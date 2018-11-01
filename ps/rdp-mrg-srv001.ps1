. C:\Service\scripts\adminlauncher\rdpfunction.ps1

### Set Credentials ###

$User = "uamrgsrv001\Administrator"
$PWord = ConvertTo-SecureString -String "StartMrgSrv001" -AsPlainText -Force
$C = New-Object -TypeName "System.Management.Automation.PSCredential" -ArgumentList $User, $PWord

### Connect to MRG DB Server ###

Connect-Mstsc -ComputerName UAMRGSRV001 -Credential $C