using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCsCities
{

    public class RechercheVille
    {
        private List<String> _villes;

        public List<String> Rechercher(String mot)
        {
            if (mot.Length < 2)
            {
                throw new NotFoundException("Le texte de recherche doit avoir au moins 2 caractères.");
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
