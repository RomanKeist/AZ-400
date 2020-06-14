# Implementing Continuous Integration in an Azure DevOps Pipeline

[Build Options](https://docs.microsoft.com/en-us/azure/devops/pipelines/build/options?view=azure-devops&tabs=yaml)

[Configure run or build numbers](https://docs.microsoft.com/en-us/azure/devops/pipelines/process/run-number?view=azure-devops&tabs=classic)

[Working with Variables](https://docs.microsoft.com/en-us/azure/devops/pipelines/process/variables?view=azure-devops&tabs=yaml%2Cbatch)

[Predefined Variables](https://docs.microsoft.com/en-us/azure/devops/pipelines/build/variables?view=azure-devops&tabs=yaml)

[Build and release retention policies](https://docs.microsoft.com/en-us/azure/devops/pipelines/policies/retention?view=azure-devops&tabs=yaml)

[Buildtools für Visual Studio 2019](https://visualstudio.microsoft.com/de/downloads/?rr=https%3A%2F%2Fwww.google.com%2F)

[Azure Pipelines agents](https://docs.microsoft.com/en-us/azure/devops/pipelines/agents/agents?view=azure-devops&tabs=browser)

[Azure Pipeline YAML Schema Reference](https://docs.microsoft.com/en-us/azure/devops/pipelines/yaml-schema?view=azure-devops&tabs=schema%2Cparameter-schema)

## Self Hosted Build Agents

[Self-hosted Windows Agents](https://docs.microsoft.com/en-us/azure/devops/pipelines/agents/v2-windows?view=azure-devops)

[Github: Azure Pipelines Agent](https://github.com/microsoft/azure-pipelines-agent)

### Configure Self hosted Agents

Check HostOS & Prerequesites for a Windows Host

```
$hostname = Get-CimInstance Win32_ComputerSystem | Select-Object Caption
$osversion = Get-CimInstance Win32_OperatingSystem | Select-Object Caption
$org = "integrationsonline"
$uri = "https://dev.azure.com/$org"
Invoke-WebRequest -Uri $uri | Select-Object StatusCode
```

Download Agent using the Download Button, extract it to a folder

![download-agent](../_images/install-agent.png)

> Note: When configuring the agent make sure you run the PowerShell as Administrator to be able to start the agent as service

```
cd \
mkdir dev-ops-agent;
cd dev-ops-agent;
Add-Type -AssemblyName System.IO.Compression.FileSystem ; [System.IO.Compression.ZipFile]::ExtractToDirectory("$HOME\Downloads\vsts-agent-win-x64-2.160.1.zip", "$PWD")
```

# Lab

[Enabling Continuous Integration with Azure Pipelines](https://www.azuredevopslabs.com/labs/azuredevops/continuousintegration/)

[Integrating Jenkins CI with Azure Pipelines ](https://www.azuredevopslabs.com/labs/vstsextend/jenkins/)

## Learning Labs

[Implement a code workflow in your build pipeline by using Git and GitHub](https://docs.microsoft.com/en-us/learn/modules/implement-code-workflow/)

[Deploy from GitHub to Azure App Service using Jenkins](https://docs.microsoft.com/de-de/azure/developer/jenkins/deploy-from-github-to-azure-app-service)
