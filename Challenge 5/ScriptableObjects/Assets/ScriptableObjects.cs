using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public UnityEvent onZeroEvent;

    public float value;

    public new string name;
    public string description;

    public Sprite artwork;

    public int attack;
    public int itemCost;
    public int health;

    public void UpdateValue(float number)
    {
        value += number;
    }

    public void Print()
    {
        Debug.Log(name + ": " + description + " The item costs: " + itemCost);
    }

    public void Awake()
    {
        
    }

public class EnenmyData : ScriptableObject
    {
        public string enemyName;
        public string description;
        public int health = 20;
        public float speed = 2f;
        public int number = 5; 

    }

    public void DisplayImage(Image img)
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
