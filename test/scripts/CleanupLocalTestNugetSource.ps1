param(
    [Parameter(HelpMessage="The folder contains created Source and temp project to clean up if given")]
    [string] $workFolder,

    [Parameter(HelpMessage="The Name of the Nuget Source to cleanup(remove)")]
    [string] $nugetSourceName = "localTestNugetSource")
    
Import-Module "$PSScriptRoot\LocalTestNugetSource.psm1" -DisableNameChecking -Force;

Remove-Local-Test-Nuget-Source $workFolder $nugetSourceName