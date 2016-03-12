#
# CreateResourceGroup.ps1
#
$locName = "South Central US"
$rgName = "Octoposh"

IF(!(Get-AzureRmResourceGroup -Name $rgName -ErrorAction SilentlyContinue)){
	New-AzureRmResourceGroup -Name $rgName -Location $locName -Force -Verbose
}

