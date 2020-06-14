# Demo - AKS

az group create --name az-400 --location westeurope

az aks create --resource-group az-400 --name voteCluster --node-count 1 --enable-addons monitoring --generate-ssh-keys

az aks install-cli

az aks get-credentials --resource-group az-400 --name voteCluster

kubectl get nodes

kubectl apply -f azure-vote.yaml

kubectl get service azure-vote-front --watch
