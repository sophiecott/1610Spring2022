using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switches : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int day = 6;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("TUesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday")
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }
    }

    private string name = "Caleb";
    switch(name)
    {
        case "Caleb":
        Console.WriteLine("You are so legit");
            break;
        case "Corwin":
            Console.WriteLine("Please marry me!")
            yield break;
        case "Caitrin":
        Console.WriteLine("Get the heck away you dirty freak bag");
        yield break;
        default
        Console.WriteLine("who are you man?");
        yield break;
        
    }

// Update is called once per frame
    void Update() {
        
    }
}
