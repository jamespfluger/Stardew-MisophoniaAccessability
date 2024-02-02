using HarmonyLib;
using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisophoniaAccessibility
{
    /// <summary>
    /// Harmony patch for the sound
    /// </summary>
    internal class SoundPatch
    {
        /// <summary>
        /// Modifies the Game1.playSound method to not play the eating sound
        /// </summary>
        /// <param name="cueName">Sound that will be played from Stardew Valley</param>
        internal static bool PatchSound(string cueName)
        {
            return !MisophoniaAccessibilityMod.DisabledCodeSounds.TryGetValue(key: cueName, value: out _);
        }
    }
}
