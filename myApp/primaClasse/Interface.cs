using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace primaClasse
{
    public class Interface
    {

        public static void menu(List<Person> pArray)
        {
            // char choise from the user



            char choice = ' ';



            while (choice != 'z')
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n Person Generator! \n ----------------\n\n");
                    Console.WriteLine("\n a) - enter a new person");
                    Console.WriteLine("\n b) - show person details");
                    Console.WriteLine("\n c) - show CF");
                    Console.WriteLine("\n d) - show age");
                    Console.WriteLine("\n ----------------\n");
                    Console.WriteLine("\n z) - exit ");
                    Console.WriteLine("\n\n ----------------\n");

                    Console.WriteLine("Enter : ");
                    choice = Convert.ToChar(Console.ReadLine());

                    switch (choice)
                    {

                        case 'a':
                            Console.Clear();
                            pArray.Add(createPerson());
                            Console.WriteLine("\n Persona creata con successo!");
                            Console.ReadLine();

                            break;
                        case 'b':
                            Console.Clear();

                            for (int i = 0; i < pArray.Count(); i++)
                            {
                                Console.WriteLine("\n-------------------\n - Persona di indice " + i + " - \n");
                                pArray[i].stampa();
                            }
                            Console.ReadLine();
                            break;
                        case 'c':
                            Console.Clear();

                            for (int i = 0; i < pArray.Count(); i++)
                            {
                                Console.WriteLine("\n-------------------\n - CF della persona con indice " + i + " : " + pArray[i].cf + " - \n");

                            }
                            Console.ReadLine();
                            break;
                        case 'd':
                            Console.Clear();

                            for (int i = 0; i < pArray.Count(); i++)
                            {
                                Console.WriteLine("\n----------\n - Anni della persona con indice " + i + " : " + pArray[i].calcolaAnni() + " - \n");

                            }
                            Console.ReadLine();
                            break;
                        case 'z':

                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\n Non presente nel menu. \n");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

        public static Person createPerson()
        {


            string firstName;
            string secondName;
            char genderChoise; // m, f o n
            string birthCity;
            string birthDate; // dd/mm/yyyy

            Person.genderType gender;

            try
            {

                Console.WriteLine("\n - Enter the person name: ");
                firstName = Console.ReadLine();

                Console.WriteLine("\n - Enter the person surname: ");
                secondName = Console.ReadLine();



                Console.WriteLine("\n - Enter the person's gender(m,f or n): ");
                genderChoise = Convert.ToChar(Console.ReadLine());

                while (genderChoise != 'm' && genderChoise != 'f' && genderChoise != 'n')
                {
                    if (genderChoise != 'm' && genderChoise != 'f' && genderChoise != 'n')
                    {
                        Console.WriteLine("\n Please follow the instructions.\n");
                    }

                    Console.WriteLine("\n - Enter the person's gender(m,f or n): ");
                    genderChoise = Convert.ToChar(Console.ReadLine());

                }

                if (genderChoise == 'm')
                {
                    gender = Person.genderType.maschio;
                }
                else if (genderChoise == 'f')
                {
                    gender = Person.genderType.femmina;
                }
                else
                {
                    gender = Person.genderType.nonSpecificato;
                }

                Console.WriteLine("\n - Enter the person's birth city: ");
                birthCity = Console.ReadLine();


                Console.WriteLine("\n - Enter the person's date of birth: ");
                birthDate = Console.ReadLine();

                while (!Regex.IsMatch(birthDate, @"^\d{2}/\d{2}/\d{4}$"))
                {
                    if (!Regex.IsMatch(birthDate, @"^\d{2}/\d{2}/\d{4}$"))
                    {
                        Console.WriteLine("\n Wrong format, please write the date in a format dd/mm/yyyy.\n");
                    }

                    Console.WriteLine("\n - Enter the person's date of birth: ");
                    birthDate = Console.ReadLine();

                }

                return new Person(firstName, secondName, gender, birthCity, birthDate);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

    }
}
