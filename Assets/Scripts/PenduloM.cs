using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenduloM : MonoBehaviour
{

    Rigidbody2D rb;
    public float leftLimit = 0.3f;
    public float rightLimit = 0.3f;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();
     rb.angularVelocity = 500;   
    }

    // Update is called once per frame
    void Update()
    {
        swingMove();
        
    }
    public void swingMove() 
    {
        if(transform.rotation.z < rightLimit && rb.angularVelocity > 0 && rb.angularVelocity < speed)
        {
            rb.angularVelocity = speed;
        }
        else if(transform.rotation.z > rightLimit && rb.angularVelocity < 0 && rb.angularVelocity > speed)
        {
            rb.angularVelocity = -speed;
        }
    }
}
