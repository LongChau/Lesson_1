using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Khong keo tha vao object trong unity duoc.
public class HelperClass
{
    public void MyRandom()
    {
        UnityEngine.Random.Range(1, 2);
        System.Random rand = new System.Random();
        rand.Next(1, 2);
    }
}
