using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmouredGoblin : GoblinScript
{
    // Start is called before the first frame update
    void Start()
    {
        AttackPlayer();
    }
    public override void AttackPlayer()
    {
        print("Armoured-Goblin is Attacking the player!");

    }
}
