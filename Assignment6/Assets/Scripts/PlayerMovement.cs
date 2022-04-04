/* Luke Lesimple
 * Assignment 6
 * Player movement
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    protected int xbound;
    protected int ybound;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0, 0, 14.6f);

        speed = 100f;
        xbound = 100;
        ybound = 70;
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(transform.position.x) <= xbound && Mathf.Abs(transform.position.y) <= ybound)
        {
            moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        }

        if(transform.position.x > xbound)
        {
            transform.position = new Vector3(xbound, transform.position.y, transform.position.z);
        }
        else if(transform.position.y > ybound)
        {
            transform.position = new Vector3(transform.position.x, ybound, transform.position.z);
        }
        else if(transform.position.x < -xbound)
        {
            transform.position = new Vector3(-xbound, transform.position.y, transform.position.z);
        }
        else if(transform.position.y < -ybound)
        {
            transform.position = new Vector3(transform.position.x, -ybound, transform.position.z);
        }

    }

    void moveCharacter(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
