. C:\Service\scripts\adminlauncher\rdpfunction.ps1

### Set Credentials ###

$User = "ci\adm_okrasnoporov1"
$PWord = ConvertTo-SecureString -String "Smile1823" -AsPlainText -Force
$C = New-Object -TypeName "System.Management.Automation.PSCredential" -ArgumentList $User, $PWord

### Connect to Azure Dev DB Server ###

Connect-Mstsc -ComputerName EUWE01ZDEV1CU01.ci.corp -Credential $C