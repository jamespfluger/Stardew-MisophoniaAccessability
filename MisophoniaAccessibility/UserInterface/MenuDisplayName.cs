using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisophoniaAccessibility.UserInterface
{
    public class MenuDisplayName : Attribute
    {
        public string Name { get; private set; }

        public MenuDisplayName(string name)
        {
            this.Name = name;
        }
    }
}
