using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JefeFinal : MonoBehaviour
{
    Rigidbody2D rb2D;
    public float vel; 
    private float aum;
    private float presiona;
    void Start(){
        rb2D = GetComponent<Rigidbody2D>();
        aum=(float)0.002;
    }
    // Update is called once per frame
    void Update()
    {
        rb2D.velocity=new Vector2(vel,rb2D.velocity.y);
        vel=vel+aum;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            presiona=Input.GetAxisRaw("Horizontal");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamagedFinal(presiona);
        }
    }
}
