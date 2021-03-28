$ErrorActionPreference = 'Stop'; 

$shortCutFile = Join-Path $([Environment]::GetFolderPath("CommonStartMenu")) "Calteo\Slooh Explorer.lnk"
Remove-Item $shortCutFile -Force
