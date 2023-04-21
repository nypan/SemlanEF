# EF core migration

## EF tool

```
dotnet tool install --global dotnet-ef
```

## Migrering SQL server

### Skapa en första migrering
```
 dotnet ef migrations add InitialCreate --startup-project .\src\Semlan.DbMigration\  --project .\src\Semlan.Data\

```

### Skapa database

```
 dotnet ef database update --startup-project .\src\Semlan.DbMigration\  --project .\src\Semlan.Data\
```

## Migrering SQlite

### Skapa en första migrering
```
# windows
 dotnet ef migrations add InitialCreate --startup-project .\src\Semlan.DbMigrationSqlite\  
dotnet ef migrations add InitialCreate --startup-project ./src/Semlan.DbMigrationSqlite/  
```

### Skapa database

```
# windows
 dotnet ef database update --startup-project .\src\Semlan.DbMigrationSqlite\ 
# macos
 dotnet ef database update --startup-project ./src/Semlan.DbMigrationSqlite/  --project ./src/Semlan.DataSqlite/

# alt
dotnet ef database update --startup-project ./src/Semlan.DbMigrationSqlite/  --project ./src/Semlan.DataSqlite/ --connection "Data Source=../../sqlitedb/semlanx.db;Cache=Shared"
```