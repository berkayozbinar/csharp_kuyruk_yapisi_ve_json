using System;

namespace veriproje
{
    public class Poetry
    {
        public string Name { get; set; }
        public int NumberOfStanza { get; set; }
        public int NumberOfVerse { get; set; }
        public Poetry(string name, int numberofstanza, int numberofverse)
        {
            Name = name;
            NumberOfStanza = numberofstanza;
            NumberOfVerse = numberofverse;
        }
    }
}
