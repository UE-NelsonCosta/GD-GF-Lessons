
// Nice simple base class, to exemplify a animal, can extend MonoBehaviour to become a component

using UnityEngine;

public abstract class AAnimal
{
    public AAnimal(string name, string sound = "No Sound Supplied :l Please Configure!")
    {
        // Name is an accessor (see below) and name is the variable that we're accessing
        // Sound is also an accessor but with an example variable internal to it. (see below)
        Name = name;
        Sound = sound;
    }
    
    // Name Of The Animal
    protected string name;
    // Example Of A Property Acessor, Noone Except The Children Class Or This Class Are Able To Edit Name Directly, But
    // They Can Through This Property Accessor, it's just to keep it's values encapsulated
    // In this example, anyone can "Get" the name, but not "Set" the name
    public string Name
    {
        // Sometimes you only want soemthing to be settable from the class, a
        get { return name; }
        private set { name = value; }
    }

    // Sound To Be Made As All Animals Make Some Sort Of Sound 
    // If an accessor is written this way, you dont need to write the variable in C# Specifically, as it's internally there
    public string Sound { get; set; }

    // Abstract Function means the children HAVE TO implement the functions
    public abstract void MakeNoiseAbstract();
    
    // Virtual Function means they dont have to as long as the parent gives a default body to the function.
    public virtual void MakeNoiseVirtual() { Debug.LogError("Unimplemented virtual!");}
}
