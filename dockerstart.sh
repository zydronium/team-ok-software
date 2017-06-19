#!/bin/sh
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Pass_w0rd' -v /docker/mssql:/var/opt/mssql/ -d -p 1433:1433 --name=teamok-backend-db --rm microsoft/mssql-server-linux
sleep 10
docker run -e 'ConnectionStrings:SQLServer=Server=database;Database=werkplek;User Id=sa;Password=Pass_w0rd;' -t -i -d -p 881:80 --link teamok-backend-db:database --rm --name=teamok-backend-facade teamok/backend
sleep 10
docker run -t -i -d -p 882:80 --rm --name=teamok-workfrontend-facade teamok/workfrontend
sleep 10
docker run -t -i -d -p 883:4200 --rm --name=teamok-webfrontend teamok/webfrontend