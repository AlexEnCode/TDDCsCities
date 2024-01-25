using TDDCsCities;
namespace TestProject1
{
    public class Tests
    {
        private RechercheVille _rechercheVille;

        [SetUp]
        public void Setup()
        {
            List<string> villes = new List<string>
        {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne",
            "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
        };
            _rechercheVille = new RechercheVille(villes);

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

        [Test]
        public void RechercherVillesPlusDexuChar()
        {
            // Arrange
            string mot = "Va";

            // Act
            List<string> result = _rechercheVille.Rechercher(mot);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "Valence", "Vancouver" }, result);
        }

        [Test]
        public void RechercherInsensibleCasse()
        {
            // Act
            var resultUpperCase = _rechercheVille.Rechercher("VA");

            // Assert
            CollectionAssert.AreEqual(new List<string> { "Valence", "Vancouver" }, resultUpperCase);
        }

        [Test]
        public void RechercherTextePartiel()
        {
            // Act
            var result = _rechercheVille.Rechercher("ape");

            // Assert
            CollectionAssert.AreEqual(new List<string> { "Budapest" }, result);
        }
        [Test]
        public void RechercherEtoilePourTout()
        {
            // Act
            var result = _rechercheVille.Rechercher("*");

            // Assert
            CollectionAssert.AreEqual(new List<string> { "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne",
            "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul" }, result);
        }


    }
}
