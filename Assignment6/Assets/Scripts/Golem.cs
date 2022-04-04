using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;

    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        health = 120;
        GameManager.Instance.score +=2 ;
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Golem Attacks");
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("golem took "+amount);
    }
}
