using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    interface CharacteristicsManager
    {
        void IncreaseAttribute(string attribute);
        void DecreaseAttribute(string attribute);
        void IncreaseSkill(string skill);
        void DecreaseSkill(string skill);
    }
}
