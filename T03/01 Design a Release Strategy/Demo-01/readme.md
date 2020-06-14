# Use Artifacts

- Pipeline Publish Models Lib to Feed
- Pipeline SpaceGameWeb use Artifact

[Using Package Feed](https://docs.microsoft.com/en-us/learn/modules/manage-build-dependencies/3-set-up-environment)

Model Project:

```
git clone https://github.com/your-name/mslearn-tailspin-spacegame-web-models.git
```

mslearn-tailspin-spacegame-web:

```
git fetch upstream models-package
git checkout -b models-package upstream/models-package
```

## Usage

Interactive Restore of Modes Package in Web Project

```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="Tailspin.SpaceGame.Web.Models" value="https://pkgs.dev.azure.com/integrationstraining/AZ-400-T03/_packaging/Tailspin.SpaceGame.Web.Models/nuget/v3/index.json" />
  </packageSources>
</configuration>
```

```
dotnet restore --interactive
```
