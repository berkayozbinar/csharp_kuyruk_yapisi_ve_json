using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace veriproje
{
    public class Poetrist
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nationality { get; set; }
        public List<Poetry> Poetry { get; set; } = new List<Poetry>();

        [JsonConstructor]
        public Poetrist(string name, string surname, string nationality)
        {
            Name = name;
            Surname = surname;
            Nationality = nationality;
        }
        public Poetrist(string name, string surname, string nationality, Poetry poetry) : this(name, surname, nationality) => AddPoetry(poetry);
        public void AddPoetry(Poetry poetry)
        {
            if (Poetry.Exists(p => p.Name == poetry.Name)) return;
            Poetry.Add(poetry);
        }
    }
}
