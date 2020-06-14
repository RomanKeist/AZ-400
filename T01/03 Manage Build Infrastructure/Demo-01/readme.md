# .NET Core Build

- Requires [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- Show Build pipeline with designer and yaml
- Show simple release just to prove that is works

## Demo Instructions

Create proj:

```
dotnet new mvc -n MVCBuild
dotnet run
```

Build & publish

```
dotnet publish --configuratin release
```

> Note: In DevOps you would also use the `--output param` to specify where the files should go to
