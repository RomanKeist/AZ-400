# Setup & Prerequisites

## Required Cloud Accounts

Please register your Class Lab Environments

[Azure Trial Account](https://azure.microsoft.com/de-de/free/)

[Free Azure DevOps](https://azure.microsoft.com/en-us/services/devops/?nav=min)

[Microsoft 365 Developer E5 Tenant](https://developer.microsoft.com/en-us/microsoft-365/dev-program)

> Note: You can also use your MSDN Ressources. We do not support taking Labs in Production Environments.

## Student Machine Setup

### Frameworks, Tools, CLIs

Install the following Software on your Computer (Windows 10, Mac or Linux):

- [VSCode](https://code.visualstudio.com/download)
- [Git Bash, Version >= 2.2 required for Gitflow ](https://git-scm.com/downloads)
- [Git Extensions](http://gitextensions.github.io/)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)
- [.NET Core SDK 3.1](https://dotnet.microsoft.com/download)
- [Node.js LTS](https://nodejs.org/en/)
- [Chocolatey](https://chocolatey.org/install)
- [WGet for Windows](https://eternallybored.org/misc/wget/)
- [PuTTY for Windows 10](https://the.earth.li/~sgtatham/putty/latest/w64/putty-64bit-0.73-installer.msi)

Install PowerShell Core:

```
dotnet tool install --global PowerShell
```

> Note: In order for Docker to work on a Windows 10 host you need to install [Hyper-V](https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v) or use [Windows Subsystem for Linux 2](https://docs.microsoft.com/en-us/windows/wsl/wsl2-install) (WSL2).

### VS Code Extensions

Optional installation of the following [VS Code Extensions](./VSCode/) is recomended

## Testing the Setup

### Test .NET Core

Navigate to a [.NET Core Project](./T01/01%20Getting%20Started/Demo-01)

Run:

```
dotnet run
```

### Test Docker

Execute:

```
docker run hello-world
```

If you can run all tests successfully you will be able to complete the class.
