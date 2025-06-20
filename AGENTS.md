# Contribution Guide for Agents

This repository hosts a multi-project .NET 9 solution. Follow these rules when making changes:

## Coding Guidelines

- Keep all source files inside the `src/` directory and tests inside `tests/`.
- Use `net9.0` as the target framework for .NET projects.
- The frontend client resides in `src/TimeTracker.Client` and uses Node tooling.

## Programmatic Checks

Run the following commands before committing:

```bash
dotnet build TimeTracker.sln
npm --prefix src/TimeTracker.Client test
```

If dependencies are missing or commands fail in your environment, note the failure in your pull request.
