# Stage 1: Build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY ["Funds/RadhaCapitalFinance.csproj", "Funds/"]
RUN dotnet restore "Funds/RadhaCapitalFinance.csproj"

# Copy the rest of the source
COPY . .

# Build and publish
WORKDIR "/src/Funds"
RUN dotnet publish "RadhaCapitalFinance.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 2: Final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "RadhaCapitalFinance.dll"]
