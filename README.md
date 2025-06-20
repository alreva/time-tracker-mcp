# Time Tracker MCP

This repository contains a sample solution for an AI-assisted time tracking system built on .NET 9. The architecture separates the user facing API, the agent integration, management pages and a standalone client.

## Projects

- **TimeTracker.Api** – ASP.NET Core Web API for end users. It exposes endpoints for chat communication and time entry management.
- **TimeTracker.Agent** – Service that interacts with the MCP AI agent. It can be secured separately from the user API.
- **TimeTracker.Backoffice** – Web UI for administrators to inspect and adjust time records produced by the agent.
- **TimeTracker.Client** – Frontend chat application (JavaScript/TypeScript) that streams responses from the agent via `TimeTracker.Api`.

Tests live under `tests/` and supporting documentation and scripts are kept in `docs/` and `scripts/` respectively.

The solution file `TimeTracker.sln` includes the API, agent and backoffice projects. A `global.json` pinpoints the .NET 9 SDK version.

## Getting Started

1. Install the [.NET 9 SDK](https://dotnet.microsoft.com/).
2. From the repository root run `dotnet build TimeTracker.sln` to restore packages and build all projects.
3. The client project can be started with `npm start` once dependencies are installed in `src/TimeTracker.Client`.

This layout is intended as a starting point and will evolve as features are implemented.

### Project Structure

```
time-tracker-mcp/
├── src/
│   ├── TimeTracker.Api/
│   │   └── Controllers/
│   ├── TimeTracker.Agent/
│   │   └── Services/
│   ├── TimeTracker.Backoffice/
│   │   └── Pages/
│   └── TimeTracker.Client/
└── tests/
```

Each project has its own directory with source files grouped under these folders.
