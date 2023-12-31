using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisophoniaAccessibility.UserInterface;

namespace MisophoniaAccessibility.Config
{
    public class Sounds
    {
        [GameSound(codeName: "eat", displayName: "Disable eat sound")]
        public bool DisableEatSound { get; set; } = true;

        [GameSound(codeName: "gulp", displayName: "Disable drink sound")]
        public bool DisableDrinkSound { get; set; } = false;

        [GameSound(codeName: "bubbles", displayName: "Disable keg sound")]
        public bool DisableBubblesSound { get; set; } = false;
    }
}
