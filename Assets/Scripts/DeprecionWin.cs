using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeprecionWin : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Activar el Tilemap Renderer si el jugador entra en contacto
            
        }
    }
}
