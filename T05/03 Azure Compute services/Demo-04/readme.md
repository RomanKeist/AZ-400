# Demo Instructions

Install function tools:

```
npm install -g azure-functions-core-tools
```

Scaffold Project:

```
func init DemoFunctions
cd DemoFunctions
```

Create a new Function:

```
func new --name MyHttpTrigger --template "HttpTrigger"
```

> Note: If you leave out the template you will be prompted for it

Run function locally:

```
func host start --build
```

Create Ressources in Azure:

```
az group create --name rf-functionapp-ap --location westeurope

az storage account create --name demofuntionsap --location westeurope --resource-group rf-functionapp-ap --sku Standard_LRS

az functionapp create --resource-group rf-functionapp-ap --consumption-plan-location westeurope --name demofuncitonsap --storage-account demofuntionsap --runtime dotnet

func azure functionapp publish DemoFunctions
```
