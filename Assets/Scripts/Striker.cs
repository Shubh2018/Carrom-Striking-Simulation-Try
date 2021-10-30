using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Striker : MonoBehaviour
{
    Vector3 mousePos;
    Vector3 strikerInitialPos;
    Vector3 directionToLaunch;
    Rigidbody2D rb;
    [SerializeField]
    float launchForce = 10.0f;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //if (Vector3.Magnitude(rb.velocity) < 1.5f)
        //{
            //rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);

            if (Input.GetKeyDown(KeyCode.R))
                Reset();
        //}
    }

    private void OnMouseDown()
    {
        strikerInitialPos = this.transform.position;
    }

    private void OnMouseDrag()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = strikerInitialPos.z;
        this.transform.position = mousePos;
    }

    private void OnMouseUp()
    {
        directionToLaunch = strikerInitialPos - mousePos;
        rb.AddForce(directionToLaunch * launchForce);
    }

    private void Reset()
    {
        this.transform.position = Vector3.zero;
    }
}
