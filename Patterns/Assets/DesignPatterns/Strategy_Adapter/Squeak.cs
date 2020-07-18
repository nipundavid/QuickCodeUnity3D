using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squeak : IQuackBehaviour
{
    public void Quack()
    {
        Debug.Log("Quack Quack");
    }
}
