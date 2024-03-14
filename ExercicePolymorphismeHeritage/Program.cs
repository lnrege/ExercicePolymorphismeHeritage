// 37. Classes suivantes :
//Créez une interface IHumain qui a comme méthode Afficher qui retourne une chaine de caractères
//sans paramètre (l’interface ne fait que déclarer la signature de la méthode)
//Une classe Personne qui comporte trois propriétés, nom, prénom et date de naissance.
//Cette classe doit implémenter l’interface IHumain(et donc implémenter la méthode
//Afficher qui retourne les propriétés concaténées avec un string format par exemple).
//Cette classe comporte un constructeur pour permettre d'initialiser les données.
//Elle comporte également une méthode polymorphe Afficher qui renvoi la description de l’objet personne en chaine de caractères (nom, prénom, etc.) avec le mot clé virtual.
//Une classe Employé qui dérive de la classe Personne, avec en plus un champ Salaire accompagné de sa propriété, un constructeur et sa redéfinition de la méthode Afficher.
//Réécrivez aussi les méthodes ToString() dans les 2 classes.
//Pour rappel, les 2 classes devront implémenter leurs versions de Afficher.
//Exercices :
//• Ecrire les classes Personne et Employé.
//• Créez un programme de test qui comporte tableau de 4 personnes avec 2 personnes et 2 employés.
//• Affichez l'ensemble des éléments du tableau à l'aide de foreach et de la méthode afficher.
//• Faire le même test avec un tableau de 4 IHumain (qui contient aussi 2 personnes et 2 employés)
//Bonus : exporter vos classes dans une DLL à part.

using ExercicePolymorphismeHeritage;
using System;

void Exo37()
{
	Personne[] tableau =
		{
new Personne("FAVE","Jean", DateOnly.Parse("20/01/1987")),
new Personne("DUPONT", "Philippe", DateOnly.Parse("20/01/1990")),
new Employe("DURAND", "Julie", DateOnly.Parse("20/10/1987"),35000),
new Employe("POULE", "Karine", DateOnly.Parse("14/01/1987"),45000)
};

	foreach (Personne person in tableau)
	{
		Console.WriteLine(person.Afficher());
	}

	IHumain[] itableau =
		{
new Personne("iFAVE","Jean", DateOnly.Parse("20/01/1987")),
new Personne("iDUPONT", "Philippe", DateOnly.Parse("20/01/1990")),
new Employe("iDURAND", "Julie", DateOnly.Parse("20/10/1987"),35000),
new Employe("iPOULE", "Karine", DateOnly.Parse("14/01/1987"),45000)
};

	foreach (IHumain iperson in itableau)
	{
		Console.WriteLine(iperson.Afficher());
	}
}

//1. Créez un tableau d’entier, trier le tableau et afficher tous les nombres dans l’ordre
void Bonus1()
{
	int[] tab = { 34, 12, 67, 89, 3, 0, 234, 111 };
	Array.Sort(tab);
	foreach (int i in tab) Console.WriteLine(i);
}
//Bonus1();

//2. Affichez une liste de string par ordre alphabétique
void Bonus2()
{
	List<string> l = new List<string>();
	l.Add("PARIS");
	l.Add("MONTPELLIER");
	l.Add("BORDEAUX");
	l.Add("MARSEILLE");
	l = l.OrderBy(x => x).ToList();
	foreach (string s in l) Console.WriteLine(s);
}
//Bonus2();

//3. Afficher une liste de personne
void Bonus3()
{
	List<Personne> listePersonnes = new List<Personne>()
	{
	new Personne ("FAVE","Jean", DateOnly.Parse("20/01/1987")),
new Personne ("DUPONT", "Philippe", DateOnly.Parse("20/01/1990")),
new Employe  ("DURAND","Julie",DateOnly.Parse("20/10/1987"),35000),
new Employe ("POULE", "Karine", DateOnly.Parse("14/01/1987"),45000)
};
	foreach (Personne person in listePersonnes) Console.WriteLine(person.Afficher());
}
//Bonus3();

//4. Afficher un dictionnaire de personne avec un entier Id en clé
void Bonus4()
{
	Dictionary<int, Personne> listePers = new Dictionary<int, Personne>();
	listePers.Add(1, new Personne("FAVE", "Jean", DateOnly.Parse("20/01/1987")));
	listePers.Add(2, new Personne("DUPONT", "Philippe", DateOnly.Parse("20/01/1990")));
	listePers.Add(3, new Employe("DURAND", "Julie", DateOnly.Parse("20/10/1987"), 35000));
	listePers.Add(4, new Employe("POULE", "Karine", DateOnly.Parse("14/01/1987"), 45000));

	foreach (KeyValuePair<int, Personne> item in listePers)
	{
		Console.WriteLine($"Key ={item.Key}, Valeur : {item.Value}");
	}
}
//Bonus4();

