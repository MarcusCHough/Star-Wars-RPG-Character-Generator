using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class Species
    {
        string name;
        int brawn, agility, intelligence, cunning, wisdom, presence;
        List<string> skills;
        Dictionary<string, string> speciesAbilities;

        public Species() { }

        public Species(string _name, int _brawn, int _agil, int _intel, int _wis, int _pres)
        {
            name = _name;
            brawn = _brawn;
            agility = _agil;
            intelligence = _intel;
            wisdom = _wis;
            presence = _pres;
        }

        public Species(string _name, int _brawn, int _agil, int _intel, int _wis, int _pres, List<string> _skills)
        {
            name = _name;
            brawn = _brawn;
            agility = _agil;
            intelligence = _intel;
            wisdom = _wis;
            presence = _pres;
            skills = _skills;
        }

        public Species(string _name, int _brawn, int _agil, int _intel, int _wis, int _pres, Dictionary<string, string> _abilities)
        {
            name = _name;
            brawn = _brawn;
            agility = _agil;
            intelligence = _intel;
            wisdom = _wis;
            presence = _pres;
            speciesAbilities = _abilities;
        }

        public Species(string _name, int _brawn, int _agil, int _intel, int _wis, int _pres, List<string> _skills, Dictionary<string, string> _abilities)
        {
            name = _name;
            brawn = _brawn;
            agility = _agil;
            intelligence = _intel;
            wisdom = _wis;
            presence = _pres;
            skills = _skills;
            speciesAbilities = _abilities;
        }

    }
}
