# Friday 13th Console App

This application takes a year or a range of years and prints for each of them the list of dates that are fridays the 13th.

## Build

The main project is **Friday.CLI** so this is the project to build.

```
cd dotnet/friday-13th/Friday.CLI
dotnet build
```

## Run

The application only takes one argument which is the year(s) to find all friday 13th dates for.
In can be either a single year like `2022` or a range (two years separated by `..`) like `1984..2023`.

```
cd dotnet/friday-13th/Friday.CLI
dotnet run 2022
dotnet run 1984..2023
```

## Implementation

The implementation is divided in 2 parts of which one is the actual program (console application) and the other is the library part.
The library part is again split up in two parts. One is the abstraction the other is the implementation.

- **Friday.CLI** (console application project)
- **Friday.Lib.Abstractions** (library abstractions project)
- **Friday.Lib.MapReduce** (library implementation project)
