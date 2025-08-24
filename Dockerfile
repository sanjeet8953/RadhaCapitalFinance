# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY ["RadhaCapitalFinance.csproj", "./"]
RUN dotnet restore "./RadhaCapitalFinance.csproj"

# Copy everything else and build
COPY . .
WORKDIR "/src"
RUN dotnet build "RadhaCapitalFinance.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "RadhaCapitalFinance.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RadhaCapitalFinance.dll"]
