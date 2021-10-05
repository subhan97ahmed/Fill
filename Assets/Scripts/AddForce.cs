using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    public Vector2 gravity;
    public float speed =9.8f;
    // Start is called before the first frame update
    void Start()
    {
       rbody2D =GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.acceleration.x !=0)
        {

        gravity =Physics2D.gravity;
        Vector3 v3 =Input.acceleration;
        Vector2 v2 = v3;
        // rbody2D.AddForce(Physics.gravity);
        // rbody2D.AddForce(v3*speed);
        // rbody2D.AddRelativeForce(Physics.gravity);
        Debug.DrawRay(transform.position+Vector3.up,v3,Color.red);
        // making particle slow after a while
        Physics2D.gravity =v2*speed;
        }   
    }

}
