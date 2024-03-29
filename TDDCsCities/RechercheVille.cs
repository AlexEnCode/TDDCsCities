﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCsCities
{

    public class RechercheVille
    {
        private List<String> _villes;

        List<string> villes = new List<string>
        {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne",
            "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
        };

        public RechercheVille(List<string> villes)
        {
            _villes = villes;
        }

        public List<String> Rechercher(String mot)
        {
            if (mot == "*")
            {
                return _villes.ToList();
            }
            if (mot.Length < 2)
            {
                throw new NotFoundException("Le texte de recherche doit avoir au moins 2 caractères.");
            }

            List<string> result = _villes
                       .Where(ville => ville.IndexOf(mot, StringComparison.OrdinalIgnoreCase) != -1)
                       .ToList();

            return result;
        }
    }
}
