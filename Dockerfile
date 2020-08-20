FROM microsoft/aspnetcore:2.0-stretch AS base
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "LanchesMac.dll"]

FROM mcr.microsoft.com/mssql/server