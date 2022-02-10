# Установить переменную окружения - каталог minikube
env MINIKUBE_HOME - (string) sets the path for the .minikube directory that minikube uses for state/configuration. Please note: this is used only by minikube and does not affect anything related to Kubernetes tools such as kubectl.

# Настройка по умолчанию на использование Hiper-V
minikube config set driver hyperv

# Поменяйте настройки памяти и процессора
minikube config set memory 6144
minikube config set cpus 4

##############################
Преодаление Proxy
set HTTP_PROXY=http://<proxy hostname:port>
set HTTPS_PROXY=https://<proxy hostname:port>
set NO_PROXY=localhost,127.0.0.1,10.96.0.0/12,192.168.59.0/24,192.168.39.0/24

В домашнем каталоге minikube ~/.minikube (MINIKUBE_HOME/.minikube).
Создать структуру
.minikube/files/etc/ssl/certs
Скопировать в эту папку сертификат прокси GPNRootCA.cer
###############################

# Создаем и запускаем кластер
minikube start 
# Создаем и запускаем кластер + разрешаем нодам порт 1433 памяти : Гб 4 Процессора
minikube start --memory 6144 --cpus 4

# Статус кластера
minikube status

# Остановка кластера
minikube stop

# Добавлляем нод в кластер
minikube node add 

# Список нод в кластере
minikube node list

# Устанавливает лейбл на ноде 2
kubectl label nodes minikube-m02 server=mssql

# Запуск приложения - дашборда
minikube dashboard

# Добавление хранилища
kubectl apply -f .\sql-persistent-volume.yaml

# Обзор хранилища
kubectl get pv sqldata

# Добавление заявки на хранилище для ms sql
kubectl apply -f .\claim-sql-persistent-volume.yaml

# Обзор заявок на хранилище
kubectl get pvc kubectl get pvc 

# Созранение пароля SA в секретах
kubectl create secret generic mssql --from-literal=SA_PASSWORD=Tr@nsF0rmer

# Развертывание MS SQL
kubectl apply -f .\sqldeployment.yaml

# Список служб
kubectl get services  

# Внешний аррес службы на ноде
minikube service sql-svc --url

# Логи пода
kubectl get pods
kubectl logs sql-584cdbcd89-m5m2t

# Выгрузка определения Pod
kubectl describe pods sql-584cdbcd89-m5m2t > R:\kubernetes_script/my_log.txt