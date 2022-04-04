/* Luke Lesimple
 * Assignment 6
 * Controls obstacle spawning
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public static int count;
    public int leveldiff;

    public GameObject prefab;

    private void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(count < leveldiff)
        {
            int direction = Random.Range(0, 3);
            int pos = Random.Range(-70, 70);

            if( direction == 0) //downwards
            {
                Instantiate(prefab, new Vector3(pos, 90, 14.6f), Quaternion.identity); 
            }
            else if( direction == 1) //leftwards
            {
                Instantiate(prefab, new Vector3(110, pos, 14.6f), Quaternion.identity);
            }
            else if (direction == 2) //upwards
            {
                Instantiate(prefab, new Vector3(pos, -90, 14.6f), Quaternion.identity);
            }
            else if (direction == 3) //rightwards
            {
                Instantiate(prefab, new Vector3(-110, pos, 14.6f), Quaternion.identity);
            }
            count++;
        }
    }
}
