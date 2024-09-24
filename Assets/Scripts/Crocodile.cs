using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy
{
    private float attackRange;
    private Player player;
    public override void Behavior()
    {
        Debug.Log("I'm Crocodile behavior");
    }
}
