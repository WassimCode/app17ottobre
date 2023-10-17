using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodiceFiscaleUtility;

namespace primaClasse
{
    public class Person
    {
        //CodiceFiscaleUtility.CodiceFiscale c1 = new CodiceFiscaleUtility.CodiceFiscale("Bachar", "Wassim", "M", DateTime);

        // Attributi
        public string firstName;
        public string secondName;
        public string gender; // m o f
        public string birthCity;
        public string birthDate;
        public string cf;

        public Person()
        {
            this.firstName = "";
            this.secondName = "";
            this.gender = "";
            this.birthCity = "";
            this.birthDate = "";
        }
        public Person(string firstName, string secondName, string gender, string birthCity, string birthDate)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.gender = gender;
            this.birthCity = birthCity;
            this.birthDate = birthDate;
            CodiceFiscale cfOgg = new CodiceFiscaleUtility.CodiceFiscale(secondName, firstName, gender, DateTime.ParseExact(this.birthDate, "dd/mm/yyyy", CultureInfo.InvariantCulture), birthCity, "RE", 0);

            this.cf = cfOgg.CodiceNormalizzato;

            this.stampa();
        }




        public int calcolaAnni()
        {
            DateTime dataNascita;
            if (DateTime.TryParseExact(this.birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascita))
            {
                int anni = DateTime.Now.Year - dataNascita.Year;
                if (DateTime.Now.DayOfYear < dataNascita.DayOfYear)
                    anni--;
                return anni;
            }
            else
            {
                throw new ArgumentException("La stringa non rappresenta una data valida.");
            }
        }


        public void stampa()
        {
            Console.WriteLine("\nFirst name: " + this.firstName);
            Console.WriteLine("\nSecond name: " + this.secondName);
            Console.WriteLine("\nGender: " + this.gender);
            Console.WriteLine("\nBirth city: " + this.birthCity);
            Console.WriteLine("\nBirth date: " + this.birthDate);
            Console.WriteLine("\nAge: " + this.calcolaAnni());
            Console.WriteLine("\nCodice fiscale: " + this.cf);
        }
    }
}
