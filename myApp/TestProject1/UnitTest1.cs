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

        }   
    }
}