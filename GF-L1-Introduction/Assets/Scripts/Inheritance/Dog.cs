using UnityEngine;

public class Dog : AAnimal
{
    public Dog(string name, string sound) : base(name, sound)
    {
        // Cat doesn't care of additional stuff, let's the parent handle the variable setting
    }

    // Abstract Implementation
    public override void MakeNoiseAbstract()
    {
        Debug.Log($"Dog::MakeNoiseAbstract: {Sound}");
    }

    // Virtual Implementation
    public override void MakeNoiseVirtual()
    {
        Debug.Log($"Dog::MakeNoiseVirtual: {Sound}");
    }
}
