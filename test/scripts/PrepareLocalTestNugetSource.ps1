param(
    [Parameter(Mandatory=$true, HelpMessage="The folder to create nuget source and other temp project, the script will try to create the work folder if it's not exist")]
    [ValidateNotNullOrEmpty()]
    [string] $workFolder,

    [Parameter(HelpMessage="The Name of created Nuget Source")]
    [string] $nugetSourceName = "localTestNugetSource")

Import-Module "$PSScriptRoot\LocalTestNugetSource.psm1" -DisableNameChecking -Force;

New-Local-Test-Nuget-Source $workFolder $nugetSourceName