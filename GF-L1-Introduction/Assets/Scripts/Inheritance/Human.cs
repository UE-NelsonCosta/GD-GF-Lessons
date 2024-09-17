
using System.Collections.Generic;
using UnityEngine;

public class Human : AAnimal
{
    private List<AAnimal> pets = new List<AAnimal>();
    
    public Human(string name, string sound) : base(name, sound)
    {
        pets.Add(new Cat("Lucy", "FFFFFFFFSSRAWRRR"));
        pets.Add(new  Dog("Bobby", "Roooooooof"));
    }

    // Abstract Implementation
    public override void MakeNoiseAbstract()
    {
        Debug.Log($"Human::MakeNoiseAbstract: {Sound}");
    }

    // Virtual Implementation
    public override void MakeNoiseVirtual()
    {
        Debug.Log($"Human::MakeNoiseVirtual: {Sound}");

        Debug.Log($"{Name} has {pets.Count} pets, named:");
        for (int i = 0; i < pets.Count; ++i)
        {
            Debug.Log(pets[i].Name);
        }
    }
}
