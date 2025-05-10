# Étape 1 - Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copie le csproj et restore les dépendances
COPY *.csproj ./
RUN dotnet restore

# Copie tout et publie en Release
COPY . ./
RUN dotnet publish -c Release -o out

# Étape 2 - Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose le port utilisé par l'application
EXPOSE 80

# Lancer l'application
ENV ASPNETCORE_ENVIRONMENT=Development
ENTRYPOINT ["dotnet", "MoodifyAPI.dll"]
