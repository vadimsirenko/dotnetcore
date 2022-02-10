#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# copy csproj and restore as distinct layers
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source
COPY *.csproj ./

# Установка сертификата Proxy
## COPY GPNRootCA.cer /usr/local/share/ca-certificates/GPNRootCA.cer
## RUN openssl x509 -inform PEM -in '/usr/local/share/ca-certificates/GPNRootCA.cer' -out '/usr/local/share/ca-certificates/GPNRootCA.crt'
## RUN update-ca-certificates

RUN dotnet restore

# copy everything else and build app
COPY . ./

# builds a project and all of its dependencies
RUN dotnet build -c Release -o /app/build

# packs the application and its dependencies into a folder for deployment to a hosting system
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish --no-restore

# final stage/image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "my_books.dll"]