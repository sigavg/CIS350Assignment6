/* Luke Lesimple
 * Assignment 6
 * weapon attached to enemy
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damageBonus;

    public Enemy enemyHolding;

    private void Awake()
    {
        enemyHolding = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHolding);
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy eats weapon");
    }

    public void Recharge()
    {
        Debug.Log("Recharging Weapon!");
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
