
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using primaClasse;

List<Person> pArray = new List<Person>();
//primaClasse.Person p1 = new primaClasse.Person("Wassim", "Bachar", Person.genderType.maschio , "Scandiano", "21/01/2005");

pArray.Add(new primaClasse.Person("Wassim", "Bachar", Person.genderType.maschio, "Scandiano", "21/01/2005"));

//Console.ReadLine();

Interface.menu(pArray);
Console.ReadLine();
/*

Console.WriteLine("\n Inserisci un valore: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n Il risultato è: " + Fattoriale(n));



int Fattoriale(int n)
{
    // pre condizione, verifico se n = 1

    if (n == 1) {  
        return 1; 
    }
    else
    {
        return n * Fattoriale(n - 1);
    }
    
}
*/