function New-Directory-If-Not-Exist([string]$folder){
  if (!(Test-Path -Path $folder)) {
    New-Item -ItemType Directory -Path $folder | Out-Null
  }
}

function New-Local-Test-Nuget-Source([string]$workFolder, [string]$nugetSourceName="localTestNugetSource"){

  New-Directory-If-Not-Exist $workFolder;
  $packageFolder = Join-Path $PSScriptRoot "..\NugetPackages"
  $sourceFolder = Join-Path $workFolder "Source"
  New-Directory-If-Not-Exist $sourceFolder
  "Nuget SourceFolder created at $sourceFolder" | Out-Host
  $projFolder = Join-Path $workFolder "Project"
  New-Directory-If-Not-Exist $projFolder
  "Nuget ProjectFolder created at $projFolder" | Out-Host

  # we need a proj file to install nuget package so that they will be available in nuget cache for code gen to consume
  $projFile = Join-Path $projFolder "LocalNuget.csproj"
  '<Project Sdk="Microsoft.NET.Sdk">
    <!-- This is a dummy project created by script to trigger nuget package install -->
    <PropertyGroup>
      <TargetFramework>netstandard2.0</TargetFramework>
      <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
      <Nullable>annotations</Nullable>
    </PropertyGroup>
  </Project>' | Out-File $projFile
  "Nuget ProjectFolder created at $projFile" | Out-Host

  dotnet nuget add source $SourceFolder --name $nugetSourceName

  dotnet nuget push $packageFolder\MgmtCustomizations.1.0.0-beta.20240102.1.nupkg -s $nugetSourceName
  dotnet add $projFile package MgmtCustomizations -s $nugetSourceName -v 1.0.0-beta.20240102.1 

}

function Remove-Local-Test-Nuget-Source([string]$workFolder, [string]$nugetSourceName="localTestNugetSource"){
  dotnet nuget remove source $nugetSourceName
  if (Test-Path -Path $workFolder) {
      Remove-Item -Recurse -Force $workFolder
      "Work Folder $workFolder deleted" | Out-Host
  }
  else {
      "Given work folder doesn't exist: $workFolder"
  }
}

Export-ModuleMember -Function "New-Local-Test-Nuget-Source"
Export-ModuleMember -Function "Remove-Local-Test-Nuget-Source"