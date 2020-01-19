using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class SpeciesManager
    {
        string path;
        string jsonString;

        public SpeciesManager() { }

        public SpeciesManager(string _path)
        {
            path = _path;
        }

        public string LoadSpecies(string _path)
        {
            readSpeciesFile(_path);
            return CreateSpeciesList();           
        }

        private void readSpeciesFile(string _path)
        {
            if (String.IsNullOrEmpty(_path))
            {
                return;
            }
            else
            {
                jsonString = File.ReadAllText(_path);
            }
        }

        private string CreateSpeciesList()
        {
            string species = string.Empty;

            if (!String.IsNullOrEmpty(jsonString))
            {
                species = JsonUtility.FromJson<string>(jsonString);
               
            }
            return species;
        }

    }
}
