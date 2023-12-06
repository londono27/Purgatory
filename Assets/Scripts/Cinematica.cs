using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Cinematica : MonoBehaviour
{
    public PlayableDirector director;


    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Activar el Tilemap Renderer si el jugador entra en contacto
            director.Play();
        }
    }
}
