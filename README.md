# DotnetService

A sample .NET 8 web service for testing Lunar collectors and policies.

## Project Structure

- `src/DotnetService/` — ASP.NET Core web API
- `tests/DotnetService.Tests/` — xUnit test project
- `global.json` — SDK version pinned to 8.0.300
- `Directory.Build.props` — Shared build properties

## Build

```bash
dotnet restore
dotnet build
dotnet test
```
