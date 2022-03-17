 docker build -t vasire/my_book .
 
 docker images
 
 docker run -p 8080:80 vasire/my_book


 docker ps

 docker stop 75849675846

 docker push  vasire/my_book



 docker build --build-arg HTTP_PROXY=http://10.62.53.164:8090 --build-arg HTTPS_PROX=http://10.62.53.164:8090  -t vasire/my_book:debug .
 
 docker run -d -p 8080:80 --name my_bookCnt vasire/my_book:debug 

 docker stop my_bookCnt

 docker rm my_bookCnt

 docker rmi vasire/my_book:debug

 --- HTTPS

  dotnet dev-certs https --trust

  dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\my_books.pfx -p P@ssw0rd

  dotnet dev-certs https --trust

  Добавление в проект тэга 
  <UserSecretsId>26066c3f-67da-42b6-929b-b5b4368d9aaa</UserSecretsId>

  dotnet user-secrets set "Kestrel:Certificates:Development:Password" "P@ssw0rd"

  docker run -p 8080:80 -p 8081:443 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=8081 -e ASPNETCORE_ENVIROMENT=Development -v $env:APPDATA\microsoft\UserSecrets\:/root/.microsoft/usersecrets -v $env:USERPROFILE\.aspnet\https:/root/.aspnet/https/ vasire/my_book


  docker-compose up --build
  docker-compose up


  dotnet dev-certs https --clean
dotnet dev-certs https --trust -ep $env:USERPROFILE\.aspnet\https\my_books.pfx -p "P@ssw0rd"

openssl req -x509 -newkey rsa:4096 -sha256 -days 3650 -nodes -keyout keycloak.vasire.key -out keycloak.vasire.crt -subj "/CN=keycloak.vasire.com" -addext "subjectAltName=DNS:keycloak.vasire.com,DNS:www.keycloak.vasire.net"