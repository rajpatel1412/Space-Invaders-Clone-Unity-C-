using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);

        rigidbody.velocity = dir.normalized * speed;

        GetComponent<Animator>().SetBool("IsFlyingLeft", h < 0);
        // GetComponent<Animator>().SetBool("IsFlyingLeft", (h < 0 && v > 0));
        GetComponent<Animator>().SetBool("IsFlyingRight", h > 0);
        // GetComponent<Animator>().SetBool("IsFlyingRight", (h > 0 && v > 0));
        // GetComponent<Animator>().SetBool("IsFlyingUp", (v >= 0 || h == 0));
        GetComponent<Animator>().SetBool("IsFlyingUp", (v > 0));
        GetComponent<Animator>().SetBool("IsFlyingBottom", v < 0);
        // GetComponent<Animator>().SetBool("IsFlyingBottom", (h < 0 && v < 0));
        // GetComponent<Animator>().SetBool("IsFlyingBottom", (h > 0 && v < 0));
    }
}
