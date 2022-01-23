# DynamicSearchWithQueryable

It's a WebApi project made to demo a easy way to create complex database queries using the framework <b>[AspNetCore.IQueryable.Extensions](https://github.com/brunohbrito/AspNetCore.IQueryable.Extensions#all-in-one)</b>.
  
<br/>

## How to execute?
The app can be running by its self or via docker, through the command: <code>docker-compose up</code> in the <b>src</b> folder,

> <b>Note:</b> If you intend to run the app standalone, remind to setup the database.

<br/>

## Running over https on Docker
To running the app over https on Docker, is necessary creating a local certificate through the follow commands:

<code>dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\aspnetapp.pfx -p { password here }</code>  
    
<code>dotnet dev-certs https --trust </code>

> <b>Note:</b> Replace this "<b>{ password here }</b>" for your own password.

For more details, access: https://docs.microsoft.com/en-us/aspnet/core/security/docker-compose-https?view=aspnetcore-6.0

<br/>

## Project Stack
- Net 6
- SqlServer 2019
- EF Core 6

