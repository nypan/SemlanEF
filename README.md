# EF core migration

## EF tool

```
dotnet tool install --global dotnet-ef
```

## Skapa en första migrering
```
 dotnet ef migrations add InitialCreate --startup-project .\src\Semlan.DbMigration\  --project .\src\Semlan.Data\

```

## Skapa database

```
 dotnet ef database update --startup-project .\src\Semlan.DbMigration\  --project .\src\Semlan.Data\
```