# Readme - Blazor Example

## Start app

- Clone repo
- Startup Project
  - CarRentalManagement.Server
  - IIS Express
- Create IIS Database: `Update Database`
- Dummy Test-User:
  - admin@localhost.com
  - P@ssword1
- Example for Error page in `ColorsController`

## Resources

- <https://www.udemy.com/course/modern-web-development-with-blazor-and-net-core-5/learn/lecture/23571956#overview>
- <https://docs.microsoft.com/en-us/aspnet/core/blazor/project-structure?view=aspnetcore-6.0>

## Remarks

## If Entity changed

- `Add-Migration MigrationDescription`
- `Update Database`

## Pattern

- Unit of Work
- Repository Pattern (Client & Server)

## Best Practices

- Http Interceptor
- Isolate Client Component from Code

## Deployment (Azure)

## Security

Content Security Policy (CSP)

- <https://developer.mozilla.org/en-US/docs/Web/HTTP/CSP>
- `C:\repos\CarRentalManagement\CarRentalManagement\Client\wwwroot\index.html`
