docker pull mcr.microsoft.com/dotnet/aspnet:6.0
docker pull mcr.microsoft.com/dotnet/sdk:6.0
docker pull mcr.microsoft.com/mssql/server:2019-latest
docker pull jboss/keycloak

docker save -o D:\docker_images\mcr.microsoft.com_dotnet_aspnet_6.0.tar  mcr.microsoft.com/dotnet/aspnet:6.0
docker save  -o D:\docker_images\mcr.microsoft.com_dotnet_sdk_6.0.tar  mcr.microsoft.com/dotnet/sdk:6.0
docker save  -o D:\docker_images\mcr.microsoft.com_mssql_server_2019-latest.tar  mcr.microsoft.com/mssql/server:2019-latest
docker save  -o D:\docker_images\jboss_keycloak_6.0.tar  jboss/keycloak


docker load -i D:\docker_images\mcr.microsoft.com_dotnet_aspnet_6.0.tar
docker load -i D:\docker_images\mcr.microsoft.com_dotnet_sdk_6.0.tar
docker load -i D:\docker_images\mcr.microsoft.com_mssql_server_2019-latest.tar
docker load -i D:\docker_images\jboss_keycloak_6.0.tar
