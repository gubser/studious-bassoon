FROM mcr.microsoft.com/dotnet/core/sdk:2.1-bionic AS build

WORKDIR /src
COPY ./teamA-complex.csproj /src/

WORKDIR /src/
RUN dotnet restore

COPY . /src/
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-bionic AS runtime
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "teamA-complex.dll"]