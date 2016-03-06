#
# CreateResourceGroup.ps1
#
$locName = "South Central US"
$rgName = "Octoposh"

New-AzureRmResourceGroup -Name $rgName -Location $locName -Force -Verbose