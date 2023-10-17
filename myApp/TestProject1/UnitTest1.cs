using System.Globalization;
using CodiceFiscaleUtility;
using primaClasse;

namespace TestProject1

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void constructionTest()
        {
            primaClasse.Person myPerson = new primaClasse.Person("Wass", "Bak", Person.genderType.maschio);
            /*
            //test constructor
             myPerson = new primaClasse.Person("Mario", "Rossi");

            //test constructor
             myPerson = new primaClasse.Person("Mario", "Rossi", personClass.Person.GenderType.Male);

            //test constructor
            myPerson = new primaClasse.Person"Mario", "Rossi", personClass.Person.GenderType.Male, "Roma", new DateTime(2000, 10, 15));*/

        }
        [TestMethod]
        public void ageCheck()
        {


            primaClasse.Person myPerson = new primaClasse.Person("Wassim", "Bachar", Person.genderType.maschio, "Scandiano", "21/01/2005");


            

            if (myPerson.calcolaAnni() < 0)
            {
                throw new Exception("It cannot register someone that isn't born yet!");
            }
        }


        [TestMethod]
        public void cfCheck() {

            primaClasse.Person myPerson = new primaClasse.Person("Wassim", "Bachar", Person.genderType.maschio, "Scandiano", "21/01/2005");


            if (myPerson.FiscalCode() != "BCHWSM05A21I496L")
            {
                throw new Exception("Wrong cf");
            }




        }
    }
}