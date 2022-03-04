using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i = i + 2)
        {
            Console.WriteLine(i);
        }

        string[] candy = {"snickers", "reeses", "kit-kat", "crunch"};
        Console.WriteLine(candy[3]);

        string[] friends = {"alyssa", "sophie", "adri", "madi"};
        Console.WriteLine(friends.Length);

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
