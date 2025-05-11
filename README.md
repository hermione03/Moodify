# 🎧 Moodify — Application API REST pour gestion d'humeurs et musiques

## 📌 Description
Moodify est un projet web développé en .NET Core permettant d’associer des humeurs à des musiques.  
Le backend expose une API REST, conteneurisé avec Docker, déployé via Kubernetes (Minikube), sécurisé avec Cosign et RBAC.

---

## 🚀 Fonctionnalités
- API REST avec Swagger
- Connexion à base MySQL locale
- Signature d'image avec Cosign
- Déploiement Kubernetes avec Ingress
- Port-forwarding pour tests locaux
- Contrôle d'accès (RBAC)
- Prêt pour microservices

---

## 🔧 Stack technique
- .NET 7 / ASP.NET Core
- MySQL
- Docker
- Kubernetes + Minikube
- Cosign (signature)
- RBAC (K8s)
- Swagger / OpenAPI

---

## ⚙️ Démarrage rapide

```bash
# Build l'image Docker
docker build -t hermione08/moodifyapi:latest .

# Charger dans Minikube
minikube image load hermione08/moodifyapi:latest

# Déployer
kubectl apply -f ./k8s/deployment.yaml
kubectl apply -f ./k8s/service.yaml
kubectl apply -f ./k8s/ingress.yaml

# Ou port-forward pour accès local
kubectl port-forward svc/moodifyapi-service 8080:80

