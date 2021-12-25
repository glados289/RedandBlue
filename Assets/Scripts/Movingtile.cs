using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingtile : MonoBehaviour
{
    public float speed;
    public float position1;
    public float position2;
    bool moveRight;

    void Update()
    {
        if(transform.position.x > position1)
        {
            moveRight = false;
        }
        else if(transform.position.x < position2)
        {
            moveRight = true;
        }

        if(moveRight)
        {
            transform.position = new Vector3(transform.position.x + speed*Time.deltaTime, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - speed*Time.deltaTime, transform.position.y, transform.position.z);
        }

    }
}
