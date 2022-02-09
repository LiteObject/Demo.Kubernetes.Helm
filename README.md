# Helm Chart

## To build docker image:
$`docker build -f WeatherForecast.API/Dockerfile -t liteobject/demo-helm-chart:latest . --label "created-by=mhoque"

## To view images details:
$`docker inspect [NAME|ID]

## To push to dockerhub
$`docker push liteobject/demo-helm-chart:latest

## To run using kubernetes deployment file:
$`kubectl apply -f k8s/deployment.yaml

## To delete a deployment:
$`kubectl delete -f k8s/deployment.yaml

## To watch logs using label:
$`kubectl logs -l app=weather-forecast-webapi -f --since=10m

## To access and interact with internal Kubernetes cluster processes from localhost
$` k port-forward [pod-name] 8080:80

## Install existing applications with Helm:
- https://docs.microsoft.com/en-us/azure-stack/aks-hci/kubernetes-helm

## To add the Nginx repo to your cluster using helm
$`helm repo add ingress-nginx https://kubernetes.github.io/ingress-nginx 
$`helm repo update

## To install the Nginx ingress in the namespace ingress
$`helm install my-nginx-ingress ingress-nginx/ingress-nginx `
    --set controller.nodeSelector."beta\.kubernetes\.io/os"=linux `
    --set defaultBackend.nodeSelector."beta\.kubernetes\.io/os"=linux

