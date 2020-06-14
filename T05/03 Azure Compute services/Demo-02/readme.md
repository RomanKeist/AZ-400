# Demo - Web App for Containers

Execute:

```bash
az webapp deployment user set --user-name demoapuser --password "Passw0rd1234!"
az appservice plan create --name myAppServicePlan --resource-group myResourceGroup --sku B1 --is-linux
az webapp create --resource-group myResourceGroup --plan myAppServicePlan
--name myTestAppAP --deployment-container-image-name microsoft/azure-appservices-go-quickstart
```

Browse to:

```
https://mytestappap.azurewebsites.net/hello
```