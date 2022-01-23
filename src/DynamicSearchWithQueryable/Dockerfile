FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DynamicSearchWithQueryable/DynamicSearchWithQueryable.csproj", "DynamicSearchWithQueryable/"]
COPY ["DynamicSearchWithQueryable/Data/database.csv", "DynamicSearchWithQueryable/Data/"]
RUN dotnet restore "DynamicSearchWithQueryable/DynamicSearchWithQueryable.csproj"
COPY . .
WORKDIR "/src/DynamicSearchWithQueryable"
RUN dotnet build "DynamicSearchWithQueryable.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DynamicSearchWithQueryable.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DynamicSearchWithQueryable.dll"]