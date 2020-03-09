FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env

WORKDIR /src
COPY . ./
RUN dotnet publish -c Release -o /app

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app .
ENTRYPOINT ["dotnet", "Products.dll"]