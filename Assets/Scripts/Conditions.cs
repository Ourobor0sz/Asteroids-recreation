using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    // Start is called before the first frame update
    //int num = 1; //Whole numbers
    //string words = "hello"; // text variables
    //float specialNum = 0.0f; //numbers that can be decimals

    // int a = 2;
    // int b = 3;

    float MaxHealth = 200;
    float CurrentHealth = 200;

    float CurrentMana = 10;
    float SpellCost = 100;

    //create floats here


    
    void Start()
    {
        if(CurrentHealth > MaxHealth *.75)
        {
            Debug.Log("Ready for battle!");
        }
        else
        {
            Debug.Log("You must Rest...");
        }

        if (CurrentMana > SpellCost)
        {
            Debug.Log("You're a wizard, Harry!");
        }
        else
        {
            Debug.Log("You need more potions...");
        }

    }

 
}
