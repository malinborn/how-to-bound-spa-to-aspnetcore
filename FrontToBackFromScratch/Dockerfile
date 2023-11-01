FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FrontToBackFromScratch/FrontToBackFromScratch.csproj", "FrontToBackFromScratch/"]
RUN dotnet restore "FrontToBackFromScratch/FrontToBackFromScratch.csproj"
COPY . .
WORKDIR "/src/FrontToBackFromScratch"
RUN dotnet build "FrontToBackFromScratch.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FrontToBackFromScratch.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FrontToBackFromScratch.dll"]
