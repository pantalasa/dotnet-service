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

<!-- Trigger compliance-bundle collector -->
<!-- Trigger full compliance bundle -->

## Project Overview

The dotnet-service component provides the "dotnet-demo" capability for the Pantalasa
platform. It is owned by stephanie@pantalasa.org and implemented primarily in dotnet.

## Installation

Clone the repository and install dependencies using the standard dotnet
toolchain.

## Usage

Build and run using the commands documented in [AGENTS.md](AGENTS.md).

## Project Structure

| Path | Purpose |
|------|---------|
| `pantalasa.json` | Service manifest (owner, domain, deployment) |
| `.argocd/` | ArgoCD Application manifest |
| `AGENTS.md` | Agent / contributor instructions |

## Contributing

See [CONTRIBUTING.md](CONTRIBUTING.md). Security policy: [SECURITY.md](SECURITY.md).

## License

Released under the MIT License — see [LICENSE](LICENSE).
