IL n'y a aucune gestion d'erreur, tout est dans une seule classe, n'exploitant pas la programmation par objet mais plutôt la programmation procédurale qui s'exécute ligne par ligne. 
Ce travail est une brêve ébauche d'une solution qui permet de résoudre certains de ses problèmes selon une méthologie vue en cours. 

On va séparer le code en plusieurs fonctionnalités
infra: parser loger etc
domain: commande, printer, report


On va utiliser un golden master pour s'assurer de la non regression du code existant, puis on va petit à petit implémenter les tests de toutes classes / fonctions qu'on va ajouter au projet de manière à ce que 100% des fonctions du code sont testées et qu'on puisse se passe du goldenmaster.
