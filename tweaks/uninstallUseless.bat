:: Uninstall 3D Builder
powershell -Command "Get-AppxPackage *3dbuilder* | Remove-AppxPackage"
:: Uninstall Alarms and Clock
powershell -Command "Get-AppxPackage *windowsalarms* | Remove-AppxPackage"
:: Uninstall Calendar and Mail
powershell -Command "Get-AppxPackage *windowscommunicationsapps* | Remove-AppxPackage"
:: Uninstall OneNote
powershell -Command "Get-AppxPackage *onenote* | Remove-AppxPackage"
:: Uninstall People
powershell -Command "Get-AppxPackage *people* | Remove-AppxPackage"
:: Uninstall Solitaire Collection
powershell -Command "Get-AppxPackage *solitairecollection* | Remove-AppxPackage"
:: Uninstall Sticky Notes
powershell -Command "Get-AppxPackage *stickynotes* | Remove-AppxPackage"
:: Uninstall Xbox app
powershell -Command "Get-AppxPackage *xboxapp* | Remove-AppxPackage"
:: Uninstall Xbox Game Bar
powershell -Command "Get-AppxPackage *gamingoverlay* | Remove-AppxPackage"
:: Uninstall Xbox Console Companion
powershell -Command "Get-AppxPackage *xbox* | Remove-AppxPackage"
:: Uninstall Paint 3D
powershell -Command "Get-AppxPackage *paint3d* | Remove-AppxPackage"
:: Uninstall Your Phone
powershell -Command "Get-AppxPackage *yourphone* | Remove-AppxPackage"
:: Uninstall Mixed Reality Portal
powershell -Command "Get-AppxPackage *holographic* | Remove-AppxPackage"