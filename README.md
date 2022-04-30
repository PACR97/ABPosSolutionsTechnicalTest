# ABPosSolutionsTechnicalTest

## Users and passwords
- Inspectors: username: inspector@localhost.com - password: Inspector123$
- Supervisors: username: supervisor@localhost.com - password: Supervisor123$

Para ejecutar la migracion de Identity se debe utilizar el siguiente comando en la consola de administrador de paquetes Nuget con el proyecto Web seleccionado como Proyecto de inicio y tambien estar seleccionado en la consola de administrador de paquetes Nuguet:
- Update-Database -Context ApplicationIdentityDbContext

Para ejecutar la migracion de la Aplicacion se debe utilizar el siguiente comando en la consola de administrador de paquetes Nuget ,el proyecto seleccionado dentro de la consola de administrador de paquetes Nuget debe ser: src\Infrastructure\ABPosSolutions.TechnicalTest.Infrastructure y el proyecto seleccionado para inicio debe ser el proyecto Web
- Update-Database -Context ApplicationDbContext

### Tecnologias utilizadas
- Patron Mediator con CQRS
- Patron Repository
- Aplicacion MVC .Net 6
- .Net Identity
- MSSQL LocalDb
