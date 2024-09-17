
// Cat Derived/Child Class of AAnimal, Animal is it's generic abstraction
// Contains all the parents functions and variables.

using UnityEngine;

public class Cat : AAnimal
{
    private string CatSecondaryNoise = "";
    
    public Cat(string name, string sound) : base(name, sound)
    {
        // Cat doesn't care of additional stuff, let's the parent handle the variable setting
    }
    
    

    // Abstract Implementation
    public override void MakeNoiseAbstract()
    {
        Debug.Log($"Cat::MakeNoiseAbstract: {Sound}");
    }


}
