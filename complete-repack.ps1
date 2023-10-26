# Clean
dotnet clean src -v m;
Get-ChildItem -Directory -Recurse -Include bin, obj |
    Remove-Item -Force -Recurse

# Pack
dotnet pack src;

# Analyze
Get-ChildItem -File -Recurse -Include *.nupkg |
    Get-Item | ForEach-Object {

        # return @{"site" = $($site); "app" = $($app)}
        return @{
            "Name"            = $_.Name;
            "FileVersion"     = $_.VersionInfo.FileVersion;
            "ProductVersion"  = $_.VersionInfo.ProductVersion;
        }
    } | Format-Table