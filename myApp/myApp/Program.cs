
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using primaClasse;

List<Person> pArray = new List<Person>();
//primaClasse.Person p1 = new primaClasse.Person("Wassim", "Bachar", Person.genderType.maschio , "Scandiano", "21/01/2005");

pArray.Add(new primaClasse.Person("Wassim", "Bachar", Person.genderType.maschio, "Scandiano", "21/01/2005"));

//Console.ReadLine();

Interface.menu(pArray);
