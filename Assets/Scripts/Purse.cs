using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purse : MonoBehaviour
{
    public static Purse instance;
    public int coins;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        print("Coins: " + coins);
    }
}
