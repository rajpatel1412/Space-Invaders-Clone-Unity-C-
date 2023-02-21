using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("Collision with wall");
        if(collision.gameObject.tag != "Player")
            Destroy(collision.gameObject);
    }
}
