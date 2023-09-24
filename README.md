# Projet 2 Parcours .Net

Si erreur au premier lancement.
==> supprimer dossier bin et obj
==> clic droit sur la solution puis "clean soltution"
==> clic droit sur la soltuion puis "Rebuild solution"
==> dans la console Powershell, se mettre dans le dossier du projet(où le csproj est visible) et taper "dotnet restore"

## BDD
Ouvrir le Package Console Manager (Barre d'outils ==> View==> Other Views ==> Package Console Manager)
Faire un "Update-Database"
Si erreur de type "Echec d'instance", vérifiez la chaine de connexion dans le web.config, surtout "Server=localhost\\", certaines fois cela fonctionne avec un backslash, d'autres fois avec deux, cela dépend de la configuration de votre serveur
Vous pouvez ajouter des données pour alimenter votre BDD dans la méthode Seed() de la classe Configuration

