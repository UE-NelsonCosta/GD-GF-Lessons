using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugInheritanceScript : MonoBehaviour
{
    private Cat CatExample;
    private Dog DogExample;
    private Human HumanExample;
    
    [SerializeField] private bool MakeNoiseWithAbstract = true;
    
    // Start is called before the first frame update
    void Start()
    {
        CatExample = new Cat("Rabstrantrator", "Miiihooowwwww");
        DogExample = new Dog("Borkinator", "Woof Woof ********");
            
        HumanExample = new Human("Tom", "Eiya! Me Names Tom Ye? Wuboud Yours Lav?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(MakeNoiseWithAbstract)
                CatExample.MakeNoiseAbstract();
            else
                CatExample.MakeNoiseVirtual();
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if(MakeNoiseWithAbstract)
                DogExample.MakeNoiseAbstract();
            else
                DogExample.MakeNoiseVirtual();
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if(MakeNoiseWithAbstract)
                HumanExample.MakeNoiseAbstract();
            else
                HumanExample.MakeNoiseVirtual();
        }
    }
}
