using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOnMovingTile : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D box)
    {
        if(box.gameObject.name.Equals("Movingtile"))
        {
            this.transform.parent = box.transform;
            

        }
    }
    private void OnCollisionExit2D(Collision2D box)
    {
        if(box.gameObject.name.Equals("Movingtile"))
        {
            this.transform.parent = null;
            
        }
    }
}
