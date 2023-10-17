using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public enum genderType
        {
            maschio,
            femmina,
            nonSpecificato
        }; // m o f
        public genderType gender;
        public string birthCity;
        public string birthDate;
        public string cf;

        public Person()
        {
            this.firstName = "";
            this.secondName = "";
            this.gender = Person.genderType.nonSpecificato;
            this.birthCity = "";
            this.birthDate = "";
        }
        public Person(string firstName, string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.gender = Person.genderType.nonSpecificato;
            this.birthCity = "";
            this.birthDate = "";
        }
        public Person(string firstName, string secondName, Person.genderType gender) : this(firstName, secondName, gender, "Scandiano", "21/01/2005")
        {

        }

        /// <summary>
        /// Costruttore contenente tutti i parametri, per il salvataggio dei dati di una persona
        /// </summary>
        /// <param name="firstName">Nome della persona</param>
        /// <param name="secondName">Cognome della persona</param>
        /// <param name="gender">Genere, maschio/femmina/non specificato</param>
        /// <param name="birthCity">Città di nascita</param>
        /// <param name="birthDate">Data di nascita</param>
        public Person(string firstName, string secondName, Person.genderType gender, string birthCity, string birthDate)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.gender = gender;
            this.birthCity = birthCity;
            this.birthDate = birthDate;
            this.cf = this.FiscalCode();
            /*CodiceFiscale cfOgg = new CodiceFiscaleUtility.CodiceFiscale(secondName, firstName, Convert.ToString(gender), DateTime.ParseExact(this.birthDate, "dd/mm/yyyy", CultureInfo.InvariantCulture), birthCity, "RE", 0);

            this.cf = cfOgg.CodiceNormalizzato;
            */
            this.stampa();
        }
#if DEBUG
        public string FiscalCode()
        {
            string result, gender;

            // adapt the gender property to the request string type in the constructor of CodiceFiscale
            if (this.gender == Person.genderType.nonSpecificato)
            {
                result = "";

            }
            else
            {
                if (this.gender == Person.genderType.maschio)
                {
                    gender = "M";
                }
                else
                {
                    gender = "F";
                }


                try
                {
                    // creo l'isanta cf
                    CodiceFiscale cfOgg = new CodiceFiscaleUtility.CodiceFiscale(this.secondName, this.firstName, gender, DateTime.ParseExact(this.birthDate, "dd/mm/yyyy", CultureInfo.InvariantCulture), this.birthCity, "RE", 0);

                    // this.cf = cfOgg.CodiceNormalizzato;

                    result = cfOgg.CodiceNormalizzato;
                }
                catch (Exception e)
                {

                    result = e.Message;
                }
;
            }



            return result;

        }

#endif
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

        /// <summary>
        /// Method that given the input of the user, runs a method of this class
        /// </summary>
      
    }
}
