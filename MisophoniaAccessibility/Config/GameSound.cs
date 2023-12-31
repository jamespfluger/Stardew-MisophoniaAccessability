using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisophoniaAccessibility.Config
{
    public class GameSound : Attribute
    {
        public string CodeName { get; private set; }
        public string DisplayName { get; private set; }

        public GameSound(string codeName, string displayName)
        {
            CodeName = codeName;
            DisplayName = displayName;
        }
    }
}
