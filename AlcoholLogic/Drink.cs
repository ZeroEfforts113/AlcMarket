using System;

namespace AlcoholLogic
{
    internal class Drink
    {
        internal Drink() { }
        internal Drink(string name, DateTime date, float procentOfAlc, string country, float volume) 
        {
            Name = name;
            DateOfManufacture = date;
            ProcentOfAlc = procentOfAlc;
            Counrty = country;
            Volume = volume;
        }
        //internal string GetName() { return Name; }
        
        string Name { get; set; }
        DateTime DateOfManufacture { get; set; }
        float ProcentOfAlc { get; set; }
        string Counrty { get; set; }
        internal float Volume { get => Volume; set => Volume = value>0 && value<20? value: throw new Exception(); }
        

    }
}
