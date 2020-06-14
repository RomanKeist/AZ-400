# Introduction to Azure Repos

[Azure DevOps CLI](https://marketplace.visualstudio.com/items?itemName=ms-vsts.cli)

[Azure DevOps CLI Reference](https://docs.microsoft.com/en-us/cli/azure/ext/azure-devops/?view=azure-cli-latest)

Check Azure CLI version:

```
az --version
```

Add DevOps Extension:

```
az extension add --name azure-devops
```

Login to DevOps:

```
az devops login --org https://dev.azure.com/integrationstraining
```

> [Instructions to get an Access Token](https://docs.microsoft.com/en-us/azure/devops/organizations/accounts/use-personal-access-tokens-to-authenticate?view=azure-devops&tabs=preview-page) - Don't be confused when pasting in the Token even if you don't see something pasted in just press Enter

Configure Default Orga:

```
az devops configure --defaults organization=https://dev.azure.com/integrationstraining
```

DevOps Help:

```
az devops -h
```

List DevOps Projects

```
az devops project list -o table
```

List Pipelines:

```
az pipelines list -p "Parts Unlimited" -o table
```

List a Build Definition

```
az pipelines build definition show --id 96 -p "Parts Unlimited"
```

> Note: the id might be different in your list

Create a Repo

```
az repos create --name azcli.demo.repo -p "Parts Unlimited"
```
