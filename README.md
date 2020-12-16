# SimpleWebService

This is a simple web service project.

## Description

This simple web service project is created in ASP.NET Core framework with C# language. When the project is run, it serves an endpoint date that returns current BST date time. 

## Dependency
* Docker Desktop
* Visual Studio 2019

### How to run in Visual Studio 2019

* Download and Unzip/Git clone the project in your PC
* Open simplewebservice.sln in Visual Studio 2019
* Run the project simplewebservice

### How to run in Docker

* Open your docker command terminal and type the commands below
* docker pull shafi2k1/simplewebservice
* docker run -p 8000:80 shafi2k1/simplewebservice
* In your browser browse the url http://localhost:8000/date

