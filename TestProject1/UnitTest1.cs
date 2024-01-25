using TDDCsCities;
namespace TestProject1
{
    public class Tests
    {
        private RechercheVille _rechercheVille;

        [SetUp]
        public void Setup()
        {
            _rechercheVille = new RechercheVille();
        }

        [Test]
        public void Rechercher_MoinsDeDeuxChar()
        {
            // Arrange
            string mot = "a";

            // Act
            TestDelegate act = () => _rechercheVille.Rechercher(mot);

            // Assert
            Assert.Throws<NotFoundException>(act, "Le texte de recherche doit avoir au moins 2 caractères.");
        }

    }
}