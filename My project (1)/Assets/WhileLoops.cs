using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
int i = 0;
while (i < 5)
{
	Console.WriteLine(i);
	i++;
}
  int i = 0;

while (true)
{
    Console.WriteLine("i = {0}", i);

    i++;

    if (i > 10)
        break;
}
int i = 0, j = 1;

while (i < 2)
{
    Console.WriteLine("i = {0}", i);
    i++;

    while (j < 2)
    {
        Console.WriteLine("j = {0}", j);
        j++;
    }
int index = 1;
while (index <= 5)
{
	Console.WriteLine(index);
	index++;
}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
