$ErrorActionPreference = 'Stop'; # stop on all errors
$toolsDir   = "$(Split-Path -parent $MyInvocation.MyCommand.Definition)"

$target = Join-Path $toolsDir "Slooh.Explorer.exe"
$shortCutFile = Join-Path $([Environment]::GetFolderPath("CommonStartMenu")) "Calteo\Slooh Explorer.lnk"
Install-ChocolateyShortcut -shortcutFilePath $shortCutFile -targetPath $target -workDirectory $toolsDir -description "Slooh Explorer"