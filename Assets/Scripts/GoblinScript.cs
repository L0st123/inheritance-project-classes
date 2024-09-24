using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinScript : EnemyBase
{
    void Start()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Goblin is attacking player");
    }
}
