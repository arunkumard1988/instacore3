FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "insta3core3.dll"]