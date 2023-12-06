using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoP : MonoBehaviour
{
    [SerializeField] private Transform[] puntosMoviendo;
    [SerializeField] private float velocidadMovimineto;
    private int siguientePlataforma = 1;
    private bool ordenPlataformas = true;
    private bool mover = false;


    public void setMover(bool mover)
    {
        this.mover = mover;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(mover);
        if(mover){
            if(ordenPlataformas && siguientePlataforma + 1 >= puntosMoviendo.Length)
            {
                ordenPlataformas = false;
            }
            if(!ordenPlataformas && siguientePlataforma <= 0)
            {
                ordenPlataformas = true;
            }

            if(Vector2.Distance(transform.position, puntosMoviendo[siguientePlataforma].position) < 0.1f)
            {
                if(ordenPlataformas){
                    siguientePlataforma += 1;
                }else{
                    siguientePlataforma -= 1;
                }
            }
            transform.position = Vector2.MoveTowards( transform.position, puntosMoviendo[siguientePlataforma].position, velocidadMovimineto * Time.deltaTime);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(this.transform);
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);
        }
    }
}
