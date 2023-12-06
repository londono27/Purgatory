using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class ArbustosSafe : MonoBehaviour
{
    public static ArbustosSafe Instance;
    private bool estadoPlayer =true;
    private Collider2D jugador = null;
    private bool isKeyPressedRight;
    private bool isKeyPressedLeft;
    private bool isKeyBarra;

    void Update()
    {
            if (!estadoPlayer & jugador != null)
            {
                bool isKeyPressedRight = Input.GetKey(KeyCode.RightArrow);
                bool isKeyPressedLeft = Input.GetKey(KeyCode.LeftArrow);
                bool isKeyBarra = Input.GetKey(KeyCode.Space);
                if (isKeyPressedRight || isKeyPressedLeft || isKeyBarra)
                {
                    estadoPlayer = true;//muere
                    jugador.gameObject.SetActive(true); 
                }
                else
                {
                    estadoPlayer = false;//vive
                    jugador.gameObject.SetActive(false); 
                }
            }
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        jugador = collision;
        if (collision.CompareTag("Player"))
        {
            isKeyPressedRight = Input.GetKey(KeyCode.RightArrow);
            isKeyPressedLeft = Input.GetKey(KeyCode.LeftArrow);
            isKeyBarra= Input.GetKey(KeyCode.Space);
            if (isKeyPressedRight || isKeyPressedLeft || isKeyBarra)
            {
                estadoPlayer = true;
                jugador.gameObject.SetActive(true);
            }
            else
            {
                estadoPlayer = false;
                jugador.gameObject.SetActive(false);
            }
        }
    }

}
