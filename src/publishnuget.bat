for /R %DIR% %%a in (*.snupkg) do  dotnet nuget push "%%a" --api-key %apikey% --source https://api.nuget.org/v3/index.json

