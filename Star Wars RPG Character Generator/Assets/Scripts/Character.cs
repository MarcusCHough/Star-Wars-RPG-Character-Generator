using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class Character
    {
        Dictionary<string, int> characteristics;
        Dictionary<Enum, int> skills;
        Dictionary<int, Item> equipment;
        Dictionary<int, Weapon> weapons;
        Armor armor;
    }
}
