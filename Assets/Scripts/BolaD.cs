using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaD : MonoBehaviour
{

    public Movimiento_main jugador;

        private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
             jugador.Recolocar();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
