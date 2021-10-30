using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    Rigidbody2D rb;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    /*private void FixedUpdate()
    {
        if (Vector3.Magnitude(rb.velocity) < 2.5f)
            rb.velocity = Vector3.zero;
    }*/
}
