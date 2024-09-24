using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WerewolfScript : EnemyBase
{
    void Start()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Werewolf is attacking player");
    }
}
