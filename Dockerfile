# Use official .NET SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore
COPY ["Funds/Funds.csproj", "Funds/"]
RUN dotnet restore "Funds/Funds.csproj"

# Copy everything and build
COPY . .
WORKDIR "/src/Funds"
RUN dotnet publish "Funds.csproj" -c Release -o /app/publish

# Final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Funds.dll"]
