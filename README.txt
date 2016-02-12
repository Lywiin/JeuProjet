Comment synchroniser unity avec github ?


1 - Telechargez et installez ceci https://desktop.github.com/

2 - Sous unity creez un projet "JeuProjet" pour qu'il vous telecharge tous les assets de base

3 - Telechargez le zip du projet sur le site github

4 - Extrayez le dans le dossier du projet unity en remplacant les fichiers si besoin

5 - Sur github desktop cliquez sur le + en haut à gauche, puis clone, selectionez JeuProjet puis le chemin du dossier du projet Unity

6 - Voilà c'est synchronysé, maintenant quand vous voulez soummetre un changement il faut aller (Sur github desktop) dans l'onglet "changes"
	->selectionez la branche master en haut
	->donnez un titre au commit (et une description si besoin) puis valider
	->cliquez sur le bouton sync en haut à droite

Pensez à mettre à jour votre dossier quand vous commencez à bosser si quelqu'un l'a modifié entre temps en faisant les étapes 3 et 4 !
Faites attention a pas écraser la mise à jour de quelqu'un si quelqu'un a re sync pendant que vous bossiez, au pire passez par une branche intermediaire puis fusionez les deux ensuite.

Voilà le mieux pour comprendre c'est encore de tester par soi même :p