#
# SwapSlot.ps1
#
Switch-AzureWebsiteSlot -Name $WebAppName -Slot1 $OctopusParameters['Octopus.Environment.Name'] -Slot2 Production -Force -verbose