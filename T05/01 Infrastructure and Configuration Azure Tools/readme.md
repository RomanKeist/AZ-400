# 01 Infrastructure and Configuration Azure Tools

[Azure SDK Downloads](https://azure.microsoft.com/en-gb/downloads/)

[Azure REST API Reference](https://docs.microsoft.com/en-us/rest/api/azure/)

[ARM Template Documentation](https://docs.microsoft.com/en-us/azure/azure-resource-manager/templates/)

[Azure Quickstart Templates](https://azure.microsoft.com/en-us/resources/templates/)

[Azure 101 Quickstarter Templates](https://github.com/Azure/azure-quickstart-templates)

[VS Code Extension: ARM Template Viewer](https://marketplace.visualstudio.com/items?itemName=bencoleman.armview)

[Understand the structure and syntax of Azure Resource Manager templates](https://docs.microsoft.com/en-us/azure/azure-resource-manager/templates/template-syntax)

## Azure CLI

[Azure CLI Documentation](https://docs.microsoft.com/en-us/cli/azure/?view=azure-cli-latest)

[Azure CLI Reference](https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest)

[Azure CLI Query](https://docs.microsoft.com/en-us/cli/azure/query-azure-cli?view=azure-cli-latest)

[JMESPath Documentation](http://jmespath.org/)

```bash
az extension list-available --output table
az extension add --name <extension-name>
```

## Azure Powershell

```bash
Install-Module -Name PowerShellGet -Force
Install-Module -Name Az -AllowClobber -Scope CurrentUser
```

Example: Create VM in Cloud Shell:

```bash
New-AzResourceGroup -Name "myResourceGroup" -Location EastUS

New-AzVm `
 -ResourceGroupName "myResourceGroup" `
 -Name "myVM" `
 -Location "East US" `
 -VirtualNetworkName "myVnet" `
 -SubnetName "mySubnet" `
 -SecurityGroupName "myNetworkSecurityGroup" `
 -PublicIpAddressName "myPublicIpAddress" `
 -OpenPorts 80,3389
```

## Lab

[Provision databases in Azure Pipelines](https://docs.microsoft.com/en-us/learn/modules/provision-database-azure-pipelines/)

[Using ARM Templates](http://microsoft.github.io/PartsUnlimited/iac/200.2x-IaC-AZ-400T05AppInfra.html)
