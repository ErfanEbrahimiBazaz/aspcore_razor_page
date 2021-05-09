## Building a sample app with ASP.net core with razor pages.

The goal is to study how razor pages work and how are they different with razor views.

## To dos:
1. change appsettings.json file by entering your DB user ID and password. I have used Azure SQL DB Server. 
Don't forget to add your IP to provide access.

```
{
  "ConnectionStrings": {
    "Default": "Server=tcp:testaz1.database.windows.net,1433;Database=FirstRazor;User ID=YOUR_DB_USERNAME>;Password=<YOUR_DB_PASSWORD>;Encrypt=true;Connection Timeout=30;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```
