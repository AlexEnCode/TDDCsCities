using TDDCsCities;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            rechercheVille = new RechercheVille();
        }

        [Test]
        public void Rechercher_MoinsDeDeuxChar()
        {
            // Arrange
            string mot = "a";

            // Act
            TestDelegate act = () => rechercheVille.Rechercher(mot);

            // Assert
            Assert.Throws<NotImplementedException>(act);
        }

    }
}