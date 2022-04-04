/* Luke Lesimple
 * Assignment 6
 * Deletes enemies out of bounds and gives them speed when spawned
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydelete : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

        if(transform.position.x > 100)
        {
            rb.velocity = new Vector3(-50, 0, 0);
        }
        else if(transform.position.x < -100)
        {
            rb.velocity = new Vector3(50, 0, 0);
        }
        else if (transform.position.y > 70)
        {
            rb.velocity = new Vector3(0, -50, 0);
        }
        else if (transform.position.y < -70)
        {
            rb.velocity = new Vector3(0, 50, 0);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(!other.CompareTag("Spawnarea"))
        {
            Destroy(this);
            EnemySpawning.count--;
        }
    }

}
