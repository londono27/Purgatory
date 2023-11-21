using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JefeFinal : MonoBehaviour
{
    Rigidbody2D rb2D;
    public float vel; 
    private float aum;
    void Start(){
        rb2D = GetComponent<Rigidbody2D>();
        aum=(float)0.001;
    }
    // Update is called once per frame
    void Update()
    {
        rb2D.velocity=new Vector2(vel,rb2D.velocity.y);
        vel=vel+aum;
    }
}
