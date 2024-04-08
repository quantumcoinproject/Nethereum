for /R %DIR% %%a in (*.nupkg) do  dotnet nuget push "%%a" --api-key %1 --source https://api.nuget.org/v3/index.json
for /R %DIR% %%a in (*.snupkg) do  dotnet nuget push "%%a" --api-key %1 --source https://api.nuget.org/v3/index.json

