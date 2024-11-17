# Используем базовый образ для ASP.NET 8.0
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Используем образ для сборки .NET SDK 8.0
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["StudentFileManagment.Bot/StudentFileManagment.Bot.csproj", "StudentFileManagment.Bot/"]
RUN dotnet restore "StudentFileManagment.Bot/StudentFileManagment.Bot.csproj"
COPY . .
WORKDIR "/src/StudentFileManagment.Bot"
RUN dotnet build "StudentFileManagment.Bot.csproj" -c Release -o /app/build

# Этап публикации
FROM build AS publish
RUN dotnet publish "StudentFileManagment.Bot.csproj" -c Release -o /app/publish

# Финальный этап
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StudentFileManagment.Bot.dll"]