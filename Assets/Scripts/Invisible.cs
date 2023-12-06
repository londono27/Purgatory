using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Invisible : MonoBehaviour
{

    public TilemapRenderer tilemapRenderer;
    public float delay = 1.5f;
    private WaitForSeconds waitTime;

    void Start()
    {
        // Puedes asignar el Tilemap Renderer desde el Inspector
        tilemapRenderer = GetComponent<TilemapRenderer>();

        // Asegurarse de que al inicio el Tilemap Renderer esté desactivado
        tilemapRenderer.enabled = false;
    }

    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            // Activar el Tilemap Renderer si el jugador entra en contacto
            tilemapRenderer.enabled = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        // Verificar si el jugador ha salido del contacto con el Tilemap
        if (other.collider.CompareTag("Player"))
        {
            // Desactivar el Tilemap Renderer si el jugador sale del contacto
            tilemapRenderer.enabled = false;
        }
    }
}
