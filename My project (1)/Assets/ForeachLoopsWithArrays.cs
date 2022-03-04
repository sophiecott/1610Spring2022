using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] colors = {"red", "green", "blue", "yellow"};
        foreach (string i in colors)
        {
            Console.WriteLine(i);
        }
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        Array.Sort(cars);
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
