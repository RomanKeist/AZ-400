# Demo - Azure Container Instances

```
az container create --resource-group az-400 --name az-400-aci-demo --image microsoft/aci-helloworld --dns-name-label az-400-aci-demo --ports 80

az container show --resource-group az-400 --name az-400-aci-demo --query "{FQDN:ipAddress.fqdn,ProvisioningState:provisioningState}" --out table
```

Open url in browser: `ie az-400-aci-demo.westeurope.azurecontainer.io`
