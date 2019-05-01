using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public LayerMask myLayer;
    public float speed = 1;
    public float jump = 1;
    public float resistance = 2;
    public bool grounded;

    private Collider2D myCollider;
    private Rigidbody2D myRigid;


    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
        /*
        grounded = Physics2D.IsTouchingLayers(myCollider, myLayer);
        if (grounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                myRigid.velocity = new Vector2(myRigid.velocity.x, jump);
            }

            myRigid.velocity = new Vector2(myRigid.velocity.x - resistance, myRigid.velocity.y);
        }
        */
    }
}
