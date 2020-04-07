# coreApi
Building a restful web api using .Net MVC core with DI and In memory data.
This project contains a Dockerfile that will allow you to deploy on docker or on Kubernetes cluster
To build this project:
1. Set up your docker server and fork this project into repo
2. In your docker server, clone the project and cd into /coreApi/WebApi and run this command
3. docker build -t webapi .
And you will your new image added to your local repository.
4. To run it => docker run --name api -d -p 80:80 webapi
To browse the web api first open port 80 on your server
http://machine-ip-address/api/books

