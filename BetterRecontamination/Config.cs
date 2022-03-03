using System.ComponentModel;
using Exiled.API.Interfaces;

namespace BetterRecontamination
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("The amount of players that need to go in larrys containment before Larry can be recontained.")]
        public int NumSacrifices { get; set; } = 1;
    }
}