using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyGoblin : GoblinScript
{
    // Start is called before the first frame update
    void Start()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Friendly-Goblin is Attacking the player!");

    }
}
