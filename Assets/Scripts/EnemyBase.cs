using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBase : MonoBehaviour
{
    public GameObject textValue;

     void Start()
    {
        textValue.SetActive(false);
    }
    public virtual void AttackPlayer()
    {
        print("Enemy is attacking player");
    }
    void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.red;

       textValue.SetActive(true);
        AttackPlayer();
    }

    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.white;
        textValue.SetActive(false);

    }

}
