# DependencyInjectionASP.NETCore

This project demonstrates the Dependency Injection (DI) principle in an ASP.NET Core environment, simulating a system that could function like a taxi or bus application. The application illustrates how various services can be managed and become dependent using the DI structure.

## Project Structure
- **Controllers**: Provides API endpoints and depends on services.
- **Services**: Contains various services like taxi and bus functionalities.
- **Interfaces**: Defines interfaces used to connect to services with Dependency Injection.

## Dependency Injection (DI) Usage
ASP.NET Core's DI structure helps manage dependencies without directly defining them in code. In this project:

- Interfaces like `ITaxiService` and `IBusService` are defined.
- `TaxiService` and `BusService` classes implement these interfaces.
- In `Startup.cs`, the services are added to the DI container, and the controllers in the project use instances of these services through DI.

## Setup
Clone the project:

```bash
git clone https://github.com/muhammedmustafakurt/DependencyInjectionASP.NETCore.git
```

Install dependencies:

```bash
dotnet restore
```

Run the application:

```bash
dotnet run
```
